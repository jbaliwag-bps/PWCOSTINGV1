namespace PWCOSTINGV1.Forms
{
    partial class frmComponent
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
            this.mcbLocked = new MetroFramework.Controls.MetroCheckBox();
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.mtxtPartName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtxtPartNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.colRecID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsLocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mlblLastUpdate = new MetroFramework.Controls.MetroLabel();
            this.mTCConversion = new MetroFramework.Controls.MetroTabControl();
            this.mtpConversion = new MetroFramework.Controls.MetroTabPage();
            this.mtxtConversionUnit = new MetroFramework.Controls.MetroTextBox();
            this.mtxtConversionQty = new MetroFramework.Controls.MetroTextBox();
            this.mtxtConversionPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.mtxtWholeUnit = new MetroFramework.Controls.MetroTextBox();
            this.mtxtWholeQty = new MetroFramework.Controls.MetroTextBox();
            this.mtxtWholePrice = new MetroFramework.Controls.MetroTextBox();
            this.mtxtPreviousPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.mTCConversion.SuspendLayout();
            this.mtpConversion.SuspendLayout();
            this.SuspendLayout();
            // 
            // mbtnSave
            // 
            this.mbtnSave.Location = new System.Drawing.Point(225, 339);
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(75, 40);
            this.mbtnSave.TabIndex = 64;
            this.mbtnSave.Text = "&SAVE";
            this.mbtnSave.UseSelectable = true;
            this.mbtnSave.Click += new System.EventHandler(this.mbtnSave_Click);
            // 
            // mcbLocked
            // 
            this.mcbLocked.AutoSize = true;
            this.mcbLocked.Location = new System.Drawing.Point(446, 72);
            this.mcbLocked.Name = "mcbLocked";
            this.mcbLocked.Size = new System.Drawing.Size(76, 15);
            this.mcbLocked.TabIndex = 63;
            this.mcbLocked.Text = "UnLocked";
            this.mcbLocked.UseSelectable = true;
            this.mcbLocked.CheckedChanged += new System.EventHandler(this.mcbLocked_CheckedChanged);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.Location = new System.Drawing.Point(302, 339);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(75, 40);
            this.mbtnCancel.TabIndex = 65;
            this.mbtnCancel.Text = "C&ANCEL";
            this.mbtnCancel.UseSelectable = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(390, 70);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(50, 19);
            this.metroLabel10.TabIndex = 61;
            this.metroLabel10.Text = "Locked";
            // 
            // mtxtPartName
            // 
            this.mtxtPartName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtPartName.CustomButton.Image = null;
            this.mtxtPartName.CustomButton.Location = new System.Drawing.Point(460, 1);
            this.mtxtPartName.CustomButton.Name = "";
            this.mtxtPartName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPartName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPartName.CustomButton.TabIndex = 1;
            this.mtxtPartName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPartName.CustomButton.UseSelectable = true;
            this.mtxtPartName.CustomButton.Visible = false;
            this.mtxtPartName.Lines = new string[0];
            this.mtxtPartName.Location = new System.Drawing.Point(225, 92);
            this.mtxtPartName.MaxLength = 50;
            this.mtxtPartName.Name = "mtxtPartName";
            this.mtxtPartName.PasswordChar = '\0';
            this.mtxtPartName.PromptText = "Name";
            this.mtxtPartName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPartName.SelectedText = "";
            this.mtxtPartName.SelectionLength = 0;
            this.mtxtPartName.SelectionStart = 0;
            this.mtxtPartName.ShortcutsEnabled = true;
            this.mtxtPartName.Size = new System.Drawing.Size(482, 23);
            this.mtxtPartName.TabIndex = 60;
            this.mtxtPartName.UseSelectable = true;
            this.mtxtPartName.WaterMark = "Name";
            this.mtxtPartName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPartName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(58, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 59;
            this.metroLabel2.Text = "Part Name";
            // 
            // mtxtPartNo
            // 
            // 
            // 
            // 
            this.mtxtPartNo.CustomButton.Image = null;
            this.mtxtPartNo.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.mtxtPartNo.CustomButton.Name = "";
            this.mtxtPartNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPartNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPartNo.CustomButton.TabIndex = 1;
            this.mtxtPartNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPartNo.CustomButton.UseSelectable = true;
            this.mtxtPartNo.CustomButton.Visible = false;
            this.mtxtPartNo.Lines = new string[0];
            this.mtxtPartNo.Location = new System.Drawing.Point(225, 70);
            this.mtxtPartNo.MaxLength = 10;
            this.mtxtPartNo.Name = "mtxtPartNo";
            this.mtxtPartNo.PasswordChar = '\0';
            this.mtxtPartNo.PromptText = "No";
            this.mtxtPartNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPartNo.SelectedText = "";
            this.mtxtPartNo.SelectionLength = 0;
            this.mtxtPartNo.SelectionStart = 0;
            this.mtxtPartNo.ShortcutsEnabled = true;
            this.mtxtPartNo.Size = new System.Drawing.Size(155, 23);
            this.mtxtPartNo.TabIndex = 58;
            this.mtxtPartNo.UseSelectable = true;
            this.mtxtPartNo.WaterMark = "No";
            this.mtxtPartNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPartNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(58, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 57;
            this.metroLabel1.Text = "Part No.";
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
            // mlblLastUpdate
            // 
            this.mlblLastUpdate.AutoSize = true;
            this.mlblLastUpdate.Location = new System.Drawing.Point(225, 116);
            this.mlblLastUpdate.Name = "mlblLastUpdate";
            this.mlblLastUpdate.Size = new System.Drawing.Size(135, 19);
            this.mlblLastUpdate.TabIndex = 68;
            this.mlblLastUpdate.Text = "01/01/2000 12:00 AM";
            // 
            // mTCConversion
            // 
            this.mTCConversion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTCConversion.Controls.Add(this.mtpConversion);
            this.mTCConversion.Location = new System.Drawing.Point(23, 144);
            this.mTCConversion.Name = "mTCConversion";
            this.mTCConversion.SelectedIndex = 0;
            this.mTCConversion.Size = new System.Drawing.Size(688, 189);
            this.mTCConversion.TabIndex = 66;
            this.mTCConversion.UseSelectable = true;
            // 
            // mtpConversion
            // 
            this.mtpConversion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtpConversion.Controls.Add(this.mtxtConversionUnit);
            this.mtpConversion.Controls.Add(this.mtxtConversionQty);
            this.mtpConversion.Controls.Add(this.mtxtConversionPrice);
            this.mtpConversion.Controls.Add(this.metroLabel12);
            this.mtpConversion.Controls.Add(this.metroLabel8);
            this.mtpConversion.Controls.Add(this.metroLabel7);
            this.mtpConversion.Controls.Add(this.mtxtWholeUnit);
            this.mtpConversion.Controls.Add(this.mtxtWholeQty);
            this.mtpConversion.Controls.Add(this.mtxtWholePrice);
            this.mtpConversion.Controls.Add(this.mtxtPreviousPrice);
            this.mtpConversion.Controls.Add(this.metroLabel6);
            this.mtpConversion.Controls.Add(this.metroLabel5);
            this.mtpConversion.Controls.Add(this.metroLabel4);
            this.mtpConversion.Controls.Add(this.metroLabel3);
            this.mtpConversion.HorizontalScrollbarBarColor = true;
            this.mtpConversion.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpConversion.HorizontalScrollbarSize = 10;
            this.mtpConversion.Location = new System.Drawing.Point(4, 38);
            this.mtpConversion.Name = "mtpConversion";
            this.mtpConversion.Size = new System.Drawing.Size(680, 147);
            this.mtpConversion.TabIndex = 0;
            this.mtpConversion.Text = "Conversion";
            this.mtpConversion.VerticalScrollbarBarColor = true;
            this.mtpConversion.VerticalScrollbarHighlightOnWheel = false;
            this.mtpConversion.VerticalScrollbarSize = 10;
            // 
            // mtxtConversionUnit
            // 
            // 
            // 
            // 
            this.mtxtConversionUnit.CustomButton.Image = null;
            this.mtxtConversionUnit.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.mtxtConversionUnit.CustomButton.Name = "";
            this.mtxtConversionUnit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtConversionUnit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtConversionUnit.CustomButton.TabIndex = 1;
            this.mtxtConversionUnit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtConversionUnit.CustomButton.UseSelectable = true;
            this.mtxtConversionUnit.CustomButton.Visible = false;
            this.mtxtConversionUnit.Lines = new string[0];
            this.mtxtConversionUnit.Location = new System.Drawing.Point(497, 104);
            this.mtxtConversionUnit.MaxLength = 32767;
            this.mtxtConversionUnit.Name = "mtxtConversionUnit";
            this.mtxtConversionUnit.PasswordChar = '\0';
            this.mtxtConversionUnit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtConversionUnit.SelectedText = "";
            this.mtxtConversionUnit.SelectionLength = 0;
            this.mtxtConversionUnit.SelectionStart = 0;
            this.mtxtConversionUnit.ShortcutsEnabled = true;
            this.mtxtConversionUnit.Size = new System.Drawing.Size(156, 23);
            this.mtxtConversionUnit.TabIndex = 15;
            this.mtxtConversionUnit.UseSelectable = true;
            this.mtxtConversionUnit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtConversionUnit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtConversionQty
            // 
            // 
            // 
            // 
            this.mtxtConversionQty.CustomButton.Image = null;
            this.mtxtConversionQty.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.mtxtConversionQty.CustomButton.Name = "";
            this.mtxtConversionQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtConversionQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtConversionQty.CustomButton.TabIndex = 1;
            this.mtxtConversionQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtConversionQty.CustomButton.UseSelectable = true;
            this.mtxtConversionQty.CustomButton.Visible = false;
            this.mtxtConversionQty.Lines = new string[] {
        "0"};
            this.mtxtConversionQty.Location = new System.Drawing.Point(497, 82);
            this.mtxtConversionQty.MaxLength = 32767;
            this.mtxtConversionQty.Name = "mtxtConversionQty";
            this.mtxtConversionQty.PasswordChar = '\0';
            this.mtxtConversionQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtConversionQty.SelectedText = "";
            this.mtxtConversionQty.SelectionLength = 0;
            this.mtxtConversionQty.SelectionStart = 0;
            this.mtxtConversionQty.ShortcutsEnabled = true;
            this.mtxtConversionQty.Size = new System.Drawing.Size(156, 23);
            this.mtxtConversionQty.TabIndex = 14;
            this.mtxtConversionQty.Text = "0";
            this.mtxtConversionQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtConversionQty.UseSelectable = true;
            this.mtxtConversionQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtConversionQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtConversionQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtConversionQty_KeyPress);
            // 
            // mtxtConversionPrice
            // 
            // 
            // 
            // 
            this.mtxtConversionPrice.CustomButton.Image = null;
            this.mtxtConversionPrice.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.mtxtConversionPrice.CustomButton.Name = "";
            this.mtxtConversionPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtConversionPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtConversionPrice.CustomButton.TabIndex = 1;
            this.mtxtConversionPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtConversionPrice.CustomButton.UseSelectable = true;
            this.mtxtConversionPrice.CustomButton.Visible = false;
            this.mtxtConversionPrice.Lines = new string[] {
        "0"};
            this.mtxtConversionPrice.Location = new System.Drawing.Point(497, 48);
            this.mtxtConversionPrice.MaxLength = 32767;
            this.mtxtConversionPrice.Name = "mtxtConversionPrice";
            this.mtxtConversionPrice.PasswordChar = '\0';
            this.mtxtConversionPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtConversionPrice.SelectedText = "";
            this.mtxtConversionPrice.SelectionLength = 0;
            this.mtxtConversionPrice.SelectionStart = 0;
            this.mtxtConversionPrice.ShortcutsEnabled = true;
            this.mtxtConversionPrice.Size = new System.Drawing.Size(156, 23);
            this.mtxtConversionPrice.TabIndex = 13;
            this.mtxtConversionPrice.Text = "0";
            this.mtxtConversionPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtConversionPrice.UseSelectable = true;
            this.mtxtConversionPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtConversionPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtConversionPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtConversionPrice_KeyPress);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(357, 104);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(101, 19);
            this.metroLabel12.TabIndex = 12;
            this.metroLabel12.Text = "Conversion Unit";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(357, 82);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(99, 19);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "Conversion Qty";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(357, 48);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(107, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Conversion Price";
            // 
            // mtxtWholeUnit
            // 
            // 
            // 
            // 
            this.mtxtWholeUnit.CustomButton.Image = null;
            this.mtxtWholeUnit.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.mtxtWholeUnit.CustomButton.Name = "";
            this.mtxtWholeUnit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtWholeUnit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtWholeUnit.CustomButton.TabIndex = 1;
            this.mtxtWholeUnit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtWholeUnit.CustomButton.UseSelectable = true;
            this.mtxtWholeUnit.CustomButton.Visible = false;
            this.mtxtWholeUnit.Lines = new string[0];
            this.mtxtWholeUnit.Location = new System.Drawing.Point(157, 104);
            this.mtxtWholeUnit.MaxLength = 32767;
            this.mtxtWholeUnit.Name = "mtxtWholeUnit";
            this.mtxtWholeUnit.PasswordChar = '\0';
            this.mtxtWholeUnit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtWholeUnit.SelectedText = "";
            this.mtxtWholeUnit.SelectionLength = 0;
            this.mtxtWholeUnit.SelectionStart = 0;
            this.mtxtWholeUnit.ShortcutsEnabled = true;
            this.mtxtWholeUnit.Size = new System.Drawing.Size(156, 23);
            this.mtxtWholeUnit.TabIndex = 9;
            this.mtxtWholeUnit.UseSelectable = true;
            this.mtxtWholeUnit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtWholeUnit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtWholeQty
            // 
            // 
            // 
            // 
            this.mtxtWholeQty.CustomButton.Image = null;
            this.mtxtWholeQty.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.mtxtWholeQty.CustomButton.Name = "";
            this.mtxtWholeQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtWholeQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtWholeQty.CustomButton.TabIndex = 1;
            this.mtxtWholeQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtWholeQty.CustomButton.UseSelectable = true;
            this.mtxtWholeQty.CustomButton.Visible = false;
            this.mtxtWholeQty.Lines = new string[] {
        "0"};
            this.mtxtWholeQty.Location = new System.Drawing.Point(157, 82);
            this.mtxtWholeQty.MaxLength = 32767;
            this.mtxtWholeQty.Name = "mtxtWholeQty";
            this.mtxtWholeQty.PasswordChar = '\0';
            this.mtxtWholeQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtWholeQty.SelectedText = "";
            this.mtxtWholeQty.SelectionLength = 0;
            this.mtxtWholeQty.SelectionStart = 0;
            this.mtxtWholeQty.ShortcutsEnabled = true;
            this.mtxtWholeQty.Size = new System.Drawing.Size(156, 23);
            this.mtxtWholeQty.TabIndex = 8;
            this.mtxtWholeQty.Text = "0";
            this.mtxtWholeQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtWholeQty.UseSelectable = true;
            this.mtxtWholeQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtWholeQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtWholeQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtWholeQty_KeyPress);
            // 
            // mtxtWholePrice
            // 
            // 
            // 
            // 
            this.mtxtWholePrice.CustomButton.Image = null;
            this.mtxtWholePrice.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.mtxtWholePrice.CustomButton.Name = "";
            this.mtxtWholePrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtWholePrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtWholePrice.CustomButton.TabIndex = 1;
            this.mtxtWholePrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtWholePrice.CustomButton.UseSelectable = true;
            this.mtxtWholePrice.CustomButton.Visible = false;
            this.mtxtWholePrice.Lines = new string[] {
        "0"};
            this.mtxtWholePrice.Location = new System.Drawing.Point(157, 48);
            this.mtxtWholePrice.MaxLength = 32767;
            this.mtxtWholePrice.Name = "mtxtWholePrice";
            this.mtxtWholePrice.PasswordChar = '\0';
            this.mtxtWholePrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtWholePrice.SelectedText = "";
            this.mtxtWholePrice.SelectionLength = 0;
            this.mtxtWholePrice.SelectionStart = 0;
            this.mtxtWholePrice.ShortcutsEnabled = true;
            this.mtxtWholePrice.Size = new System.Drawing.Size(156, 23);
            this.mtxtWholePrice.TabIndex = 7;
            this.mtxtWholePrice.Text = "0";
            this.mtxtWholePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtWholePrice.UseSelectable = true;
            this.mtxtWholePrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtWholePrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtWholePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtWholePrice_KeyPress);
            // 
            // mtxtPreviousPrice
            // 
            // 
            // 
            // 
            this.mtxtPreviousPrice.CustomButton.Image = null;
            this.mtxtPreviousPrice.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.mtxtPreviousPrice.CustomButton.Name = "";
            this.mtxtPreviousPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPreviousPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPreviousPrice.CustomButton.TabIndex = 1;
            this.mtxtPreviousPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPreviousPrice.CustomButton.UseSelectable = true;
            this.mtxtPreviousPrice.CustomButton.Visible = false;
            this.mtxtPreviousPrice.Lines = new string[] {
        "0"};
            this.mtxtPreviousPrice.Location = new System.Drawing.Point(157, 26);
            this.mtxtPreviousPrice.MaxLength = 32767;
            this.mtxtPreviousPrice.Name = "mtxtPreviousPrice";
            this.mtxtPreviousPrice.PasswordChar = '\0';
            this.mtxtPreviousPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPreviousPrice.SelectedText = "";
            this.mtxtPreviousPrice.SelectionLength = 0;
            this.mtxtPreviousPrice.SelectionStart = 0;
            this.mtxtPreviousPrice.ShortcutsEnabled = true;
            this.mtxtPreviousPrice.Size = new System.Drawing.Size(156, 23);
            this.mtxtPreviousPrice.TabIndex = 6;
            this.mtxtPreviousPrice.Text = "0";
            this.mtxtPreviousPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtPreviousPrice.UseSelectable = true;
            this.mtxtPreviousPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPreviousPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtPreviousPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtPreviousPrice_KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(30, 104);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(74, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Whole Unit";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(30, 82);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(72, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Whole Qty";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(30, 48);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Whole Price";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(30, 26);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Previous Price";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(58, 116);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(93, 19);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Last Updated :";
            // 
            // frmComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 396);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.mlblLastUpdate);
            this.Controls.Add(this.mTCConversion);
            this.Controls.Add(this.mbtnSave);
            this.Controls.Add(this.mcbLocked);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.mtxtPartName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtxtPartNo);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmComponent";
            this.Resizable = false;
            this.Text = "Material";
            this.Load += new System.EventHandler(this.frmComponent_Load);
            this.mTCConversion.ResumeLayout(false);
            this.mtpConversion.ResumeLayout(false);
            this.mtpConversion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mbtnSave;
        private MetroFramework.Controls.MetroCheckBox mcbLocked;
        private MetroFramework.Controls.MetroButton mbtnCancel;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox mtxtPartName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtxtPartNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsLocked;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateCreated;
        private MetroFramework.Controls.MetroLabel mlblLastUpdate;
        private MetroFramework.Controls.MetroTabControl mTCConversion;
        private MetroFramework.Controls.MetroTabPage mtpConversion;
        private MetroFramework.Controls.MetroTextBox mtxtWholeUnit;
        private MetroFramework.Controls.MetroTextBox mtxtWholeQty;
        private MetroFramework.Controls.MetroTextBox mtxtWholePrice;
        private MetroFramework.Controls.MetroTextBox mtxtPreviousPrice;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mtxtConversionUnit;
        private MetroFramework.Controls.MetroTextBox mtxtConversionQty;
        private MetroFramework.Controls.MetroTextBox mtxtConversionPrice;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel9;
    }
}