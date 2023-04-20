using DacpacDeployer;
using System.Diagnostics;
using System.Text;

namespace DacpacDeployerCore;

/// <summary>
/// High level API
/// </summary>
public class DeployerCore
{
    public String SqlPackageFullPath { get; set; } = null!;
    public String SourceFile { get; set; } = null!;
    public String TargetDatabaseName { get; set; } = null!;
    public String TargetServerName { get; set; } = null!;
    public bool DropObjectsNotInSource { get; set; } = false;
    public bool BlockOnPossibleDataLoss { get; set; } = false;
    public String TargetUser { get; set; } = null!;
    public String TargetPassword { get; set; } = null!;

    public AsyncStreamReader.EventHandler<string> DataReceived = null!;

    public enum AuthenticationType
    {
        WindowsAuth,
        SqlAuth
    }
    public AuthenticationType AuthType { get; set; } = AuthenticationType.SqlAuth;

    public async Task DeployAsync()
    {
        await Task.Factory.StartNew(() => Deploy());
    }

    public void Deploy()
    {
        if (!File.Exists(SqlPackageFullPath))
            throw new FileNotFoundException("Sql package not found", SqlPackageFullPath);

        if (String.IsNullOrEmpty(SourceFile))
            throw new ArgumentNullException(nameof(SourceFile), "You must provide a dacpac file");

        if (String.IsNullOrEmpty(TargetDatabaseName))
            throw new ArgumentNullException(nameof(TargetDatabaseName), "You must provide a database name");

        if (String.IsNullOrEmpty(TargetServerName))
            throw new ArgumentNullException(nameof(TargetServerName), "You must provide a database server");

        String args = "";
        switch (AuthType)
        {
            case AuthenticationType.SqlAuth: args = AuthSqlDeploy(); break;
            case AuthenticationType.WindowsAuth: args = AuthWindowsDeploy(); break;
        }

        Process compiler = new Process();
        compiler.StartInfo.FileName = SqlPackageFullPath;
        compiler.StartInfo.Arguments = args;

        compiler.StartInfo.UseShellExecute = false;
        compiler.StartInfo.CreateNoWindow = true;

        compiler.StartInfo.RedirectStandardOutput = true;
        compiler.StartInfo.RedirectStandardError = true;
        compiler.StartInfo.RedirectStandardInput = true;

        compiler.StartInfo.StandardOutputEncoding = Encoding.UTF8;
        compiler.StartInfo.StandardErrorEncoding = Encoding.UTF8;
        compiler.StartInfo.StandardInputEncoding = Encoding.UTF8;

        compiler.Start();

        AsyncStreamReader stdOut = new(compiler.StandardOutput);
        stdOut.DataReceived += DataReceived;
        stdOut.Start();

        compiler.WaitForExit();

        if (compiler.ExitCode != 0)
            throw new Exception(compiler.StandardError.ReadToEnd());
    }

    private String AuthWindowsDeploy()
    {
        return $"/Action:Publish /SourceFile:{SourceFile} /p:LongRunningCommandTimeout=180 /p:DropObjectsNotInSource={DropObjectsNotInSource} /p:BlockOnPossibleDataLoss={BlockOnPossibleDataLoss} /TargetDatabaseName:{TargetDatabaseName} /TargetServerName:{TargetServerName}";
    }

    private String AuthSqlDeploy()
    {
        if (String.IsNullOrEmpty(TargetUser))
            throw new ArgumentNullException(nameof(TargetUser), "You must provide a user name");

        return AuthWindowsDeploy() + $" /TargetUser:{TargetUser} /TargetPassword:{TargetPassword}";
    }
}
