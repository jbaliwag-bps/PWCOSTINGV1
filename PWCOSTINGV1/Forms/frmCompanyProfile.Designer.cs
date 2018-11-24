namespace PWCOSTINGV1.Forms
{
    partial class frmCompanyProfile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtxtShortName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtxtCompany = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mTCCompany = new MetroFramework.Controls.MetroTabControl();
            this.tpLCI = new System.Windows.Forms.TabPage();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mtxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.mtxtFaxNos = new MetroFramework.Controls.MetroTextBox();
            this.mtxtMobileNos = new MetroFramework.Controls.MetroTextBox();
            this.mtxtTelNos = new MetroFramework.Controls.MetroTextBox();
            this.mtxtAddress2 = new MetroFramework.Controls.MetroTextBox();
            this.mtxtAddress1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbYear = new System.Windows.Forms.TabPage();
            this.mlblNoRecords = new MetroFramework.Controls.MetroLabel();
            this.mgridYearList = new MetroFramework.Controls.MetroGrid();
            this.colRecID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsLocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.mbtnLock = new MetroFramework.Controls.MetroButton();
            this.mbtnRemove = new MetroFramework.Controls.MetroButton();
            this.mbtnAdd = new MetroFramework.Controls.MetroButton();
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.mbtnSave = new MetroFramework.Controls.MetroButton();
            this.mTCCompany.SuspendLayout();
            this.tpLCI.SuspendLayout();
            this.tbYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgridYearList)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxtShortName
            // 
            // 
            // 
            // 
            this.mtxtShortName.CustomButton.Image = null;
            this.mtxtShortName.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.mtxtShortName.CustomButton.Name = "";
            this.mtxtShortName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtShortName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtShortName.CustomButton.TabIndex = 1;
            this.mtxtShortName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtShortName.CustomButton.UseSelectable = true;
            this.mtxtShortName.CustomButton.Visible = false;
            this.mtxtShortName.Lines = new string[0];
            this.mtxtShortName.Location = new System.Drawing.Point(189, 107);
            this.mtxtShortName.MaxLength = 10;
            this.mtxtShortName.Name = "mtxtShortName";
            this.mtxtShortName.PasswordChar = '\0';
            this.mtxtShortName.PromptText = "Short Name";
            this.mtxtShortName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtShortName.SelectedText = "";
            this.mtxtShortName.SelectionLength = 0;
            this.mtxtShortName.SelectionStart = 0;
            this.mtxtShortName.ShortcutsEnabled = true;
            this.mtxtShortName.Size = new System.Drawing.Size(219, 23);
            this.mtxtShortName.TabIndex = 7;
            this.mtxtShortName.UseSelectable = true;
            this.mtxtShortName.WaterMark = "Short Name";
            this.mtxtShortName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtShortName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(54, 107);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Short Name";
            // 
            // mtxtCompany
            // 
            this.mtxtCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtCompany.CustomButton.Image = null;
            this.mtxtCompany.CustomButton.Location = new System.Drawing.Point(468, 1);
            this.mtxtCompany.CustomButton.Name = "";
            this.mtxtCompany.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtCompany.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtCompany.CustomButton.TabIndex = 1;
            this.mtxtCompany.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtCompany.CustomButton.UseSelectable = true;
            this.mtxtCompany.CustomButton.Visible = false;
            this.mtxtCompany.Lines = new string[0];
            this.mtxtCompany.Location = new System.Drawing.Point(189, 85);
            this.mtxtCompany.MaxLength = 50;
            this.mtxtCompany.Name = "mtxtCompany";
            this.mtxtCompany.PasswordChar = '\0';
            this.mtxtCompany.PromptText = "Company Name";
            this.mtxtCompany.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCompany.SelectedText = "";
            this.mtxtCompany.SelectionLength = 0;
            this.mtxtCompany.SelectionStart = 0;
            this.mtxtCompany.ShortcutsEnabled = true;
            this.mtxtCompany.Size = new System.Drawing.Size(490, 23);
            this.mtxtCompany.TabIndex = 5;
            this.mtxtCompany.UseSelectable = true;
            this.mtxtCompany.WaterMark = "Company Name";
            this.mtxtCompany.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtCompany.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(54, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Company Name";
            // 
            // mTCCompany
            // 
            this.mTCCompany.Controls.Add(this.tpLCI);
            this.mTCCompany.Controls.Add(this.tbYear);
            this.mTCCompany.Location = new System.Drawing.Point(23, 140);
            this.mTCCompany.Name = "mTCCompany";
            this.mTCCompany.SelectedIndex = 0;
            this.mTCCompany.Size = new System.Drawing.Size(687, 248);
            this.mTCCompany.TabIndex = 25;
            this.mTCCompany.UseSelectable = true;
            // 
            // tpLCI
            // 
            this.tpLCI.BackColor = System.Drawing.Color.Transparent;
            this.tpLCI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpLCI.Controls.Add(this.metroLabel8);
            this.tpLCI.Controls.Add(this.metroLabel7);
            this.tpLCI.Controls.Add(this.metroLabel6);
            this.tpLCI.Controls.Add(this.metroLabel5);
            this.tpLCI.Controls.Add(this.mtxtEmail);
            this.tpLCI.Controls.Add(this.mtxtFaxNos);
            this.tpLCI.Controls.Add(this.mtxtMobileNos);
            this.tpLCI.Controls.Add(this.mtxtTelNos);
            this.tpLCI.Controls.Add(this.mtxtAddress2);
            this.tpLCI.Controls.Add(this.mtxtAddress1);
            this.tpLCI.Controls.Add(this.metroLabel4);
            this.tpLCI.Controls.Add(this.metroLabel3);
            this.tpLCI.Location = new System.Drawing.Point(4, 38);
            this.tpLCI.Name = "tpLCI";
            this.tpLCI.Size = new System.Drawing.Size(679, 206);
            this.tpLCI.TabIndex = 0;
            this.tpLCI.Text = "Location and Contact Information";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(27, 161);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(98, 19);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "E-mail Address";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(27, 139);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(63, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "FAX Nos.";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(27, 117);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(80, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Mobile Nos.";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 95);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Telephone Nos.";
            // 
            // mtxtEmail
            // 
            // 
            // 
            // 
            this.mtxtEmail.CustomButton.Image = null;
            this.mtxtEmail.CustomButton.Location = new System.Drawing.Point(468, 1);
            this.mtxtEmail.CustomButton.Name = "";
            this.mtxtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtEmail.CustomButton.TabIndex = 1;
            this.mtxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtEmail.CustomButton.UseSelectable = true;
            this.mtxtEmail.CustomButton.Visible = false;
            this.mtxtEmail.Lines = new string[0];
            this.mtxtEmail.Location = new System.Drawing.Point(162, 161);
            this.mtxtEmail.MaxLength = 32767;
            this.mtxtEmail.Name = "mtxtEmail";
            this.mtxtEmail.PasswordChar = '\0';
            this.mtxtEmail.PromptText = "E-mail";
            this.mtxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtEmail.SelectedText = "";
            this.mtxtEmail.SelectionLength = 0;
            this.mtxtEmail.SelectionStart = 0;
            this.mtxtEmail.ShortcutsEnabled = true;
            this.mtxtEmail.Size = new System.Drawing.Size(490, 23);
            this.mtxtEmail.TabIndex = 7;
            this.mtxtEmail.UseSelectable = true;
            this.mtxtEmail.WaterMark = "E-mail";
            this.mtxtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtFaxNos
            // 
            // 
            // 
            // 
            this.mtxtFaxNos.CustomButton.Image = null;
            this.mtxtFaxNos.CustomButton.Location = new System.Drawing.Point(468, 1);
            this.mtxtFaxNos.CustomButton.Name = "";
            this.mtxtFaxNos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtFaxNos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtFaxNos.CustomButton.TabIndex = 1;
            this.mtxtFaxNos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtFaxNos.CustomButton.UseSelectable = true;
            this.mtxtFaxNos.CustomButton.Visible = false;
            this.mtxtFaxNos.Lines = new string[0];
            this.mtxtFaxNos.Location = new System.Drawing.Point(162, 139);
            this.mtxtFaxNos.MaxLength = 32767;
            this.mtxtFaxNos.Name = "mtxtFaxNos";
            this.mtxtFaxNos.PasswordChar = '\0';
            this.mtxtFaxNos.PromptText = "FAX Nos.";
            this.mtxtFaxNos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtFaxNos.SelectedText = "";
            this.mtxtFaxNos.SelectionLength = 0;
            this.mtxtFaxNos.SelectionStart = 0;
            this.mtxtFaxNos.ShortcutsEnabled = true;
            this.mtxtFaxNos.Size = new System.Drawing.Size(490, 23);
            this.mtxtFaxNos.TabIndex = 6;
            this.mtxtFaxNos.UseSelectable = true;
            this.mtxtFaxNos.WaterMark = "FAX Nos.";
            this.mtxtFaxNos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtFaxNos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtMobileNos
            // 
            // 
            // 
            // 
            this.mtxtMobileNos.CustomButton.Image = null;
            this.mtxtMobileNos.CustomButton.Location = new System.Drawing.Point(468, 1);
            this.mtxtMobileNos.CustomButton.Name = "";
            this.mtxtMobileNos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtMobileNos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtMobileNos.CustomButton.TabIndex = 1;
            this.mtxtMobileNos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtMobileNos.CustomButton.UseSelectable = true;
            this.mtxtMobileNos.CustomButton.Visible = false;
            this.mtxtMobileNos.Lines = new string[0];
            this.mtxtMobileNos.Location = new System.Drawing.Point(162, 117);
            this.mtxtMobileNos.MaxLength = 32767;
            this.mtxtMobileNos.Name = "mtxtMobileNos";
            this.mtxtMobileNos.PasswordChar = '\0';
            this.mtxtMobileNos.PromptText = "Mobile Nos.";
            this.mtxtMobileNos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtMobileNos.SelectedText = "";
            this.mtxtMobileNos.SelectionLength = 0;
            this.mtxtMobileNos.SelectionStart = 0;
            this.mtxtMobileNos.ShortcutsEnabled = true;
            this.mtxtMobileNos.Size = new System.Drawing.Size(490, 23);
            this.mtxtMobileNos.TabIndex = 5;
            this.mtxtMobileNos.UseSelectable = true;
            this.mtxtMobileNos.WaterMark = "Mobile Nos.";
            this.mtxtMobileNos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtMobileNos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtTelNos
            // 
            // 
            // 
            // 
            this.mtxtTelNos.CustomButton.Image = null;
            this.mtxtTelNos.CustomButton.Location = new System.Drawing.Point(468, 1);
            this.mtxtTelNos.CustomButton.Name = "";
            this.mtxtTelNos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtTelNos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtTelNos.CustomButton.TabIndex = 1;
            this.mtxtTelNos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtTelNos.CustomButton.UseSelectable = true;
            this.mtxtTelNos.CustomButton.Visible = false;
            this.mtxtTelNos.Lines = new string[0];
            this.mtxtTelNos.Location = new System.Drawing.Point(162, 95);
            this.mtxtTelNos.MaxLength = 32767;
            this.mtxtTelNos.Name = "mtxtTelNos";
            this.mtxtTelNos.PasswordChar = '\0';
            this.mtxtTelNos.PromptText = "Tel. Nos.";
            this.mtxtTelNos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtTelNos.SelectedText = "";
            this.mtxtTelNos.SelectionLength = 0;
            this.mtxtTelNos.SelectionStart = 0;
            this.mtxtTelNos.ShortcutsEnabled = true;
            this.mtxtTelNos.Size = new System.Drawing.Size(490, 23);
            this.mtxtTelNos.TabIndex = 4;
            this.mtxtTelNos.UseSelectable = true;
            this.mtxtTelNos.WaterMark = "Tel. Nos.";
            this.mtxtTelNos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtTelNos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtAddress2
            // 
            // 
            // 
            // 
            this.mtxtAddress2.CustomButton.Image = null;
            this.mtxtAddress2.CustomButton.Location = new System.Drawing.Point(452, 2);
            this.mtxtAddress2.CustomButton.Name = "";
            this.mtxtAddress2.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.mtxtAddress2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtAddress2.CustomButton.TabIndex = 1;
            this.mtxtAddress2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtAddress2.CustomButton.UseSelectable = true;
            this.mtxtAddress2.CustomButton.Visible = false;
            this.mtxtAddress2.Lines = new string[0];
            this.mtxtAddress2.Location = new System.Drawing.Point(162, 56);
            this.mtxtAddress2.MaxLength = 32767;
            this.mtxtAddress2.Multiline = true;
            this.mtxtAddress2.Name = "mtxtAddress2";
            this.mtxtAddress2.PasswordChar = '\0';
            this.mtxtAddress2.PromptText = "Address 2";
            this.mtxtAddress2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtAddress2.SelectedText = "";
            this.mtxtAddress2.SelectionLength = 0;
            this.mtxtAddress2.SelectionStart = 0;
            this.mtxtAddress2.ShortcutsEnabled = true;
            this.mtxtAddress2.Size = new System.Drawing.Size(490, 40);
            this.mtxtAddress2.TabIndex = 3;
            this.mtxtAddress2.UseSelectable = true;
            this.mtxtAddress2.WaterMark = "Address 2";
            this.mtxtAddress2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtAddress2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtAddress1
            // 
            // 
            // 
            // 
            this.mtxtAddress1.CustomButton.Image = null;
            this.mtxtAddress1.CustomButton.Location = new System.Drawing.Point(452, 2);
            this.mtxtAddress1.CustomButton.Name = "";
            this.mtxtAddress1.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.mtxtAddress1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtAddress1.CustomButton.TabIndex = 1;
            this.mtxtAddress1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtAddress1.CustomButton.UseSelectable = true;
            this.mtxtAddress1.CustomButton.Visible = false;
            this.mtxtAddress1.Lines = new string[0];
            this.mtxtAddress1.Location = new System.Drawing.Point(162, 17);
            this.mtxtAddress1.MaxLength = 32767;
            this.mtxtAddress1.Multiline = true;
            this.mtxtAddress1.Name = "mtxtAddress1";
            this.mtxtAddress1.PasswordChar = '\0';
            this.mtxtAddress1.PromptText = "Address 1";
            this.mtxtAddress1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtAddress1.SelectedText = "";
            this.mtxtAddress1.SelectionLength = 0;
            this.mtxtAddress1.SelectionStart = 0;
            this.mtxtAddress1.ShortcutsEnabled = true;
            this.mtxtAddress1.Size = new System.Drawing.Size(490, 40);
            this.mtxtAddress1.TabIndex = 2;
            this.mtxtAddress1.UseSelectable = true;
            this.mtxtAddress1.WaterMark = "Address 1";
            this.mtxtAddress1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtAddress1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(27, 56);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Address 2";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(27, 17);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Address 1";
            // 
            // tbYear
            // 
            this.tbYear.BackColor = System.Drawing.Color.Transparent;
            this.tbYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbYear.Controls.Add(this.mlblNoRecords);
            this.tbYear.Controls.Add(this.mgridYearList);
            this.tbYear.Controls.Add(this.mbtnLock);
            this.tbYear.Controls.Add(this.mbtnRemove);
            this.tbYear.Controls.Add(this.mbtnAdd);
            this.tbYear.Location = new System.Drawing.Point(4, 38);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(679, 206);
            this.tbYear.TabIndex = 1;
            this.tbYear.Text = "Year Setup";
            // 
            // mlblNoRecords
            // 
            this.mlblNoRecords.AutoSize = true;
            this.mlblNoRecords.Location = new System.Drawing.Point(128, 163);
            this.mlblNoRecords.Name = "mlblNoRecords";
            this.mlblNoRecords.Size = new System.Drawing.Size(81, 19);
            this.mlblNoRecords.TabIndex = 5;
            this.mlblNoRecords.Text = "No. Records";
            // 
            // mgridYearList
            // 
            this.mgridYearList.AllowUserToAddRows = false;
            this.mgridYearList.AllowUserToDeleteRows = false;
            this.mgridYearList.AllowUserToResizeRows = false;
            this.mgridYearList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridYearList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgridYearList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridYearList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.mgridYearList.ColumnHeadersHeight = 25;
            this.mgridYearList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mgridYearList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRecID,
            this.colYear,
            this.colIsLocked,
            this.colDateCreated});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgridYearList.DefaultCellStyle = dataGridViewCellStyle8;
            this.mgridYearList.EnableHeadersVisualStyles = false;
            this.mgridYearList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgridYearList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridYearList.Location = new System.Drawing.Point(5, 5);
            this.mgridYearList.Name = "mgridYearList";
            this.mgridYearList.ReadOnly = true;
            this.mgridYearList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridYearList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.mgridYearList.RowHeadersWidth = 25;
            this.mgridYearList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgridYearList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgridYearList.Size = new System.Drawing.Size(666, 152);
            this.mgridYearList.TabIndex = 0;
            // 
            // colRecID
            // 
            this.colRecID.DataPropertyName = "RecID";
            this.colRecID.HeaderText = "ID";
            this.colRecID.Name = "colRecID";
            this.colRecID.ReadOnly = true;
            this.colRecID.Visible = false;
            // 
            // colYear
            // 
            this.colYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colYear.DataPropertyName = "RecYear";
            this.colYear.HeaderText = "YEAR";
            this.colYear.MinimumWidth = 150;
            this.colYear.Name = "colYear";
            this.colYear.ReadOnly = true;
            // 
            // colIsLocked
            // 
            this.colIsLocked.DataPropertyName = "IsLocked";
            this.colIsLocked.HeaderText = "Locked";
            this.colIsLocked.MinimumWidth = 80;
            this.colIsLocked.Name = "colIsLocked";
            this.colIsLocked.ReadOnly = true;
            this.colIsLocked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsLocked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsLocked.Width = 80;
            // 
            // colDateCreated
            // 
            this.colDateCreated.DataPropertyName = "DateCreated";
            this.colDateCreated.HeaderText = "Date Created";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.ReadOnly = true;
            this.colDateCreated.Visible = false;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Default;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Default;
            // 
            // mbtnLock
            // 
            this.mbtnLock.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.lock_icon;
            this.mbtnLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnLock.Location = new System.Drawing.Point(87, 163);
            this.mbtnLock.Name = "mbtnLock";
            this.mbtnLock.Size = new System.Drawing.Size(35, 35);
            this.mbtnLock.TabIndex = 4;
            this.mbtnLock.Text = " ";
            this.metroToolTip1.SetToolTip(this.mbtnLock, "Lock a Year");
            this.mbtnLock.UseSelectable = true;
            this.mbtnLock.Click += new System.EventHandler(this.mbtnLock_Click);
            // 
            // mbtnRemove
            // 
            this.mbtnRemove.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.deleteicon;
            this.mbtnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnRemove.Location = new System.Drawing.Point(46, 163);
            this.mbtnRemove.Name = "mbtnRemove";
            this.mbtnRemove.Size = new System.Drawing.Size(35, 35);
            this.mbtnRemove.TabIndex = 2;
            this.mbtnRemove.Text = " ";
            this.metroToolTip1.SetToolTip(this.mbtnRemove, "Remove a Year");
            this.mbtnRemove.UseSelectable = true;
            this.mbtnRemove.Click += new System.EventHandler(this.mbtnRemove_Click);
            // 
            // mbtnAdd
            // 
            this.mbtnAdd.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.addicon;
            this.mbtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnAdd.Location = new System.Drawing.Point(5, 163);
            this.mbtnAdd.Name = "mbtnAdd";
            this.mbtnAdd.Size = new System.Drawing.Size(35, 35);
            this.mbtnAdd.TabIndex = 1;
            this.mbtnAdd.Text = " ";
            this.metroToolTip1.SetToolTip(this.mbtnAdd, "Add a Year");
            this.mbtnAdd.UseSelectable = true;
            this.mbtnAdd.Click += new System.EventHandler(this.mbtnAdd_Click);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.mbtnCancel.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.cancelicon;
            this.mbtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnCancel.Location = new System.Drawing.Point(670, 25);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(40, 40);
            this.mbtnCancel.TabIndex = 1;
            this.mbtnCancel.Text = " ";
            this.metroToolTip1.SetToolTip(this.mbtnCancel, "Cancel");
            this.mbtnCancel.UseSelectable = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // mbtnSave
            // 
            this.mbtnSave.BackColor = System.Drawing.Color.Transparent;
            this.mbtnSave.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.editicon;
            this.mbtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnSave.Location = new System.Drawing.Point(625, 25);
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(40, 40);
            this.mbtnSave.TabIndex = 0;
            this.mbtnSave.Text = " ";
            this.metroToolTip1.SetToolTip(this.mbtnSave, "Edit / Save");
            this.mbtnSave.UseSelectable = true;
            this.mbtnSave.Click += new System.EventHandler(this.mbtnSave_Click);
            // 
            // frmCompanyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(738, 412);
            this.Controls.Add(this.mTCCompany);
            this.Controls.Add(this.mtxtShortName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtxtCompany);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mbtnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompanyProfile";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Company Profile";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.frmCompanyProfile_Load);
            this.mTCCompany.ResumeLayout(false);
            this.tpLCI.ResumeLayout(false);
            this.tpLCI.PerformLayout();
            this.tbYear.ResumeLayout(false);
            this.tbYear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgridYearList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mbtnSave;
        private MetroFramework.Controls.MetroButton mbtnCancel;
        private MetroFramework.Controls.MetroTextBox mtxtShortName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtxtCompany;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl mTCCompany;
        private System.Windows.Forms.TabPage tbYear;
        private System.Windows.Forms.TabPage tpLCI;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox mtxtEmail;
        private MetroFramework.Controls.MetroTextBox mtxtFaxNos;
        private MetroFramework.Controls.MetroTextBox mtxtMobileNos;
        private MetroFramework.Controls.MetroTextBox mtxtTelNos;
        private MetroFramework.Controls.MetroTextBox mtxtAddress2;
        private MetroFramework.Controls.MetroTextBox mtxtAddress1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel mlblNoRecords;
        private MetroFramework.Controls.MetroButton mbtnLock;
        private MetroFramework.Controls.MetroButton mbtnRemove;
        private MetroFramework.Controls.MetroButton mbtnAdd;
        private MetroFramework.Controls.MetroGrid mgridYearList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsLocked;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateCreated;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}