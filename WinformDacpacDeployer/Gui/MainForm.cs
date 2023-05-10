using NLog;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using System;
using System.Windows.Forms;
using DacpacDeployerCore;

namespace WinformDacpacDeployer;

public partial class MainForm : MaterialForm
{
    private readonly DeployerCore myDeployerCore = null;

    /// <summary>
    /// Main form constructor
    /// </summary>
    public MainForm(ref DeployerCore deployerCore)
    {
        try
        {
            myDeployerCore = deployerCore;
            InitializeComponent();

            MaterialSkinManager.Instance.AddFormToManage(this);
            this.FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_40;

            materialExpansionPanelSqlConnection.Collapse = true;
            materialExpansionPanelSqlConnection.Enabled = false;

            // Databinding with myDeployerCore            
            materialTextBoxDacpacPath.DataBindings.Add("Text", myDeployerCore, "SourceFile", false, DataSourceUpdateMode.OnPropertyChanged);
            materialTextBoxSqlServer.DataBindings.Add("Text", myDeployerCore, "TargetServerName", false, DataSourceUpdateMode.OnPropertyChanged);
            materialTextBoxDatabaseName.DataBindings.Add("Text", myDeployerCore, "TargetDatabaseName", false, DataSourceUpdateMode.OnPropertyChanged);
            materialTextBoxSqlUser.DataBindings.Add("Text", myDeployerCore, "TargetUser", false, DataSourceUpdateMode.OnPropertyChanged);
            materialTextBoxSqlPassword.DataBindings.Add("Text", myDeployerCore, "TargetPassword", false, DataSourceUpdateMode.OnPropertyChanged);
            materialCheckBoxDropObjectsNotInSource.DataBindings.Add("Checked", myDeployerCore.DeployOptions, "DropObjectsNotInSource", false, DataSourceUpdateMode.OnPropertyChanged);
            materialCheckBoxBlockOnPossibleDataLoss.DataBindings.Add("Checked", myDeployerCore.DeployOptions, "BlockOnPossibleDataLoss", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        catch (Exception except)
        {
            LogManager.GetLogger(nameof(WinformDacpacDeployer)).Fatal(except.ToString());
            MessageBox.Show(except.Message);
        }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        try
        {
            // Load last config
            materialTextBoxDacpacPath.Text = Properties.Settings.Default.SqlDacpac;
            materialTextBoxSqlServer.Text = Properties.Settings.Default.SqlServer;
            materialTextBoxDatabaseName.Text = Properties.Settings.Default.SqlDatabase;
            materialTextBoxSqlUser.Text = Properties.Settings.Default.SqlUserName;
            materialCheckBoxDropObjectsNotInSource.Checked = Properties.Settings.Default.DropObjectsNotInSource;
            materialCheckBoxBlockOnPossibleDataLoss.Checked = Properties.Settings.Default.BlockOnPossibleDataLoss;

            materialSwitchSqlConnection.Checked = Properties.Settings.Default.SqlAuth;

            // Console output
            myDeployerCore.Message += MyDeployerCore_ProgressChanged;
        }
        catch (Exception except)
        {
            LogManager.GetLogger(nameof(WinformDacpacDeployer)).Fatal(except.ToString());
            MessageBox.Show(except.Message);
        }
    }

    private void MyDeployerCore_ProgressChanged(object sender, Microsoft.SqlServer.Dac.DacMessageEventArgs e)
    {
        materialMultiLineTextBoxEditConsole.Invoke((MethodInvoker)delegate
        {
            materialMultiLineTextBoxEditConsole.Text += (e.Message.Message + Environment.NewLine);
        });
    }

    private void materialSwitchSqlConnection_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            materialExpansionPanelSqlConnection.Collapse = !materialSwitchSqlConnection.Checked;
            materialExpansionPanelSqlConnection.Enabled = materialSwitchSqlConnection.Checked;
        }
        catch (Exception except)
        {
            LogManager.GetLogger(nameof(WinformDacpacDeployer)).Fatal(except.ToString());
            MessageBox.Show(except.Message);
        }
    }

    private async void materialButtonDeploy_Click(object sender, EventArgs e)
    {
        try
        {
            materialMultiLineTextBoxEditConsole.Text = String.Empty;
            materialButtonDeploy.Enabled = false;
            pictureBoxWait.Visible = true;

            Properties.Settings.Default.SqlDacpac = materialTextBoxDacpacPath.Text;
            Properties.Settings.Default.SqlServer = materialTextBoxSqlServer.Text;
            Properties.Settings.Default.SqlDatabase = materialTextBoxDatabaseName.Text;
            Properties.Settings.Default.SqlUserName = materialTextBoxSqlUser.Text;
            Properties.Settings.Default.DropObjectsNotInSource = materialCheckBoxDropObjectsNotInSource.Checked;
            Properties.Settings.Default.BlockOnPossibleDataLoss = materialCheckBoxBlockOnPossibleDataLoss.Checked;

            Properties.Settings.Default.SqlAuth = materialSwitchSqlConnection.Checked;

            Properties.Settings.Default.Save();
            await myDeployerCore.DeployAsync();
            MessageBox.Show(Properties.Resources.ResourceManager.GetString("DeployWithSuccess"), Properties.Resources.ResourceManager.GetString("DeployTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception except)
        {
            LogManager.GetLogger(nameof(WinformDacpacDeployer)).Fatal(except.ToString());
            MessageBox.Show(except.Message);
        }
        finally
        {
            materialButtonDeploy.Enabled = true;
            pictureBoxWait.Visible = false;
        }
    }    

    private void materialButtonSelectDacpac_Click(object sender, EventArgs e)
    {
        try
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Dacpac file|*.dacpac";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    materialTextBoxDacpacPath.Text = openFileDialog.FileName;
            }
        }
        catch (Exception except)
        {
            LogManager.GetLogger(nameof(WinformDacpacDeployer)).Fatal(except.ToString());
            MessageBox.Show(except.Message);
        }
    }
}
