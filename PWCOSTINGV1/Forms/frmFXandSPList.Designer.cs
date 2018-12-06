namespace PWCOSTINGV1.Forms
{
    partial class frmFXandSPList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this._toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this._toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this._toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.listTS = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStriptxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.mgridList1 = new MetroFramework.Controls.MetroGrid();
            this.colRecID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecType1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEffectiveDate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYearUsed1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.mgridList2 = new MetroFramework.Controls.MetroGrid();
            this.colRecID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecType2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEffectiveDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYearUsed2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.mlblFXCount = new MetroFramework.Controls.MetroLabel();
            this.mlblSPCount = new MetroFramework.Controls.MetroLabel();
            this.listTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgridList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgridList2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Image = global::PWCOSTINGV1.Properties.Resources.binoculars_icon;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 40);
            this.toolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // _toolStripButton4
            // 
            this._toolStripButton4.AutoSize = false;
            this._toolStripButton4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._toolStripButton4.Image = global::PWCOSTINGV1.Properties.Resources.search_file;
            this._toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripButton4.Name = "_toolStripButton4";
            this._toolStripButton4.Size = new System.Drawing.Size(50, 40);
            this._toolStripButton4.Tag = "view";
            this._toolStripButton4.Text = "&View";
            this._toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // _toolStripButton3
            // 
            this._toolStripButton3.AutoSize = false;
            this._toolStripButton3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._toolStripButton3.Image = global::PWCOSTINGV1.Properties.Resources.delete_file;
            this._toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripButton3.Name = "_toolStripButton3";
            this._toolStripButton3.Size = new System.Drawing.Size(50, 40);
            this._toolStripButton3.Tag = "delete";
            this._toolStripButton3.Text = "&Delete";
            this._toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // _toolStripButton2
            // 
            this._toolStripButton2.AutoSize = false;
            this._toolStripButton2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._toolStripButton2.Image = global::PWCOSTINGV1.Properties.Resources.edit_file;
            this._toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripButton2.Name = "_toolStripButton2";
            this._toolStripButton2.Size = new System.Drawing.Size(50, 40);
            this._toolStripButton2.Tag = "edit";
            this._toolStripButton2.Text = "&Edit";
            this._toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = global::PWCOSTINGV1.Properties.Resources.new_file;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(50, 40);
            this.toolStripButton1.Tag = "new";
            this.toolStripButton1.Text = "&New";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // listTS
            // 
            this.listTS.BackColor = System.Drawing.Color.Transparent;
            this.listTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.listTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this._toolStripButton2,
            this._toolStripButton3,
            this._toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripButton5,
            this.toolStriptxtSearch,
            this.toolStripLabel1});
            this.listTS.Location = new System.Drawing.Point(20, 60);
            this.listTS.Name = "listTS";
            this.listTS.Size = new System.Drawing.Size(893, 43);
            this.listTS.TabIndex = 10;
            this.listTS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.listTS_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton5.Image = global::PWCOSTINGV1.Properties.Resources.page_refresh_icon;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(50, 40);
            this.toolStripButton5.Tag = "refresh";
            this.toolStripButton5.Text = "&Refresh";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStriptxtSearch
            // 
            this.toolStriptxtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStriptxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStriptxtSearch.Name = "toolStriptxtSearch";
            this.toolStriptxtSearch.Size = new System.Drawing.Size(100, 43);
            this.toolStriptxtSearch.Tag = "search";
            // 
            // mgridList1
            // 
            this.mgridList1.AllowUserToAddRows = false;
            this.mgridList1.AllowUserToDeleteRows = false;
            this.mgridList1.AllowUserToResizeRows = false;
            this.mgridList1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridList1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgridList1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgridList1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridList1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgridList1.ColumnHeadersHeight = 25;
            this.mgridList1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mgridList1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRecID1,
            this.colRecType1,
            this.colEffectiveDate1,
            this.colRate1,
            this.colYearUsed1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgridList1.DefaultCellStyle = dataGridViewCellStyle3;
            this.mgridList1.EnableHeadersVisualStyles = false;
            this.mgridList1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgridList1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridList1.Location = new System.Drawing.Point(23, 144);
            this.mgridList1.Name = "mgridList1";
            this.mgridList1.ReadOnly = true;
            this.mgridList1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridList1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgridList1.RowHeadersWidth = 25;
            this.mgridList1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgridList1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mgridList1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgridList1.Size = new System.Drawing.Size(428, 405);
            this.mgridList1.TabIndex = 21;
            this.mgridList1.Tag = "";
            this.mgridList1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgridList1_CellClick);
            this.mgridList1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgridList1_CellDoubleClick);
            // 
            // colRecID1
            // 
            this.colRecID1.DataPropertyName = "RecID";
            this.colRecID1.HeaderText = "Rec ID";
            this.colRecID1.Name = "colRecID1";
            this.colRecID1.ReadOnly = true;
            this.colRecID1.Visible = false;
            // 
            // colRecType1
            // 
            this.colRecType1.DataPropertyName = "RecType";
            this.colRecType1.HeaderText = "Type";
            this.colRecType1.Name = "colRecType1";
            this.colRecType1.ReadOnly = true;
            this.colRecType1.Visible = false;
            // 
            // colEffectiveDate1
            // 
            this.colEffectiveDate1.DataPropertyName = "EffectiveDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.colEffectiveDate1.DefaultCellStyle = dataGridViewCellStyle2;
            this.colEffectiveDate1.HeaderText = "Effective Date";
            this.colEffectiveDate1.MinimumWidth = 150;
            this.colEffectiveDate1.Name = "colEffectiveDate1";
            this.colEffectiveDate1.ReadOnly = true;
            this.colEffectiveDate1.Width = 200;
            // 
            // colRate1
            // 
            this.colRate1.DataPropertyName = "Rate";
            this.colRate1.HeaderText = "Rate";
            this.colRate1.MinimumWidth = 150;
            this.colRate1.Name = "colRate1";
            this.colRate1.ReadOnly = true;
            this.colRate1.Width = 375;
            // 
            // colYearUsed1
            // 
            this.colYearUsed1.DataPropertyName = "YearUsed";
            this.colYearUsed1.HeaderText = "Year";
            this.colYearUsed1.Name = "colYearUsed1";
            this.colYearUsed1.ReadOnly = true;
            this.colYearUsed1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 119);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Forex Rates";
            // 
            // mgridList2
            // 
            this.mgridList2.AllowUserToAddRows = false;
            this.mgridList2.AllowUserToDeleteRows = false;
            this.mgridList2.AllowUserToResizeRows = false;
            this.mgridList2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridList2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgridList2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgridList2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridList2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.mgridList2.ColumnHeadersHeight = 25;
            this.mgridList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mgridList2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRecID2,
            this.colRecType2,
            this.colEffectiveDate2,
            this.colRate2,
            this.colYearUsed2});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgridList2.DefaultCellStyle = dataGridViewCellStyle7;
            this.mgridList2.EnableHeadersVisualStyles = false;
            this.mgridList2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgridList2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridList2.Location = new System.Drawing.Point(482, 144);
            this.mgridList2.Name = "mgridList2";
            this.mgridList2.ReadOnly = true;
            this.mgridList2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridList2.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.mgridList2.RowHeadersWidth = 25;
            this.mgridList2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgridList2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mgridList2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgridList2.Size = new System.Drawing.Size(428, 405);
            this.mgridList2.TabIndex = 23;
            this.mgridList2.Tag = "";
            this.mgridList2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgridList2_CellClick);
            this.mgridList2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgridList2_CellDoubleClick);
            // 
            // colRecID2
            // 
            this.colRecID2.DataPropertyName = "RecID";
            this.colRecID2.HeaderText = "Rec ID";
            this.colRecID2.Name = "colRecID2";
            this.colRecID2.ReadOnly = true;
            this.colRecID2.Visible = false;
            // 
            // colRecType2
            // 
            this.colRecType2.DataPropertyName = "RecType";
            this.colRecType2.HeaderText = "Type";
            this.colRecType2.Name = "colRecType2";
            this.colRecType2.ReadOnly = true;
            this.colRecType2.Visible = false;
            // 
            // colEffectiveDate2
            // 
            this.colEffectiveDate2.DataPropertyName = "EffectiveDate";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.colEffectiveDate2.DefaultCellStyle = dataGridViewCellStyle6;
            this.colEffectiveDate2.HeaderText = "Effective Date";
            this.colEffectiveDate2.MinimumWidth = 150;
            this.colEffectiveDate2.Name = "colEffectiveDate2";
            this.colEffectiveDate2.ReadOnly = true;
            this.colEffectiveDate2.Width = 200;
            // 
            // colRate2
            // 
            this.colRate2.DataPropertyName = "Rate";
            this.colRate2.HeaderText = "Rate";
            this.colRate2.MinimumWidth = 150;
            this.colRate2.Name = "colRate2";
            this.colRate2.ReadOnly = true;
            this.colRate2.Width = 375;
            // 
            // colYearUsed2
            // 
            this.colYearUsed2.DataPropertyName = "YearUsed";
            this.colYearUsed2.HeaderText = "Year";
            this.colYearUsed2.Name = "colYearUsed2";
            this.colYearUsed2.ReadOnly = true;
            this.colYearUsed2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(482, 120);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "SP Rates";
            // 
            // mlblFXCount
            // 
            this.mlblFXCount.AutoSize = true;
            this.mlblFXCount.Location = new System.Drawing.Point(191, 558);
            this.mlblFXCount.Name = "mlblFXCount";
            this.mlblFXCount.Size = new System.Drawing.Size(94, 19);
            this.mlblFXCount.TabIndex = 25;
            this.mlblFXCount.Text = "No of Records";
            // 
            // mlblSPCount
            // 
            this.mlblSPCount.AutoSize = true;
            this.mlblSPCount.Location = new System.Drawing.Point(650, 558);
            this.mlblSPCount.Name = "mlblSPCount";
            this.mlblSPCount.Size = new System.Drawing.Size(94, 19);
            this.mlblSPCount.TabIndex = 26;
            this.mlblSPCount.Text = "No of Records";
            // 
            // frmFXandSPList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 591);
            this.Controls.Add(this.mlblSPCount);
            this.Controls.Add(this.mlblFXCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mgridList2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mgridList1);
            this.Controls.Add(this.listTS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFXandSPList";
            this.Resizable = false;
            this.Tag = "list";
            this.Text = "List of FX and SP Rates";
            this.Load += new System.EventHandler(this.frmFXandSPList_Load);
            this.listTS.ResumeLayout(false);
            this.listTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgridList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgridList2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton _toolStripButton4;
        private System.Windows.Forms.ToolStripButton _toolStripButton3;
        private System.Windows.Forms.ToolStripButton _toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip listTS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripTextBox toolStriptxtSearch;
        private MetroFramework.Controls.MetroGrid mgridList1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroGrid mgridList2;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroLabel mlblFXCount;
        private MetroFramework.Controls.MetroLabel mlblSPCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecType1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEffectiveDate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYearUsed1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecType2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEffectiveDate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYearUsed2;

    }
}