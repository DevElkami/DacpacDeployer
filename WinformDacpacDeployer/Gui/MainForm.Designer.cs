using ReaLTaiizor.Controls;

namespace WinformDacpacDeployer
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControlMain = new MaterialTabControl();
            tabPageDeploy = new System.Windows.Forms.TabPage();
            pictureBoxWait = new System.Windows.Forms.PictureBox();
            materialExpansionPanelDeployerParam = new MaterialExpansionPanel();
            materialCheckBoxBlockOnPossibleDataLoss = new MaterialCheckBox();
            materialCheckBoxDropObjectsNotInSource = new MaterialCheckBox();
            materialExpansionPanelSqlConnection = new MaterialExpansionPanel();
            materialTextBoxSqlPassword = new MaterialTextBoxEdit();
            materialTextBoxSqlUser = new MaterialTextBoxEdit();
            materialSwitchSqlConnection = new MaterialSwitch();
            materialTextBoxDatabaseName = new MaterialTextBoxEdit();
            materialTextBoxSqlServer = new MaterialTextBoxEdit();
            materialTextBoxDacpacPath = new MaterialTextBoxEdit();
            materialTextBoxSqlPackagePath = new MaterialTextBoxEdit();
            materialButtonDeploy = new MaterialButton();
            tabPageAbout = new System.Windows.Forms.TabPage();
            webViewGitHubProfile = new Microsoft.Web.WebView2.WinForms.WebView2();
            imageListTabCtrl = new System.Windows.Forms.ImageList(components);
            tabControlMain.SuspendLayout();
            tabPageDeploy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWait).BeginInit();
            materialExpansionPanelDeployerParam.SuspendLayout();
            materialExpansionPanelSqlConnection.SuspendLayout();
            tabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webViewGitHubProfile).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            resources.ApplyResources(tabControlMain, "tabControlMain");
            tabControlMain.Controls.Add(tabPageDeploy);
            tabControlMain.Controls.Add(tabPageAbout);
            tabControlMain.Depth = 0;
            tabControlMain.ImageList = imageListTabCtrl;
            tabControlMain.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlMain.Multiline = true;
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            // 
            // tabPageDeploy
            // 
            resources.ApplyResources(tabPageDeploy, "tabPageDeploy");
            tabPageDeploy.BackColor = System.Drawing.SystemColors.Control;
            tabPageDeploy.Controls.Add(pictureBoxWait);
            tabPageDeploy.Controls.Add(materialExpansionPanelDeployerParam);
            tabPageDeploy.Controls.Add(materialExpansionPanelSqlConnection);
            tabPageDeploy.Controls.Add(materialSwitchSqlConnection);
            tabPageDeploy.Controls.Add(materialTextBoxDatabaseName);
            tabPageDeploy.Controls.Add(materialTextBoxSqlServer);
            tabPageDeploy.Controls.Add(materialTextBoxDacpacPath);
            tabPageDeploy.Controls.Add(materialTextBoxSqlPackagePath);
            tabPageDeploy.Controls.Add(materialButtonDeploy);
            tabPageDeploy.Name = "tabPageDeploy";
            // 
            // pictureBoxWait
            // 
            resources.ApplyResources(pictureBoxWait, "pictureBoxWait");
            pictureBoxWait.Name = "pictureBoxWait";
            pictureBoxWait.TabStop = false;
            // 
            // materialExpansionPanelDeployerParam
            // 
            resources.ApplyResources(materialExpansionPanelDeployerParam, "materialExpansionPanelDeployerParam");
            materialExpansionPanelDeployerParam.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            materialExpansionPanelDeployerParam.Controls.Add(materialCheckBoxBlockOnPossibleDataLoss);
            materialExpansionPanelDeployerParam.Controls.Add(materialCheckBoxDropObjectsNotInSource);
            materialExpansionPanelDeployerParam.Depth = 0;
            materialExpansionPanelDeployerParam.Description = "Deploy parameters";
            materialExpansionPanelDeployerParam.ExpandHeight = 200;
            materialExpansionPanelDeployerParam.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanelDeployerParam.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialExpansionPanelDeployerParam.Name = "materialExpansionPanelDeployerParam";
            materialExpansionPanelDeployerParam.ShowValidationButtons = false;
            materialExpansionPanelDeployerParam.Title = "Other options";
            // 
            // materialCheckBoxBlockOnPossibleDataLoss
            // 
            resources.ApplyResources(materialCheckBoxBlockOnPossibleDataLoss, "materialCheckBoxBlockOnPossibleDataLoss");
            materialCheckBoxBlockOnPossibleDataLoss.Depth = 0;
            materialCheckBoxBlockOnPossibleDataLoss.MouseLocation = new System.Drawing.Point(-1, -1);
            materialCheckBoxBlockOnPossibleDataLoss.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBoxBlockOnPossibleDataLoss.Name = "materialCheckBoxBlockOnPossibleDataLoss";
            materialCheckBoxBlockOnPossibleDataLoss.ReadOnly = false;
            materialCheckBoxBlockOnPossibleDataLoss.Ripple = true;
            materialCheckBoxBlockOnPossibleDataLoss.UseAccentColor = false;
            materialCheckBoxBlockOnPossibleDataLoss.UseVisualStyleBackColor = true;
            // 
            // materialCheckBoxDropObjectsNotInSource
            // 
            resources.ApplyResources(materialCheckBoxDropObjectsNotInSource, "materialCheckBoxDropObjectsNotInSource");
            materialCheckBoxDropObjectsNotInSource.Depth = 0;
            materialCheckBoxDropObjectsNotInSource.MouseLocation = new System.Drawing.Point(-1, -1);
            materialCheckBoxDropObjectsNotInSource.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBoxDropObjectsNotInSource.Name = "materialCheckBoxDropObjectsNotInSource";
            materialCheckBoxDropObjectsNotInSource.ReadOnly = false;
            materialCheckBoxDropObjectsNotInSource.Ripple = true;
            materialCheckBoxDropObjectsNotInSource.UseAccentColor = false;
            materialCheckBoxDropObjectsNotInSource.UseVisualStyleBackColor = true;
            // 
            // materialExpansionPanelSqlConnection
            // 
            resources.ApplyResources(materialExpansionPanelSqlConnection, "materialExpansionPanelSqlConnection");
            materialExpansionPanelSqlConnection.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            materialExpansionPanelSqlConnection.Controls.Add(materialTextBoxSqlPassword);
            materialExpansionPanelSqlConnection.Controls.Add(materialTextBoxSqlUser);
            materialExpansionPanelSqlConnection.Depth = 0;
            materialExpansionPanelSqlConnection.Description = "Authentication parameters";
            materialExpansionPanelSqlConnection.ExpandHeight = 200;
            materialExpansionPanelSqlConnection.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanelSqlConnection.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialExpansionPanelSqlConnection.Name = "materialExpansionPanelSqlConnection";
            materialExpansionPanelSqlConnection.ShowCollapseExpand = false;
            materialExpansionPanelSqlConnection.ShowValidationButtons = false;
            materialExpansionPanelSqlConnection.Title = "SQL connection";
            // 
            // materialTextBoxSqlPassword
            // 
            resources.ApplyResources(materialTextBoxSqlPassword, "materialTextBoxSqlPassword");
            materialTextBoxSqlPassword.AnimateReadOnly = false;
            materialTextBoxSqlPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            materialTextBoxSqlPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            materialTextBoxSqlPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            materialTextBoxSqlPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            materialTextBoxSqlPassword.Depth = 0;
            materialTextBoxSqlPassword.HideSelection = true;
            materialTextBoxSqlPassword.LeadingIcon = null;
            materialTextBoxSqlPassword.MaxLength = 50;
            materialTextBoxSqlPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxSqlPassword.Name = "materialTextBoxSqlPassword";
            materialTextBoxSqlPassword.PasswordChar = '●';
            materialTextBoxSqlPassword.ReadOnly = false;
            materialTextBoxSqlPassword.SelectedText = "";
            materialTextBoxSqlPassword.SelectionLength = 0;
            materialTextBoxSqlPassword.SelectionStart = 0;
            materialTextBoxSqlPassword.ShortcutsEnabled = true;
            materialTextBoxSqlPassword.TabStop = false;
            materialTextBoxSqlPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            materialTextBoxSqlPassword.TrailingIcon = (System.Drawing.Image)resources.GetObject("materialTextBoxSqlPassword.TrailingIcon");
            materialTextBoxSqlPassword.UseSystemPasswordChar = true;
            // 
            // materialTextBoxSqlUser
            // 
            resources.ApplyResources(materialTextBoxSqlUser, "materialTextBoxSqlUser");
            materialTextBoxSqlUser.AnimateReadOnly = false;
            materialTextBoxSqlUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            materialTextBoxSqlUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            materialTextBoxSqlUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            materialTextBoxSqlUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            materialTextBoxSqlUser.Depth = 0;
            materialTextBoxSqlUser.HideSelection = true;
            materialTextBoxSqlUser.LeadingIcon = null;
            materialTextBoxSqlUser.MaxLength = 50;
            materialTextBoxSqlUser.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxSqlUser.Name = "materialTextBoxSqlUser";
            materialTextBoxSqlUser.PasswordChar = '\0';
            materialTextBoxSqlUser.ReadOnly = false;
            materialTextBoxSqlUser.SelectedText = "";
            materialTextBoxSqlUser.SelectionLength = 0;
            materialTextBoxSqlUser.SelectionStart = 0;
            materialTextBoxSqlUser.ShortcutsEnabled = true;
            materialTextBoxSqlUser.TabStop = false;
            materialTextBoxSqlUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            materialTextBoxSqlUser.TrailingIcon = (System.Drawing.Image)resources.GetObject("materialTextBoxSqlUser.TrailingIcon");
            materialTextBoxSqlUser.UseSystemPasswordChar = false;
            // 
            // materialSwitchSqlConnection
            // 
            resources.ApplyResources(materialSwitchSqlConnection, "materialSwitchSqlConnection");
            materialSwitchSqlConnection.Depth = 0;
            materialSwitchSqlConnection.MouseLocation = new System.Drawing.Point(-1, -1);
            materialSwitchSqlConnection.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialSwitchSqlConnection.Name = "materialSwitchSqlConnection";
            materialSwitchSqlConnection.Ripple = true;
            materialSwitchSqlConnection.UseAccentColor = false;
            materialSwitchSqlConnection.UseVisualStyleBackColor = true;
            materialSwitchSqlConnection.CheckedChanged += materialSwitchSqlConnection_CheckedChanged;
            // 
            // materialTextBoxDatabaseName
            // 
            resources.ApplyResources(materialTextBoxDatabaseName, "materialTextBoxDatabaseName");
            materialTextBoxDatabaseName.AnimateReadOnly = false;
            materialTextBoxDatabaseName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            materialTextBoxDatabaseName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            materialTextBoxDatabaseName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            materialTextBoxDatabaseName.Cursor = System.Windows.Forms.Cursors.IBeam;
            materialTextBoxDatabaseName.Depth = 0;
            materialTextBoxDatabaseName.HideSelection = true;
            materialTextBoxDatabaseName.LeadingIcon = null;
            materialTextBoxDatabaseName.MaxLength = 50;
            materialTextBoxDatabaseName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxDatabaseName.Name = "materialTextBoxDatabaseName";
            materialTextBoxDatabaseName.PasswordChar = '\0';
            materialTextBoxDatabaseName.ReadOnly = false;
            materialTextBoxDatabaseName.SelectedText = "";
            materialTextBoxDatabaseName.SelectionLength = 0;
            materialTextBoxDatabaseName.SelectionStart = 0;
            materialTextBoxDatabaseName.ShortcutsEnabled = true;
            materialTextBoxDatabaseName.TabStop = false;
            materialTextBoxDatabaseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            materialTextBoxDatabaseName.TrailingIcon = (System.Drawing.Image)resources.GetObject("materialTextBoxDatabaseName.TrailingIcon");
            materialTextBoxDatabaseName.UseSystemPasswordChar = false;
            // 
            // materialTextBoxSqlServer
            // 
            resources.ApplyResources(materialTextBoxSqlServer, "materialTextBoxSqlServer");
            materialTextBoxSqlServer.AnimateReadOnly = false;
            materialTextBoxSqlServer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            materialTextBoxSqlServer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            materialTextBoxSqlServer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            materialTextBoxSqlServer.Cursor = System.Windows.Forms.Cursors.IBeam;
            materialTextBoxSqlServer.Depth = 0;
            materialTextBoxSqlServer.HideSelection = true;
            materialTextBoxSqlServer.LeadingIcon = null;
            materialTextBoxSqlServer.MaxLength = 50;
            materialTextBoxSqlServer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxSqlServer.Name = "materialTextBoxSqlServer";
            materialTextBoxSqlServer.PasswordChar = '\0';
            materialTextBoxSqlServer.ReadOnly = false;
            materialTextBoxSqlServer.SelectedText = "";
            materialTextBoxSqlServer.SelectionLength = 0;
            materialTextBoxSqlServer.SelectionStart = 0;
            materialTextBoxSqlServer.ShortcutsEnabled = true;
            materialTextBoxSqlServer.TabStop = false;
            materialTextBoxSqlServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            materialTextBoxSqlServer.TrailingIcon = (System.Drawing.Image)resources.GetObject("materialTextBoxSqlServer.TrailingIcon");
            materialTextBoxSqlServer.UseSystemPasswordChar = false;
            // 
            // materialTextBoxDacpacPath
            // 
            resources.ApplyResources(materialTextBoxDacpacPath, "materialTextBoxDacpacPath");
            materialTextBoxDacpacPath.AnimateReadOnly = false;
            materialTextBoxDacpacPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            materialTextBoxDacpacPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            materialTextBoxDacpacPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            materialTextBoxDacpacPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            materialTextBoxDacpacPath.Depth = 0;
            materialTextBoxDacpacPath.HideSelection = true;
            materialTextBoxDacpacPath.LeadingIcon = null;
            materialTextBoxDacpacPath.MaxLength = 0;
            materialTextBoxDacpacPath.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxDacpacPath.Name = "materialTextBoxDacpacPath";
            materialTextBoxDacpacPath.PasswordChar = '\0';
            materialTextBoxDacpacPath.ReadOnly = false;
            materialTextBoxDacpacPath.SelectedText = "";
            materialTextBoxDacpacPath.SelectionLength = 0;
            materialTextBoxDacpacPath.SelectionStart = 0;
            materialTextBoxDacpacPath.ShortcutsEnabled = true;
            materialTextBoxDacpacPath.TabStop = false;
            materialTextBoxDacpacPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            materialTextBoxDacpacPath.TrailingIcon = (System.Drawing.Image)resources.GetObject("materialTextBoxDacpacPath.TrailingIcon");
            materialTextBoxDacpacPath.UseSystemPasswordChar = false;
            // 
            // materialTextBoxSqlPackagePath
            // 
            resources.ApplyResources(materialTextBoxSqlPackagePath, "materialTextBoxSqlPackagePath");
            materialTextBoxSqlPackagePath.AnimateReadOnly = false;
            materialTextBoxSqlPackagePath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            materialTextBoxSqlPackagePath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            materialTextBoxSqlPackagePath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            materialTextBoxSqlPackagePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            materialTextBoxSqlPackagePath.Depth = 0;
            materialTextBoxSqlPackagePath.HideSelection = true;
            materialTextBoxSqlPackagePath.LeadingIcon = null;
            materialTextBoxSqlPackagePath.MaxLength = 0;
            materialTextBoxSqlPackagePath.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxSqlPackagePath.Name = "materialTextBoxSqlPackagePath";
            materialTextBoxSqlPackagePath.PasswordChar = '\0';
            materialTextBoxSqlPackagePath.ReadOnly = false;
            materialTextBoxSqlPackagePath.SelectedText = "";
            materialTextBoxSqlPackagePath.SelectionLength = 0;
            materialTextBoxSqlPackagePath.SelectionStart = 0;
            materialTextBoxSqlPackagePath.ShortcutsEnabled = true;
            materialTextBoxSqlPackagePath.TabStop = false;
            materialTextBoxSqlPackagePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            materialTextBoxSqlPackagePath.TrailingIcon = (System.Drawing.Image)resources.GetObject("materialTextBoxSqlPackagePath.TrailingIcon");
            materialTextBoxSqlPackagePath.UseSystemPasswordChar = false;
            // 
            // materialButtonDeploy
            // 
            resources.ApplyResources(materialButtonDeploy, "materialButtonDeploy");
            materialButtonDeploy.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButtonDeploy.Depth = 0;
            materialButtonDeploy.HighEmphasis = true;
            materialButtonDeploy.Icon = (System.Drawing.Image)resources.GetObject("materialButtonDeploy.Icon");
            materialButtonDeploy.IconType = MaterialButton.MaterialIconType.Rebase;
            materialButtonDeploy.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButtonDeploy.Name = "materialButtonDeploy";
            materialButtonDeploy.NoAccentTextColor = System.Drawing.Color.Empty;
            materialButtonDeploy.Type = MaterialButton.MaterialButtonType.Contained;
            materialButtonDeploy.UseAccentColor = true;
            materialButtonDeploy.UseVisualStyleBackColor = true;
            materialButtonDeploy.Click += materialButtonDeploy_Click;
            // 
            // tabPageAbout
            // 
            resources.ApplyResources(tabPageAbout, "tabPageAbout");
            tabPageAbout.Controls.Add(webViewGitHubProfile);
            tabPageAbout.Name = "tabPageAbout";
            tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // webViewGitHubProfile
            // 
            resources.ApplyResources(webViewGitHubProfile, "webViewGitHubProfile");
            webViewGitHubProfile.AllowExternalDrop = false;
            webViewGitHubProfile.CreationProperties = null;
            webViewGitHubProfile.DefaultBackgroundColor = System.Drawing.Color.Transparent;
            webViewGitHubProfile.Name = "webViewGitHubProfile";
            webViewGitHubProfile.Source = new System.Uri("https://github.com/DevElkami", System.UriKind.Absolute);
            webViewGitHubProfile.ZoomFactor = 1D;
            // 
            // imageListTabCtrl
            // 
            imageListTabCtrl.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageListTabCtrl.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageListTabCtrl.ImageStream");
            imageListTabCtrl.TransparentColor = System.Drawing.Color.Transparent;
            imageListTabCtrl.Images.SetKeyName(0, "search-mini.png");
            imageListTabCtrl.Images.SetKeyName(1, "GitHub-Mark.png");
            imageListTabCtrl.Images.SetKeyName(2, "baseline_fingerprint_black_24dp.png");
            imageListTabCtrl.Images.SetKeyName(3, "diskette-mini.png");
            imageListTabCtrl.Images.SetKeyName(4, "round_add_black_24dp.png");
            imageListTabCtrl.Images.SetKeyName(5, "import.png");
            // 
            // MainForm
            // 
            AcceptButton = materialButtonDeploy;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonFace;
            Controls.Add(tabControlMain);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tabControlMain;
            Name = "MainForm";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += MainForm_Load;
            tabControlMain.ResumeLayout(false);
            tabPageDeploy.ResumeLayout(false);
            tabPageDeploy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWait).EndInit();
            materialExpansionPanelDeployerParam.ResumeLayout(false);
            materialExpansionPanelDeployerParam.PerformLayout();
            materialExpansionPanelSqlConnection.ResumeLayout(false);
            materialExpansionPanelSqlConnection.PerformLayout();
            tabPageAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webViewGitHubProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialTabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageDeploy;
        private System.Windows.Forms.ImageList imageListTabCtrl;
        private System.Windows.Forms.TabPage tabPageAbout;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewGitHubProfile;
        private MaterialTextBoxEdit materialTextBoxDacpacPath;
        private MaterialTextBoxEdit materialTextBoxSqlPackagePath;
        private MaterialButton materialButtonDeploy;
        private MaterialTextBoxEdit materialTextBoxDatabaseName;
        private MaterialTextBoxEdit materialTextBoxSqlServer;
        private MaterialSwitch materialSwitchSqlConnection;
        private MaterialExpansionPanel materialExpansionPanelSqlConnection;
        private MaterialTextBoxEdit materialTextBoxSqlPassword;
        private MaterialTextBoxEdit materialTextBoxSqlUser;
        private MaterialExpansionPanel materialExpansionPanelDeployerParam;
        private MaterialCheckBox materialCheckBoxBlockOnPossibleDataLoss;
        private MaterialCheckBox materialCheckBoxDropObjectsNotInSource;
        private System.Windows.Forms.PictureBox pictureBoxWait;
    }
}

