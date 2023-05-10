using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Dac;

namespace DacpacDeployerCore;

/// <summary>
/// High level API
/// </summary>
public class DeployerCore
{
    public String SourceFile { get; set; } = null!;
    public String TargetDatabaseName { get; set; } = null!;
    public String TargetServerName { get; set; } = null!;
    public String TargetUser { get; set; } = null!;
    public String TargetPassword { get; set; } = null!;
    public DacDeployOptions DeployOptions { get; set; } = new DacDeployOptions();

    public event EventHandler<DacMessageEventArgs> Message = null!;

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
        if (String.IsNullOrEmpty(SourceFile))
            throw new ArgumentNullException(nameof(SourceFile), "You must provide a dacpac file");

        if (String.IsNullOrEmpty(TargetDatabaseName))
            throw new ArgumentNullException(nameof(TargetDatabaseName), "You must provide a database name");

        if (String.IsNullOrEmpty(TargetServerName))
            throw new ArgumentNullException(nameof(TargetServerName), "You must provide a database server");

        String connectionString = "";
        switch (AuthType)
        {
            case AuthenticationType.SqlAuth: connectionString = AuthSqlDeploy(); break;
            case AuthenticationType.WindowsAuth: connectionString = AuthWindowsDeploy(); break;
        }

        if (String.IsNullOrEmpty(connectionString))
            throw new ArgumentNullException("Connection string", "Can't build connection string");

        DacServices dacServices = new DacServices(connectionString);
        dacServices.Message += Message;
        DeployOptions.LongRunningCommandTimeout = 180;
        dacServices.Deploy(DacPackage.Load(SourceFile), TargetDatabaseName, true, DeployOptions);
    }

    private String AuthWindowsDeploy()
    {
        SqlConnectionStringBuilder builder = new()
        {
            DataSource = TargetServerName,
            InitialCatalog = TargetDatabaseName,
            IntegratedSecurity = true,
            TrustServerCertificate = true,
            PersistSecurityInfo = false
        };
        return builder.ConnectionString;
    }

    private String AuthSqlDeploy()
    {
        if (String.IsNullOrEmpty(TargetUser))
            throw new ArgumentNullException(nameof(TargetUser), "You must provide a user name");

        SqlConnectionStringBuilder builder = new()
        {
            DataSource = TargetServerName,
            InitialCatalog = TargetDatabaseName,
            IntegratedSecurity = false,
            TrustServerCertificate = true,
            PersistSecurityInfo = false,
            UserID = TargetUser,
            Password = TargetPassword
        };
        return builder.ConnectionString;
    }
}
