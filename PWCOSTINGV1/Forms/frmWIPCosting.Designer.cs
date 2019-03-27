namespace PWCOSTINGV1.Forms
{
    partial class frmWIPCosting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mcboCatCode = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mtxtPartCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtxtItemNo = new MetroFramework.Controls.MetroTextBox();
            this.mlblItemNo = new MetroFramework.Controls.MetroLabel();
            this.mtcWIP = new MetroFramework.Controls.MetroTabControl();
            this.mtpMaterials = new MetroFramework.Controls.MetroTabPage();
            this.mgridMatList = new MetroFramework.Controls.MetroGrid();
            this.colDocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtpLabor = new MetroFramework.Controls.MetroTabPage();
            this.mtpOthers = new MetroFramework.Controls.MetroTabPage();
            this.mtxtRemarks = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mtxtSubTotal = new MetroFramework.Controls.MetroTextBox();
            this.mtxtProfitRate = new MetroFramework.Controls.MetroTextBox();
            this.mtxtSellingPrice = new MetroFramework.Controls.MetroTextBox();
            this.mtxtForex = new MetroFramework.Controls.MetroTextBox();
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.mbtnSave = new MetroFramework.Controls.MetroButton();
            this.mbtnSearch = new MetroFramework.Controls.MetroButton();
            this.mtxtPartName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.mtcWIP.SuspendLayout();
            this.mtpMaterials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgridMatList)).BeginInit();
            this.mtpOthers.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcboCatCode
            // 
            this.mcboCatCode.Enabled = false;
            this.mcboCatCode.FormattingEnabled = true;
            this.mcboCatCode.ItemHeight = 23;
            this.mcboCatCode.Location = new System.Drawing.Point(173, 163);
            this.mcboCatCode.Name = "mcboCatCode";
            this.mcboCatCode.PromptText = "Code";
            this.mcboCatCode.Size = new System.Drawing.Size(262, 29);
            this.mcboCatCode.TabIndex = 77;
            this.mcboCatCode.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(47, 173);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 19);
            this.metroLabel5.TabIndex = 76;
            this.metroLabel5.Text = "Category";
            // 
            // mtxtPartCode
            // 
            // 
            // 
            // 
            this.mtxtPartCode.CustomButton.Image = null;
            this.mtxtPartCode.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.mtxtPartCode.CustomButton.Name = "";
            this.mtxtPartCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPartCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPartCode.CustomButton.TabIndex = 1;
            this.mtxtPartCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPartCode.CustomButton.UseSelectable = true;
            this.mtxtPartCode.CustomButton.Visible = false;
            this.mtxtPartCode.Lines = new string[0];
            this.mtxtPartCode.Location = new System.Drawing.Point(173, 90);
            this.mtxtPartCode.MaxLength = 50;
            this.mtxtPartCode.Name = "mtxtPartCode";
            this.mtxtPartCode.PasswordChar = '\0';
            this.mtxtPartCode.PromptText = "Part Code";
            this.mtxtPartCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPartCode.SelectedText = "";
            this.mtxtPartCode.SelectionLength = 0;
            this.mtxtPartCode.SelectionStart = 0;
            this.mtxtPartCode.ShortcutsEnabled = true;
            this.mtxtPartCode.Size = new System.Drawing.Size(184, 23);
            this.mtxtPartCode.TabIndex = 75;
            this.mtxtPartCode.UseSelectable = true;
            this.mtxtPartCode.WaterMark = "Part Code";
            this.mtxtPartCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPartCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(47, 90);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 74;
            this.metroLabel3.Text = "Code";
            // 
            // mtxtItemNo
            // 
            // 
            // 
            // 
            this.mtxtItemNo.CustomButton.Image = null;
            this.mtxtItemNo.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.mtxtItemNo.CustomButton.Name = "";
            this.mtxtItemNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtItemNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtItemNo.CustomButton.TabIndex = 1;
            this.mtxtItemNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtItemNo.CustomButton.UseSelectable = true;
            this.mtxtItemNo.CustomButton.Visible = false;
            this.mtxtItemNo.Lines = new string[0];
            this.mtxtItemNo.Location = new System.Drawing.Point(173, 66);
            this.mtxtItemNo.MaxLength = 25;
            this.mtxtItemNo.Name = "mtxtItemNo";
            this.mtxtItemNo.PasswordChar = '\0';
            this.mtxtItemNo.PromptText = "Item No.";
            this.mtxtItemNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtItemNo.SelectedText = "";
            this.mtxtItemNo.SelectionLength = 0;
            this.mtxtItemNo.SelectionStart = 0;
            this.mtxtItemNo.ShortcutsEnabled = true;
            this.mtxtItemNo.Size = new System.Drawing.Size(184, 23);
            this.mtxtItemNo.TabIndex = 73;
            this.mtxtItemNo.UseSelectable = true;
            this.mtxtItemNo.WaterMark = "Item No.";
            this.mtxtItemNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtItemNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblItemNo
            // 
            this.mlblItemNo.AutoSize = true;
            this.mlblItemNo.Location = new System.Drawing.Point(47, 66);
            this.mlblItemNo.Name = "mlblItemNo";
            this.mlblItemNo.Size = new System.Drawing.Size(30, 19);
            this.mlblItemNo.TabIndex = 72;
            this.mlblItemNo.Text = "No.";
            // 
            // mtcWIP
            // 
            this.mtcWIP.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.mtcWIP.Controls.Add(this.mtpMaterials);
            this.mtcWIP.Controls.Add(this.mtpLabor);
            this.mtcWIP.Controls.Add(this.mtpOthers);
            this.mtcWIP.Location = new System.Drawing.Point(19, 202);
            this.mtcWIP.Multiline = true;
            this.mtcWIP.Name = "mtcWIP";
            this.mtcWIP.SelectedIndex = 0;
            this.mtcWIP.Size = new System.Drawing.Size(1171, 323);
            this.mtcWIP.TabIndex = 78;
            this.mtcWIP.UseSelectable = true;
            // 
            // mtpMaterials
            // 
            this.mtpMaterials.Controls.Add(this.mgridMatList);
            this.mtpMaterials.HorizontalScrollbarBarColor = true;
            this.mtpMaterials.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpMaterials.HorizontalScrollbarSize = 10;
            this.mtpMaterials.Location = new System.Drawing.Point(4, 41);
            this.mtpMaterials.Name = "mtpMaterials";
            this.mtpMaterials.Size = new System.Drawing.Size(1163, 278);
            this.mtpMaterials.TabIndex = 0;
            this.mtpMaterials.Text = "    Materials    ";
            this.mtpMaterials.VerticalScrollbarBarColor = true;
            this.mtpMaterials.VerticalScrollbarHighlightOnWheel = false;
            this.mtpMaterials.VerticalScrollbarSize = 10;
            // 
            // mgridMatList
            // 
            this.mgridMatList.AllowUserToAddRows = false;
            this.mgridMatList.AllowUserToDeleteRows = false;
            this.mgridMatList.AllowUserToResizeRows = false;
            this.mgridMatList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridMatList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgridMatList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgridMatList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridMatList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.mgridMatList.ColumnHeadersHeight = 25;
            this.mgridMatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mgridMatList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDocID,
            this.colPartNo,
            this.colMatDescription,
            this.colUsage,
            this.colUnitType,
            this.colUnitPrice,
            this.colAmount,
            this.colAddress});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgridMatList.DefaultCellStyle = dataGridViewCellStyle11;
            this.mgridMatList.EnableHeadersVisualStyles = false;
            this.mgridMatList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgridMatList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridMatList.Location = new System.Drawing.Point(-4, 0);
            this.mgridMatList.Name = "mgridMatList";
            this.mgridMatList.ReadOnly = true;
            this.mgridMatList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridMatList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.mgridMatList.RowHeadersWidth = 25;
            this.mgridMatList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgridMatList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgridMatList.Size = new System.Drawing.Size(1164, 301);
            this.mgridMatList.TabIndex = 10;
            this.mgridMatList.Tag = "";
            // 
            // colDocID
            // 
            this.colDocID.DataPropertyName = "RecID";
            this.colDocID.HeaderText = "DocID";
            this.colDocID.Name = "colDocID";
            this.colDocID.ReadOnly = true;
            this.colDocID.Visible = false;
            // 
            // colPartNo
            // 
            this.colPartNo.DataPropertyName = "MatCode";
            this.colPartNo.HeaderText = "Code";
            this.colPartNo.MinimumWidth = 100;
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.ReadOnly = true;
            this.colPartNo.Width = 150;
            // 
            // colMatDescription
            // 
            this.colMatDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMatDescription.DataPropertyName = "MatDescription";
            this.colMatDescription.HeaderText = "Description";
            this.colMatDescription.MinimumWidth = 150;
            this.colMatDescription.Name = "colMatDescription";
            this.colMatDescription.ReadOnly = true;
            // 
            // colUsage
            // 
            this.colUsage.DataPropertyName = "ItemUsage";
            this.colUsage.HeaderText = "Usage";
            this.colUsage.Name = "colUsage";
            this.colUsage.ReadOnly = true;
            // 
            // colUnitType
            // 
            this.colUnitType.DataPropertyName = "UnitType";
            this.colUnitType.HeaderText = "Type";
            this.colUnitType.Name = "colUnitType";
            this.colUnitType.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "Total";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "ref_Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Visible = false;
            // 
            // mtpLabor
            // 
            this.mtpLabor.HorizontalScrollbarBarColor = true;
            this.mtpLabor.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpLabor.HorizontalScrollbarSize = 10;
            this.mtpLabor.Location = new System.Drawing.Point(4, 41);
            this.mtpLabor.Name = "mtpLabor";
            this.mtpLabor.Size = new System.Drawing.Size(1163, 301);
            this.mtpLabor.TabIndex = 1;
            this.mtpLabor.Text = "    Labor    ";
            this.mtpLabor.VerticalScrollbarBarColor = true;
            this.mtpLabor.VerticalScrollbarHighlightOnWheel = false;
            this.mtpLabor.VerticalScrollbarSize = 10;
            // 
            // mtpOthers
            // 
            this.mtpOthers.Controls.Add(this.mtxtRemarks);
            this.mtpOthers.Controls.Add(this.metroLabel7);
            this.mtpOthers.HorizontalScrollbarBarColor = true;
            this.mtpOthers.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpOthers.HorizontalScrollbarSize = 10;
            this.mtpOthers.Location = new System.Drawing.Point(4, 41);
            this.mtpOthers.Name = "mtpOthers";
            this.mtpOthers.Size = new System.Drawing.Size(1163, 301);
            this.mtpOthers.TabIndex = 2;
            this.mtpOthers.Text = "Others";
            this.mtpOthers.VerticalScrollbarBarColor = true;
            this.mtpOthers.VerticalScrollbarHighlightOnWheel = false;
            this.mtpOthers.VerticalScrollbarSize = 10;
            // 
            // mtxtRemarks
            // 
            // 
            // 
            // 
            this.mtxtRemarks.CustomButton.Image = null;
            this.mtxtRemarks.CustomButton.Location = new System.Drawing.Point(575, 2);
            this.mtxtRemarks.CustomButton.Name = "";
            this.mtxtRemarks.CustomButton.Size = new System.Drawing.Size(199, 199);
            this.mtxtRemarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtRemarks.CustomButton.TabIndex = 1;
            this.mtxtRemarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtRemarks.CustomButton.UseSelectable = true;
            this.mtxtRemarks.CustomButton.Visible = false;
            this.mtxtRemarks.Lines = new string[0];
            this.mtxtRemarks.Location = new System.Drawing.Point(131, 9);
            this.mtxtRemarks.MaxLength = 32767;
            this.mtxtRemarks.Multiline = true;
            this.mtxtRemarks.Name = "mtxtRemarks";
            this.mtxtRemarks.PasswordChar = '\0';
            this.mtxtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtRemarks.SelectedText = "";
            this.mtxtRemarks.SelectionLength = 0;
            this.mtxtRemarks.SelectionStart = 0;
            this.mtxtRemarks.ShortcutsEnabled = true;
            this.mtxtRemarks.Size = new System.Drawing.Size(777, 204);
            this.mtxtRemarks.TabIndex = 73;
            this.mtxtRemarks.UseSelectable = true;
            this.mtxtRemarks.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtRemarks.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(5, 10);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(66, 19);
            this.metroLabel7.TabIndex = 72;
            this.metroLabel7.Text = "Remarks: ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(617, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(240, 19);
            this.metroLabel1.TabIndex = 79;
            this.metroLabel1.Text = "Sub Total Cost for Materials and Labor ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(696, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(157, 19);
            this.metroLabel2.TabIndex = 80;
            this.metroLabel2.Text = "Additional 6% Profit Rate";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(740, 124);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(113, 19);
            this.metroLabel4.TabIndex = 81;
            this.metroLabel4.Text = "Total Selling Price";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(810, 149);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(42, 19);
            this.metroLabel6.TabIndex = 82;
            this.metroLabel6.Text = "Forex";
            // 
            // mtxtSubTotal
            // 
            // 
            // 
            // 
            this.mtxtSubTotal.CustomButton.Image = null;
            this.mtxtSubTotal.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.mtxtSubTotal.CustomButton.Name = "";
            this.mtxtSubTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtSubTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtSubTotal.CustomButton.TabIndex = 1;
            this.mtxtSubTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtSubTotal.CustomButton.UseSelectable = true;
            this.mtxtSubTotal.CustomButton.Visible = false;
            this.mtxtSubTotal.Lines = new string[0];
            this.mtxtSubTotal.Location = new System.Drawing.Point(863, 66);
            this.mtxtSubTotal.MaxLength = 25;
            this.mtxtSubTotal.Name = "mtxtSubTotal";
            this.mtxtSubTotal.PasswordChar = '\0';
            this.mtxtSubTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtSubTotal.SelectedText = "";
            this.mtxtSubTotal.SelectionLength = 0;
            this.mtxtSubTotal.SelectionStart = 0;
            this.mtxtSubTotal.ShortcutsEnabled = true;
            this.mtxtSubTotal.Size = new System.Drawing.Size(218, 23);
            this.mtxtSubTotal.TabIndex = 83;
            this.mtxtSubTotal.UseSelectable = true;
            this.mtxtSubTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtSubTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtProfitRate
            // 
            // 
            // 
            // 
            this.mtxtProfitRate.CustomButton.Image = null;
            this.mtxtProfitRate.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.mtxtProfitRate.CustomButton.Name = "";
            this.mtxtProfitRate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtProfitRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtProfitRate.CustomButton.TabIndex = 1;
            this.mtxtProfitRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtProfitRate.CustomButton.UseSelectable = true;
            this.mtxtProfitRate.CustomButton.Visible = false;
            this.mtxtProfitRate.Lines = new string[0];
            this.mtxtProfitRate.Location = new System.Drawing.Point(863, 94);
            this.mtxtProfitRate.MaxLength = 25;
            this.mtxtProfitRate.Name = "mtxtProfitRate";
            this.mtxtProfitRate.PasswordChar = '\0';
            this.mtxtProfitRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtProfitRate.SelectedText = "";
            this.mtxtProfitRate.SelectionLength = 0;
            this.mtxtProfitRate.SelectionStart = 0;
            this.mtxtProfitRate.ShortcutsEnabled = true;
            this.mtxtProfitRate.Size = new System.Drawing.Size(218, 23);
            this.mtxtProfitRate.TabIndex = 84;
            this.mtxtProfitRate.UseSelectable = true;
            this.mtxtProfitRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtProfitRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtSellingPrice
            // 
            // 
            // 
            // 
            this.mtxtSellingPrice.CustomButton.Image = null;
            this.mtxtSellingPrice.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.mtxtSellingPrice.CustomButton.Name = "";
            this.mtxtSellingPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtSellingPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtSellingPrice.CustomButton.TabIndex = 1;
            this.mtxtSellingPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtSellingPrice.CustomButton.UseSelectable = true;
            this.mtxtSellingPrice.CustomButton.Visible = false;
            this.mtxtSellingPrice.Lines = new string[0];
            this.mtxtSellingPrice.Location = new System.Drawing.Point(863, 122);
            this.mtxtSellingPrice.MaxLength = 25;
            this.mtxtSellingPrice.Name = "mtxtSellingPrice";
            this.mtxtSellingPrice.PasswordChar = '\0';
            this.mtxtSellingPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtSellingPrice.SelectedText = "";
            this.mtxtSellingPrice.SelectionLength = 0;
            this.mtxtSellingPrice.SelectionStart = 0;
            this.mtxtSellingPrice.ShortcutsEnabled = true;
            this.mtxtSellingPrice.Size = new System.Drawing.Size(218, 23);
            this.mtxtSellingPrice.TabIndex = 85;
            this.mtxtSellingPrice.UseSelectable = true;
            this.mtxtSellingPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtSellingPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtForex
            // 
            // 
            // 
            // 
            this.mtxtForex.CustomButton.Image = null;
            this.mtxtForex.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.mtxtForex.CustomButton.Name = "";
            this.mtxtForex.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtForex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtForex.CustomButton.TabIndex = 1;
            this.mtxtForex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtForex.CustomButton.UseSelectable = true;
            this.mtxtForex.CustomButton.Visible = false;
            this.mtxtForex.Lines = new string[0];
            this.mtxtForex.Location = new System.Drawing.Point(863, 150);
            this.mtxtForex.MaxLength = 25;
            this.mtxtForex.Name = "mtxtForex";
            this.mtxtForex.PasswordChar = '\0';
            this.mtxtForex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtForex.SelectedText = "";
            this.mtxtForex.SelectionLength = 0;
            this.mtxtForex.SelectionStart = 0;
            this.mtxtForex.ShortcutsEnabled = true;
            this.mtxtForex.Size = new System.Drawing.Size(218, 23);
            this.mtxtForex.TabIndex = 86;
            this.mtxtForex.UseSelectable = true;
            this.mtxtForex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtForex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.mbtnCancel.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.cancelicon;
            this.mbtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnCancel.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.mbtnCancel.Location = new System.Drawing.Point(1150, 26);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(40, 40);
            this.mbtnCancel.TabIndex = 89;
            this.mbtnCancel.Text = " ";
            this.mbtnCancel.UseSelectable = true;
            // 
            // mbtnSave
            // 
            this.mbtnSave.BackColor = System.Drawing.Color.Transparent;
            this.mbtnSave.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.saveicon1;
            this.mbtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnSave.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.mbtnSave.Location = new System.Drawing.Point(1107, 26);
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(40, 40);
            this.mbtnSave.TabIndex = 88;
            this.mbtnSave.Text = " ";
            this.mbtnSave.UseSelectable = true;
            this.mbtnSave.Click += new System.EventHandler(this.mbtnSave_Click);
            // 
            // mbtnSearch
            // 
            this.mbtnSearch.Location = new System.Drawing.Point(360, 66);
            this.mbtnSearch.Name = "mbtnSearch";
            this.mbtnSearch.Size = new System.Drawing.Size(75, 46);
            this.mbtnSearch.TabIndex = 90;
            this.mbtnSearch.Text = "Search";
            this.mbtnSearch.UseSelectable = true;
            this.mbtnSearch.Click += new System.EventHandler(this.mbtnSearch_Click);
            // 
            // mtxtPartName
            // 
            // 
            // 
            // 
            this.mtxtPartName.CustomButton.Image = null;
            this.mtxtPartName.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.mtxtPartName.CustomButton.Name = "";
            this.mtxtPartName.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.mtxtPartName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPartName.CustomButton.TabIndex = 1;
            this.mtxtPartName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPartName.CustomButton.UseSelectable = true;
            this.mtxtPartName.CustomButton.Visible = false;
            this.mtxtPartName.Lines = new string[0];
            this.mtxtPartName.Location = new System.Drawing.Point(173, 114);
            this.mtxtPartName.MaxLength = 32767;
            this.mtxtPartName.Multiline = true;
            this.mtxtPartName.Name = "mtxtPartName";
            this.mtxtPartName.PasswordChar = '\0';
            this.mtxtPartName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPartName.SelectedText = "";
            this.mtxtPartName.SelectionLength = 0;
            this.mtxtPartName.SelectionStart = 0;
            this.mtxtPartName.ShortcutsEnabled = true;
            this.mtxtPartName.Size = new System.Drawing.Size(262, 43);
            this.mtxtPartName.TabIndex = 91;
            this.mtxtPartName.UseSelectable = true;
            this.mtxtPartName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPartName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(47, 114);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(74, 19);
            this.metroLabel8.TabIndex = 92;
            this.metroLabel8.Text = "Description";
            // 
            // frmWIPCosting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 574);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.mtxtPartName);
            this.Controls.Add(this.mbtnSearch);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mbtnSave);
            this.Controls.Add(this.mtxtForex);
            this.Controls.Add(this.mtxtSellingPrice);
            this.Controls.Add(this.mtxtProfitRate);
            this.Controls.Add(this.mtxtSubTotal);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtcWIP);
            this.Controls.Add(this.mcboCatCode);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.mtxtPartCode);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtxtItemNo);
            this.Controls.Add(this.mlblItemNo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWIPCosting";
            this.Resizable = false;
            this.Text = "Item Master";
            this.Load += new System.EventHandler(this.frmWIPCosting_Load);
            this.mtcWIP.ResumeLayout(false);
            this.mtpMaterials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgridMatList)).EndInit();
            this.mtpOthers.ResumeLayout(false);
            this.mtpOthers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox mcboCatCode;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroTextBox mtxtPartCode;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroTextBox mtxtItemNo;
        private MetroFramework.Controls.MetroLabel mlblItemNo;
        private MetroFramework.Controls.MetroTabControl mtcWIP;
        private MetroFramework.Controls.MetroTabPage mtpMaterials;
        private MetroFramework.Controls.MetroTabPage mtpLabor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        public MetroFramework.Controls.MetroTextBox mtxtSubTotal;
        public MetroFramework.Controls.MetroTextBox mtxtProfitRate;
        public MetroFramework.Controls.MetroTextBox mtxtSellingPrice;
        public MetroFramework.Controls.MetroTextBox mtxtForex;
        private MetroFramework.Controls.MetroButton mbtnCancel;
        private MetroFramework.Controls.MetroButton mbtnSave;
        private MetroFramework.Controls.MetroGrid mgridMatList;
        private MetroFramework.Controls.MetroButton mbtnSearch;
        private MetroFramework.Controls.MetroTabPage mtpOthers;
        private MetroFramework.Controls.MetroTextBox mtxtRemarks;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private MetroFramework.Controls.MetroTextBox mtxtPartName;
        private MetroFramework.Controls.MetroLabel metroLabel8;


    }
}