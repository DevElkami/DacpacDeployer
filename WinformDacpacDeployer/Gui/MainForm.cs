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
            materialTextBoxSqlPackagePath.DataBindings.Add("Text", myDeployerCore, "SqlPackageFullPath", false, DataSourceUpdateMode.OnPropertyChanged);
            materialTextBoxDacpacPath.DataBindings.Add("Text", myDeployerCore, "SourceFile", false, DataSourceUpdateMode.OnPropertyChanged);
            materialTextBoxSqlServer.DataBindings.Add("Text", myDeployerCore, "TargetServerName", false, DataSourceUpdateMode.OnPropertyChanged);
            materialTextBoxDatabaseName.DataBindings.Add("Text", myDeployerCore, "TargetDatabaseName", false, DataSourceUpdateMode.OnPropertyChanged);
            materialTextBoxSqlUser.DataBindings.Add("Text", myDeployerCore, "TargetUser", false, DataSourceUpdateMode.OnPropertyChanged);
            materialTextBoxSqlPassword.DataBindings.Add("Text", myDeployerCore, "TargetPassword", false, DataSourceUpdateMode.OnPropertyChanged);
            materialCheckBoxDropObjectsNotInSource.DataBindings.Add("Checked", myDeployerCore, "DropObjectsNotInSource", false, DataSourceUpdateMode.OnPropertyChanged);
            materialCheckBoxBlockOnPossibleDataLoss.DataBindings.Add("Checked", myDeployerCore, "BlockOnPossibleDataLoss", false, DataSourceUpdateMode.OnPropertyChanged);
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
            materialTextBoxSqlPackagePath.Text = Properties.Settings.Default.SqlPackage;
            materialTextBoxDacpacPath.Text = Properties.Settings.Default.SqlDacpac;
            materialTextBoxSqlServer.Text = Properties.Settings.Default.SqlServer;
            materialTextBoxDatabaseName.Text = Properties.Settings.Default.SqlDatabase;
            materialTextBoxSqlUser.Text = Properties.Settings.Default.SqlUserName;
            materialCheckBoxDropObjectsNotInSource.Checked = Properties.Settings.Default.DropObjectsNotInSource;
            materialCheckBoxBlockOnPossibleDataLoss.Checked = Properties.Settings.Default.BlockOnPossibleDataLoss;

            materialSwitchSqlConnection.Checked = Properties.Settings.Default.SqlAuth;
        }
        catch (Exception except)
        {
            LogManager.GetLogger(nameof(WinformDacpacDeployer)).Fatal(except.ToString());
            MessageBox.Show(except.Message);
        }
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
            materialButtonDeploy.Enabled = false;
            pictureBoxWait.Visible = true;

            Properties.Settings.Default.SqlPackage = materialTextBoxSqlPackagePath.Text;
            Properties.Settings.Default.SqlDacpac = materialTextBoxDacpacPath.Text;
            Properties.Settings.Default.SqlServer = materialTextBoxSqlServer.Text;
            Properties.Settings.Default.SqlDatabase = materialTextBoxDatabaseName.Text;
            Properties.Settings.Default.SqlUserName = materialTextBoxSqlUser.Text;
            Properties.Settings.Default.DropObjectsNotInSource = materialCheckBoxDropObjectsNotInSource.Checked;
            Properties.Settings.Default.BlockOnPossibleDataLoss = materialCheckBoxBlockOnPossibleDataLoss.Checked;

            Properties.Settings.Default.SqlAuth = materialSwitchSqlConnection.Checked;

            Properties.Settings.Default.Save();
            await myDeployerCore.DeployAsync();
            MessageBox.Show("Déploiement réalisé avec succès", "Déploiement", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
