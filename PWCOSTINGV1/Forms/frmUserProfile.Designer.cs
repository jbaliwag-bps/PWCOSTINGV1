namespace PWCOSTINGV1.Forms
{
    partial class frmUserProfile
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
            this.mbtnSave = new MetroFramework.Controls.MetroButton();
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.mtxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtxtUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtxtFullName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.mtxtAccessLevel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.mtxtConfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mcboUserGroupCode = new MetroFramework.Controls.MetroComboBox();
            this.mcboSectionCode = new MetroFramework.Controls.MetroComboBox();
            this.mcbActive = new MetroFramework.Controls.MetroCheckBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.mbtnBrowse = new MetroFramework.Controls.MetroButton();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // mbtnSave
            // 
            this.mbtnSave.BackColor = System.Drawing.Color.Transparent;
            this.mbtnSave.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.saveicon1;
            this.mbtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnSave.Location = new System.Drawing.Point(724, 28);
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(40, 40);
            this.mbtnSave.TabIndex = 9;
            this.mbtnSave.Tag = "update";
            this.mbtnSave.Text = " ";
            this.metroToolTip1.SetToolTip(this.mbtnSave, "Save User Profile");
            this.mbtnSave.UseSelectable = true;
            this.mbtnSave.Click += new System.EventHandler(this.mbtnSave_Click);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.mbtnCancel.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.cancelicon;
            this.mbtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnCancel.Location = new System.Drawing.Point(770, 28);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(40, 40);
            this.mbtnCancel.TabIndex = 10;
            this.mbtnCancel.Tag = "cancel";
            this.mbtnCancel.Text = " ";
            this.metroToolTip1.SetToolTip(this.mbtnCancel, "Cancel");
            this.mbtnCancel.UseSelectable = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // mtxtPassword
            // 
            // 
            // 
            // 
            this.mtxtPassword.CustomButton.Image = null;
            this.mtxtPassword.CustomButton.Location = new System.Drawing.Point(342, 1);
            this.mtxtPassword.CustomButton.Name = "";
            this.mtxtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPassword.CustomButton.TabIndex = 1;
            this.mtxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPassword.CustomButton.UseSelectable = true;
            this.mtxtPassword.CustomButton.Visible = false;
            this.mtxtPassword.Lines = new string[0];
            this.mtxtPassword.Location = new System.Drawing.Point(196, 96);
            this.mtxtPassword.MaxLength = 10;
            this.mtxtPassword.Name = "mtxtPassword";
            this.mtxtPassword.PasswordChar = '*';
            this.mtxtPassword.PromptText = "Password";
            this.mtxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPassword.SelectedText = "";
            this.mtxtPassword.SelectionLength = 0;
            this.mtxtPassword.SelectionStart = 0;
            this.mtxtPassword.ShortcutsEnabled = true;
            this.mtxtPassword.Size = new System.Drawing.Size(364, 23);
            this.mtxtPassword.TabIndex = 1;
            this.mtxtPassword.UseSelectable = true;
            this.mtxtPassword.WaterMark = "Password";
            this.mtxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(43, 96);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Password";
            // 
            // mtxtUsername
            // 
            // 
            // 
            // 
            this.mtxtUsername.CustomButton.Image = null;
            this.mtxtUsername.CustomButton.Location = new System.Drawing.Point(342, 1);
            this.mtxtUsername.CustomButton.Name = "";
            this.mtxtUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUsername.CustomButton.TabIndex = 1;
            this.mtxtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUsername.CustomButton.UseSelectable = true;
            this.mtxtUsername.CustomButton.Visible = false;
            this.mtxtUsername.Lines = new string[0];
            this.mtxtUsername.Location = new System.Drawing.Point(196, 74);
            this.mtxtUsername.MaxLength = 50;
            this.mtxtUsername.Name = "mtxtUsername";
            this.mtxtUsername.PasswordChar = '\0';
            this.mtxtUsername.PromptText = "Username";
            this.mtxtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUsername.SelectedText = "";
            this.mtxtUsername.SelectionLength = 0;
            this.mtxtUsername.SelectionStart = 0;
            this.mtxtUsername.ShortcutsEnabled = true;
            this.mtxtUsername.Size = new System.Drawing.Size(364, 23);
            this.mtxtUsername.TabIndex = 0;
            this.mtxtUsername.UseSelectable = true;
            this.mtxtUsername.WaterMark = "Username";
            this.mtxtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(43, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Username";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(23, 166);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(126, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Basic Information";
            // 
            // mtxtFullName
            // 
            // 
            // 
            // 
            this.mtxtFullName.CustomButton.Image = null;
            this.mtxtFullName.CustomButton.Location = new System.Drawing.Point(342, 1);
            this.mtxtFullName.CustomButton.Name = "";
            this.mtxtFullName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtFullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtFullName.CustomButton.TabIndex = 1;
            this.mtxtFullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtFullName.CustomButton.UseSelectable = true;
            this.mtxtFullName.CustomButton.Visible = false;
            this.mtxtFullName.Lines = new string[0];
            this.mtxtFullName.Location = new System.Drawing.Point(196, 196);
            this.mtxtFullName.MaxLength = 50;
            this.mtxtFullName.Name = "mtxtFullName";
            this.mtxtFullName.PasswordChar = '\0';
            this.mtxtFullName.PromptText = "Full Name";
            this.mtxtFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtFullName.SelectedText = "";
            this.mtxtFullName.SelectionLength = 0;
            this.mtxtFullName.SelectionStart = 0;
            this.mtxtFullName.ShortcutsEnabled = true;
            this.mtxtFullName.Size = new System.Drawing.Size(364, 23);
            this.mtxtFullName.TabIndex = 4;
            this.mtxtFullName.UseSelectable = true;
            this.mtxtFullName.WaterMark = "Full Name";
            this.mtxtFullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(43, 196);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(69, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Full Name";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(43, 219);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(76, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "User Group";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(43, 245);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(51, 19);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Section";
            // 
            // mtxtAccessLevel
            // 
            // 
            // 
            // 
            this.mtxtAccessLevel.CustomButton.Image = null;
            this.mtxtAccessLevel.CustomButton.Location = new System.Drawing.Point(342, 1);
            this.mtxtAccessLevel.CustomButton.Name = "";
            this.mtxtAccessLevel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtAccessLevel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtAccessLevel.CustomButton.TabIndex = 1;
            this.mtxtAccessLevel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtAccessLevel.CustomButton.UseSelectable = true;
            this.mtxtAccessLevel.CustomButton.Visible = false;
            this.mtxtAccessLevel.Lines = new string[0];
            this.mtxtAccessLevel.Location = new System.Drawing.Point(196, 273);
            this.mtxtAccessLevel.MaxLength = 50;
            this.mtxtAccessLevel.Name = "mtxtAccessLevel";
            this.mtxtAccessLevel.PasswordChar = '\0';
            this.mtxtAccessLevel.PromptText = "Access Level";
            this.mtxtAccessLevel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtAccessLevel.SelectedText = "";
            this.mtxtAccessLevel.SelectionLength = 0;
            this.mtxtAccessLevel.SelectionStart = 0;
            this.mtxtAccessLevel.ShortcutsEnabled = true;
            this.mtxtAccessLevel.Size = new System.Drawing.Size(364, 23);
            this.mtxtAccessLevel.TabIndex = 7;
            this.mtxtAccessLevel.UseSelectable = true;
            this.mtxtAccessLevel.WaterMark = "Access Level";
            this.mtxtAccessLevel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtAccessLevel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(43, 273);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(80, 19);
            this.metroLabel9.TabIndex = 19;
            this.metroLabel9.Text = "Access Level";
            // 
            // mtxtConfirmPassword
            // 
            // 
            // 
            // 
            this.mtxtConfirmPassword.CustomButton.Image = null;
            this.mtxtConfirmPassword.CustomButton.Location = new System.Drawing.Point(342, 1);
            this.mtxtConfirmPassword.CustomButton.Name = "";
            this.mtxtConfirmPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtConfirmPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtConfirmPassword.CustomButton.TabIndex = 1;
            this.mtxtConfirmPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtConfirmPassword.CustomButton.UseSelectable = true;
            this.mtxtConfirmPassword.CustomButton.Visible = false;
            this.mtxtConfirmPassword.Lines = new string[0];
            this.mtxtConfirmPassword.Location = new System.Drawing.Point(196, 118);
            this.mtxtConfirmPassword.MaxLength = 10;
            this.mtxtConfirmPassword.Name = "mtxtConfirmPassword";
            this.mtxtConfirmPassword.PasswordChar = '*';
            this.mtxtConfirmPassword.PromptText = "Confirm Password";
            this.mtxtConfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtConfirmPassword.SelectedText = "";
            this.mtxtConfirmPassword.SelectionLength = 0;
            this.mtxtConfirmPassword.SelectionStart = 0;
            this.mtxtConfirmPassword.ShortcutsEnabled = true;
            this.mtxtConfirmPassword.Size = new System.Drawing.Size(364, 23);
            this.mtxtConfirmPassword.TabIndex = 2;
            this.mtxtConfirmPassword.UseSelectable = true;
            this.mtxtConfirmPassword.WaterMark = "Confirm Password";
            this.mtxtConfirmPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtConfirmPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(43, 118);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(116, 19);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "Confirm Password";
            // 
            // mcboUserGroupCode
            // 
            this.mcboUserGroupCode.FormattingEnabled = true;
            this.mcboUserGroupCode.ItemHeight = 23;
            this.mcboUserGroupCode.Location = new System.Drawing.Point(196, 218);
            this.mcboUserGroupCode.MaxLength = 50;
            this.mcboUserGroupCode.Name = "mcboUserGroupCode";
            this.mcboUserGroupCode.PromptText = "User Group";
            this.mcboUserGroupCode.Size = new System.Drawing.Size(363, 29);
            this.mcboUserGroupCode.TabIndex = 5;
            this.mcboUserGroupCode.UseSelectable = true;
            // 
            // mcboSectionCode
            // 
            this.mcboSectionCode.FormattingEnabled = true;
            this.mcboSectionCode.ItemHeight = 23;
            this.mcboSectionCode.Location = new System.Drawing.Point(196, 245);
            this.mcboSectionCode.MaxLength = 50;
            this.mcboSectionCode.Name = "mcboSectionCode";
            this.mcboSectionCode.PromptText = "Section";
            this.mcboSectionCode.Size = new System.Drawing.Size(363, 29);
            this.mcboSectionCode.TabIndex = 6;
            this.mcboSectionCode.UseSelectable = true;
            // 
            // mcbActive
            // 
            this.mcbActive.AutoSize = true;
            this.mcbActive.Location = new System.Drawing.Point(196, 144);
            this.mcbActive.Name = "mcbActive";
            this.mcbActive.Size = new System.Drawing.Size(56, 15);
            this.mcbActive.TabIndex = 3;
            this.mcbActive.Text = "Active";
            this.mcbActive.UseSelectable = true;
            this.mcbActive.CheckedChanged += new System.EventHandler(this.mcbActive_CheckedChanged);
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.Transparent;
            this.picUser.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.TPI_LOGO;
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUser.Image = global::PWCOSTINGV1.Properties.Resources.UserMetro;
            this.picUser.InitialImage = null;
            this.picUser.Location = new System.Drawing.Point(588, 74);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(222, 222);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 55;
            this.picUser.TabStop = false;
            // 
            // mbtnBrowse
            // 
            this.mbtnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.mbtnBrowse.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.editicon;
            this.mbtnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnBrowse.Location = new System.Drawing.Point(588, 74);
            this.mbtnBrowse.Name = "mbtnBrowse";
            this.mbtnBrowse.Size = new System.Drawing.Size(40, 38);
            this.mbtnBrowse.TabIndex = 8;
            this.mbtnBrowse.Text = " ";
            this.metroToolTip1.SetToolTip(this.mbtnBrowse, "Change Profile Picture");
            this.mbtnBrowse.UseSelectable = true;
            this.mbtnBrowse.Click += new System.EventHandler(this.mbtnBrowse_Click);
            // 
            // ofdImage
            // 
            this.ofdImage.DefaultExt = "jpg,.jpeg,.JPEG,.JPG,.PNG,.png,.img,.IMG,.bitmap,.BITMAP";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 321);
            this.Controls.Add(this.mbtnBrowse);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.mcbActive);
            this.Controls.Add(this.mcboSectionCode);
            this.Controls.Add(this.mcboUserGroupCode);
            this.Controls.Add(this.mtxtConfirmPassword);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mtxtAccessLevel);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.mtxtFullName);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtxtPassword);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtxtUsername);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mbtnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserProfile";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "User Profile";
            this.Load += new System.EventHandler(this.frmUserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mbtnSave;
        private MetroFramework.Controls.MetroButton mbtnCancel;
        private MetroFramework.Controls.MetroTextBox mtxtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtxtUsername;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mtxtFullName;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox mtxtAccessLevel;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox mtxtConfirmPassword;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox mcboUserGroupCode;
        private MetroFramework.Controls.MetroComboBox mcboSectionCode;
        private MetroFramework.Controls.MetroCheckBox mcbActive;
        private System.Windows.Forms.PictureBox picUser;
        private MetroFramework.Controls.MetroButton mbtnBrowse;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}