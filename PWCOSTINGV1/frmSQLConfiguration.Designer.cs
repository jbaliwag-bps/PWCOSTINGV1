namespace PWCOSTINGV1
{
    partial class frmSQLConfiguration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSQLConfiguration));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tpConnectionSettings = new System.Windows.Forms.TabPage();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.mtxtDBName = new MetroFramework.Controls.MetroTextBox();
            this.mtxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.mtxtUserID = new MetroFramework.Controls.MetroTextBox();
            this.mtxtServerName = new MetroFramework.Controls.MetroTextBox();
            this.mrbSQLAccount = new MetroFramework.Controls.MetroRadioButton();
            this.mrbTrusted = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tpUpdateSource = new System.Windows.Forms.TabPage();
            this.mbtnBrowse = new MetroFramework.Controls.MetroButton();
            this.mtxtUpdateSource = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.fbdUpdateSource = new System.Windows.Forms.FolderBrowserDialog();
            this.mbtnTestConnection = new MetroFramework.Controls.MetroButton();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.tpConnectionSettings.SuspendLayout();
            this.tpUpdateSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.tpConnectionSettings);
            this.metroTabControl1.Controls.Add(this.tpUpdateSource);
            this.metroTabControl1.Location = new System.Drawing.Point(24, 62);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(432, 405);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tpConnectionSettings
            // 
            this.tpConnectionSettings.BackColor = System.Drawing.Color.Transparent;
            this.tpConnectionSettings.Controls.Add(this.metroLabel7);
            this.tpConnectionSettings.Controls.Add(this.mtxtDBName);
            this.tpConnectionSettings.Controls.Add(this.mtxtPassword);
            this.tpConnectionSettings.Controls.Add(this.mtxtUserID);
            this.tpConnectionSettings.Controls.Add(this.mtxtServerName);
            this.tpConnectionSettings.Controls.Add(this.mrbSQLAccount);
            this.tpConnectionSettings.Controls.Add(this.mrbTrusted);
            this.tpConnectionSettings.Controls.Add(this.metroLabel6);
            this.tpConnectionSettings.Controls.Add(this.metroLabel5);
            this.tpConnectionSettings.Controls.Add(this.mbtnTestConnection);
            this.tpConnectionSettings.Controls.Add(this.metroLabel4);
            this.tpConnectionSettings.Controls.Add(this.metroLabel3);
            this.tpConnectionSettings.Controls.Add(this.metroLabel2);
            this.tpConnectionSettings.Controls.Add(this.metroLabel1);
            this.tpConnectionSettings.Location = new System.Drawing.Point(4, 38);
            this.tpConnectionSettings.Name = "tpConnectionSettings";
            this.tpConnectionSettings.Size = new System.Drawing.Size(424, 363);
            this.tpConnectionSettings.TabIndex = 0;
            this.tpConnectionSettings.Text = "Connection Settings";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(19, 285);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(346, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "4. Please Click Text Connection to test the settings.";
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // mtxtDBName
            // 
            // 
            // 
            // 
            this.mtxtDBName.CustomButton.Image = null;
            this.mtxtDBName.CustomButton.Location = new System.Drawing.Point(314, 1);
            this.mtxtDBName.CustomButton.Name = "";
            this.mtxtDBName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtDBName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtDBName.CustomButton.TabIndex = 1;
            this.mtxtDBName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtDBName.CustomButton.UseSelectable = true;
            this.mtxtDBName.CustomButton.Visible = false;
            this.mtxtDBName.Lines = new string[0];
            this.mtxtDBName.Location = new System.Drawing.Point(49, 249);
            this.mtxtDBName.MaxLength = 32767;
            this.mtxtDBName.Name = "mtxtDBName";
            this.mtxtDBName.PasswordChar = '\0';
            this.mtxtDBName.PromptText = "Database Name";
            this.mtxtDBName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtDBName.SelectedText = "";
            this.mtxtDBName.SelectionLength = 0;
            this.mtxtDBName.SelectionStart = 0;
            this.mtxtDBName.ShortcutsEnabled = true;
            this.mtxtDBName.Size = new System.Drawing.Size(336, 23);
            this.mtxtDBName.TabIndex = 6;
            this.mtxtDBName.UseSelectable = true;
            this.mtxtDBName.WaterMark = "Database Name";
            this.mtxtDBName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtDBName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtPassword
            // 
            // 
            // 
            // 
            this.mtxtPassword.CustomButton.Image = null;
            this.mtxtPassword.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.mtxtPassword.CustomButton.Name = "";
            this.mtxtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPassword.CustomButton.TabIndex = 1;
            this.mtxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPassword.CustomButton.UseSelectable = true;
            this.mtxtPassword.CustomButton.Visible = false;
            this.mtxtPassword.Lines = new string[0];
            this.mtxtPassword.Location = new System.Drawing.Point(167, 187);
            this.mtxtPassword.MaxLength = 32767;
            this.mtxtPassword.Name = "mtxtPassword";
            this.mtxtPassword.PasswordChar = '*';
            this.mtxtPassword.PromptText = "Password";
            this.mtxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPassword.SelectedText = "";
            this.mtxtPassword.SelectionLength = 0;
            this.mtxtPassword.SelectionStart = 0;
            this.mtxtPassword.ShortcutsEnabled = true;
            this.mtxtPassword.Size = new System.Drawing.Size(218, 23);
            this.mtxtPassword.TabIndex = 5;
            this.mtxtPassword.UseSelectable = true;
            this.mtxtPassword.WaterMark = "Password";
            this.mtxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtUserID
            // 
            // 
            // 
            // 
            this.mtxtUserID.CustomButton.Image = null;
            this.mtxtUserID.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.mtxtUserID.CustomButton.Name = "";
            this.mtxtUserID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtUserID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUserID.CustomButton.TabIndex = 1;
            this.mtxtUserID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUserID.CustomButton.UseSelectable = true;
            this.mtxtUserID.CustomButton.Visible = false;
            this.mtxtUserID.Lines = new string[0];
            this.mtxtUserID.Location = new System.Drawing.Point(167, 162);
            this.mtxtUserID.MaxLength = 32767;
            this.mtxtUserID.Name = "mtxtUserID";
            this.mtxtUserID.PasswordChar = '\0';
            this.mtxtUserID.PromptText = "Username";
            this.mtxtUserID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUserID.SelectedText = "";
            this.mtxtUserID.SelectionLength = 0;
            this.mtxtUserID.SelectionStart = 0;
            this.mtxtUserID.ShortcutsEnabled = true;
            this.mtxtUserID.Size = new System.Drawing.Size(218, 23);
            this.mtxtUserID.TabIndex = 4;
            this.mtxtUserID.UseSelectable = true;
            this.mtxtUserID.WaterMark = "Username";
            this.mtxtUserID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUserID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtServerName
            // 
            // 
            // 
            // 
            this.mtxtServerName.CustomButton.Image = null;
            this.mtxtServerName.CustomButton.Location = new System.Drawing.Point(314, 1);
            this.mtxtServerName.CustomButton.Name = "";
            this.mtxtServerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtServerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtServerName.CustomButton.TabIndex = 1;
            this.mtxtServerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtServerName.CustomButton.UseSelectable = true;
            this.mtxtServerName.CustomButton.Visible = false;
            this.mtxtServerName.Lines = new string[0];
            this.mtxtServerName.Location = new System.Drawing.Point(49, 68);
            this.mtxtServerName.MaxLength = 32767;
            this.mtxtServerName.Name = "mtxtServerName";
            this.mtxtServerName.PasswordChar = '\0';
            this.mtxtServerName.PromptText = "Server Instance Name";
            this.mtxtServerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtServerName.SelectedText = "";
            this.mtxtServerName.SelectionLength = 0;
            this.mtxtServerName.SelectionStart = 0;
            this.mtxtServerName.ShortcutsEnabled = true;
            this.mtxtServerName.Size = new System.Drawing.Size(336, 23);
            this.mtxtServerName.TabIndex = 1;
            this.mtxtServerName.UseSelectable = true;
            this.mtxtServerName.WaterMark = "Server Instance Name";
            this.mtxtServerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtServerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mrbSQLAccount
            // 
            this.mrbSQLAccount.AutoSize = true;
            this.mrbSQLAccount.BackColor = System.Drawing.Color.Transparent;
            this.mrbSQLAccount.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.mrbSQLAccount.Location = new System.Drawing.Point(49, 144);
            this.mrbSQLAccount.Name = "mrbSQLAccount";
            this.mrbSQLAccount.Size = new System.Drawing.Size(234, 15);
            this.mrbSQLAccount.TabIndex = 3;
            this.mrbSQLAccount.Text = "User SQL Account Authentication (sa).";
            this.mrbSQLAccount.UseCustomBackColor = true;
            this.mrbSQLAccount.UseSelectable = true;
            // 
            // mrbTrusted
            // 
            this.mrbTrusted.AutoSize = true;
            this.mrbTrusted.BackColor = System.Drawing.Color.Transparent;
            this.mrbTrusted.Checked = true;
            this.mrbTrusted.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.mrbTrusted.Location = new System.Drawing.Point(49, 126);
            this.mrbTrusted.Name = "mrbTrusted";
            this.mrbTrusted.Size = new System.Drawing.Size(206, 15);
            this.mrbTrusted.TabIndex = 2;
            this.mrbTrusted.TabStop = true;
            this.mrbTrusted.Text = "Use Windows Authentication NT.";
            this.mrbTrusted.UseCustomBackColor = true;
            this.mrbTrusted.UseSelectable = true;
            this.mrbTrusted.CheckedChanged += new System.EventHandler(this.mrbTrusted_CheckedChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.Location = new System.Drawing.Point(93, 189);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(64, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Password";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.Location = new System.Drawing.Point(93, 165);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Username";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(19, 221);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(397, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "3. Please enter the Database Name use by the application.";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(19, 99);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(291, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "2. Please select an Authentication Method.";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(19, 41);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(290, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "1. Please enter the Server Instance Name. ";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(9, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(296, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Please fill-in necessary connection settings.";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // tpUpdateSource
            // 
            this.tpUpdateSource.BackColor = System.Drawing.Color.Transparent;
            this.tpUpdateSource.Controls.Add(this.mbtnBrowse);
            this.tpUpdateSource.Controls.Add(this.mtxtUpdateSource);
            this.tpUpdateSource.Controls.Add(this.metroLabel8);
            this.tpUpdateSource.Location = new System.Drawing.Point(4, 38);
            this.tpUpdateSource.Name = "tpUpdateSource";
            this.tpUpdateSource.Size = new System.Drawing.Size(424, 363);
            this.tpUpdateSource.TabIndex = 1;
            this.tpUpdateSource.Text = "Update Source";
            // 
            // mbtnBrowse
            // 
            this.mbtnBrowse.Location = new System.Drawing.Point(14, 309);
            this.mbtnBrowse.Name = "mbtnBrowse";
            this.mbtnBrowse.Size = new System.Drawing.Size(79, 40);
            this.mbtnBrowse.TabIndex = 2;
            this.mbtnBrowse.Text = "&Browse";
            this.mbtnBrowse.UseSelectable = true;
            this.mbtnBrowse.Click += new System.EventHandler(this.mbtnBrowse_Click);
            // 
            // mtxtUpdateSource
            // 
            // 
            // 
            // 
            this.mtxtUpdateSource.CustomButton.Image = null;
            this.mtxtUpdateSource.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.mtxtUpdateSource.CustomButton.Name = "";
            this.mtxtUpdateSource.CustomButton.Size = new System.Drawing.Size(247, 247);
            this.mtxtUpdateSource.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUpdateSource.CustomButton.TabIndex = 1;
            this.mtxtUpdateSource.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUpdateSource.CustomButton.UseSelectable = true;
            this.mtxtUpdateSource.CustomButton.Visible = false;
            this.mtxtUpdateSource.Lines = new string[0];
            this.mtxtUpdateSource.Location = new System.Drawing.Point(14, 53);
            this.mtxtUpdateSource.MaxLength = 32767;
            this.mtxtUpdateSource.Multiline = true;
            this.mtxtUpdateSource.Name = "mtxtUpdateSource";
            this.mtxtUpdateSource.PasswordChar = '\0';
            this.mtxtUpdateSource.PromptText = "Update Source Path";
            this.mtxtUpdateSource.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUpdateSource.SelectedText = "";
            this.mtxtUpdateSource.SelectionLength = 0;
            this.mtxtUpdateSource.SelectionStart = 0;
            this.mtxtUpdateSource.ShortcutsEnabled = true;
            this.mtxtUpdateSource.Size = new System.Drawing.Size(398, 249);
            this.mtxtUpdateSource.TabIndex = 1;
            this.mtxtUpdateSource.UseSelectable = true;
            this.mtxtUpdateSource.WaterMark = "Update Source Path";
            this.mtxtUpdateSource.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUpdateSource.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(14, 7);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(398, 43);
            this.metroLabel8.TabIndex = 0;
            this.metroLabel8.Text = "Please enter a valid Update Source path. You may use the Browse button to make su" +
    "re the path is correct.";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.WrapToLine = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.saveicon1;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton1.Location = new System.Drawing.Point(366, 475);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(40, 40);
            this.metroButton1.TabIndex = 1;
            this.metroToolTip1.SetToolTip(this.metroButton1, "Save SQL Configuration");
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // mbtnTestConnection
            // 
            this.mbtnTestConnection.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.Connection_icon;
            this.mbtnTestConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnTestConnection.Location = new System.Drawing.Point(49, 310);
            this.mbtnTestConnection.Name = "mbtnTestConnection";
            this.mbtnTestConnection.Size = new System.Drawing.Size(40, 40);
            this.mbtnTestConnection.TabIndex = 7;
            this.metroToolTip1.SetToolTip(this.mbtnTestConnection, "Test Connectivity");
            this.mbtnTestConnection.UseSelectable = true;
            this.mbtnTestConnection.Click += new System.EventHandler(this.mbtnTestConnection_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Default;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Default;
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.cancelicon;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton2.Location = new System.Drawing.Point(412, 475);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(40, 40);
            this.metroButton2.TabIndex = 2;
            this.metroToolTip1.SetToolTip(this.metroButton2, "Cancel");
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // frmSQLConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 530);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSQLConfiguration";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "SQL Configuration";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSQLConfiguration_FormClosing);
            this.Load += new System.EventHandler(this.frmSQLConfiguration_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tpConnectionSettings.ResumeLayout(false);
            this.tpConnectionSettings.PerformLayout();
            this.tpUpdateSource.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tpConnectionSettings;
        private System.Windows.Forms.TabPage tpUpdateSource;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton mbtnTestConnection;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroRadioButton mrbSQLAccount;
        private MetroFramework.Controls.MetroRadioButton mrbTrusted;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox mtxtDBName;
        private MetroFramework.Controls.MetroTextBox mtxtPassword;
        private MetroFramework.Controls.MetroTextBox mtxtUserID;
        private MetroFramework.Controls.MetroTextBox mtxtServerName;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox mtxtUpdateSource;
        private MetroFramework.Controls.MetroButton mbtnBrowse;
        private System.Windows.Forms.FolderBrowserDialog fbdUpdateSource;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}