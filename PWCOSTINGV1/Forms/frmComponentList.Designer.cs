namespace PWCOSTINGV1.Forms
{
    partial class frmComponentList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listTS = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this._toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this._toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this._toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this._toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStriptxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.mgridList = new MetroFramework.Controls.MetroGrid();
            this.colDocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSectionDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWholeQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWholeUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWholePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConversionPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreviousPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsLocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.listTSFooter = new System.Windows.Forms.ToolStrip();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tstxtRowRange = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.tslblRowCount = new System.Windows.Forms.ToolStripLabel();
            this.listTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgridList)).BeginInit();
            this.listTSFooter.SuspendLayout();
            this.SuspendLayout();
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
            this._toolStripButton6,
            this.toolStripSeparator2,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStriptxtSearch,
            this.toolStripLabel1});
            this.listTS.Location = new System.Drawing.Point(20, 60);
            this.listTS.Name = "listTS";
            this.listTS.Size = new System.Drawing.Size(1173, 43);
            this.listTS.TabIndex = 5;
            this.listTS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.listTS_ItemClicked);
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
            // _toolStripButton6
            // 
            this._toolStripButton6.AutoSize = false;
            this._toolStripButton6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._toolStripButton6.Image = global::PWCOSTINGV1.Properties.Resources.printer;
            this._toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripButton6.Name = "_toolStripButton6";
            this._toolStripButton6.Size = new System.Drawing.Size(50, 40);
            this._toolStripButton6.Tag = "print";
            this._toolStripButton6.Text = "&Print";
            this._toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.AutoSize = false;
            this.toolStripButton7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton7.Image = global::PWCOSTINGV1.Properties.Resources.copy_prev_icon;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(50, 40);
            this.toolStripButton7.Tag = "copy";
            this.toolStripButton7.Text = "&Copy";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton7.ToolTipText = "Copy Previous";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.AutoSize = false;
            this.toolStripButton8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton8.Image = global::PWCOSTINGV1.Properties.Resources.imp_exc_icon;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(50, 40);
            this.toolStripButton8.Tag = "import";
            this.toolStripButton8.Text = "&Import";
            this.toolStripButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton8.ToolTipText = "Import Excel";
            // 
            // toolStriptxtSearch
            // 
            this.toolStriptxtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStriptxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStriptxtSearch.Name = "toolStriptxtSearch";
            this.toolStriptxtSearch.Size = new System.Drawing.Size(100, 43);
            this.toolStriptxtSearch.Tag = "search";
            this.toolStriptxtSearch.TextChanged += new System.EventHandler(this.toolStriptxtSearch_TextChanged);
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
            // mgridList
            // 
            this.mgridList.AllowUserToAddRows = false;
            this.mgridList.AllowUserToDeleteRows = false;
            this.mgridList.AllowUserToResizeRows = false;
            this.mgridList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgridList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgridList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgridList.ColumnHeadersHeight = 25;
            this.mgridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDocID,
            this.colPartNo,
            this.colSectionDesc,
            this.colWholeQty,
            this.colWholeUnit,
            this.colConQty,
            this.colConUnit,
            this.colWholePrice,
            this.colConversionPrice,
            this.colPreviousPrice,
            this.colLastUpdated,
            this.colUpdatedBy,
            this.colIsLocked});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgridList.DefaultCellStyle = dataGridViewCellStyle7;
            this.mgridList.Dock = System.Windows.Forms.DockStyle.Top;
            this.mgridList.EnableHeadersVisualStyles = false;
            this.mgridList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgridList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridList.Location = new System.Drawing.Point(20, 103);
            this.mgridList.Name = "mgridList";
            this.mgridList.ReadOnly = true;
            this.mgridList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.mgridList.RowHeadersWidth = 25;
            this.mgridList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgridList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mgridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgridList.Size = new System.Drawing.Size(1173, 437);
            this.mgridList.TabIndex = 8;
            this.mgridList.Tag = "list";
            this.mgridList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgridList_CellDoubleClick);
            // 
            // colDocID
            // 
            this.colDocID.DataPropertyName = "DocID";
            this.colDocID.HeaderText = "Doc ID";
            this.colDocID.Name = "colDocID";
            this.colDocID.ReadOnly = true;
            this.colDocID.Visible = false;
            // 
            // colPartNo
            // 
            this.colPartNo.DataPropertyName = "PartNo";
            this.colPartNo.HeaderText = "Part No.";
            this.colPartNo.MinimumWidth = 100;
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.ReadOnly = true;
            // 
            // colSectionDesc
            // 
            this.colSectionDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSectionDesc.DataPropertyName = "PartName";
            this.colSectionDesc.HeaderText = "Name";
            this.colSectionDesc.MinimumWidth = 150;
            this.colSectionDesc.Name = "colSectionDesc";
            this.colSectionDesc.ReadOnly = true;
            // 
            // colWholeQty
            // 
            this.colWholeQty.DataPropertyName = "WholeQty";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.colWholeQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.colWholeQty.HeaderText = "Wh. Qty";
            this.colWholeQty.Name = "colWholeQty";
            this.colWholeQty.ReadOnly = true;
            this.colWholeQty.Width = 75;
            // 
            // colWholeUnit
            // 
            this.colWholeUnit.DataPropertyName = "WholeUnit";
            this.colWholeUnit.HeaderText = "Wh. Unit";
            this.colWholeUnit.Name = "colWholeUnit";
            this.colWholeUnit.ReadOnly = true;
            this.colWholeUnit.Width = 75;
            // 
            // colConQty
            // 
            this.colConQty.DataPropertyName = "ConversionQty";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.colConQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.colConQty.HeaderText = "Con. Qty";
            this.colConQty.Name = "colConQty";
            this.colConQty.ReadOnly = true;
            this.colConQty.Width = 75;
            // 
            // colConUnit
            // 
            this.colConUnit.DataPropertyName = "ConversionUnit";
            this.colConUnit.HeaderText = "Con. Unit";
            this.colConUnit.Name = "colConUnit";
            this.colConUnit.ReadOnly = true;
            // 
            // colWholePrice
            // 
            this.colWholePrice.DataPropertyName = "WholePrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.colWholePrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.colWholePrice.HeaderText = "Whole Price";
            this.colWholePrice.Name = "colWholePrice";
            this.colWholePrice.ReadOnly = true;
            // 
            // colConversionPrice
            // 
            this.colConversionPrice.DataPropertyName = "ConversionPrice";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.colConversionPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.colConversionPrice.HeaderText = "Con. Price";
            this.colConversionPrice.Name = "colConversionPrice";
            this.colConversionPrice.ReadOnly = true;
            // 
            // colPreviousPrice
            // 
            this.colPreviousPrice.DataPropertyName = "PreviousPrice";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.colPreviousPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.colPreviousPrice.HeaderText = "Prev. Price";
            this.colPreviousPrice.Name = "colPreviousPrice";
            this.colPreviousPrice.ReadOnly = true;
            // 
            // colLastUpdated
            // 
            this.colLastUpdated.DataPropertyName = "UpdatedDate";
            this.colLastUpdated.HeaderText = "Last Updated";
            this.colLastUpdated.Name = "colLastUpdated";
            this.colLastUpdated.ReadOnly = true;
            // 
            // colUpdatedBy
            // 
            this.colUpdatedBy.DataPropertyName = "UpdatedBy";
            this.colUpdatedBy.HeaderText = "Updated By";
            this.colUpdatedBy.Name = "colUpdatedBy";
            this.colUpdatedBy.ReadOnly = true;
            // 
            // colIsLocked
            // 
            this.colIsLocked.DataPropertyName = "IsLocked";
            this.colIsLocked.HeaderText = "Locked";
            this.colIsLocked.Name = "colIsLocked";
            this.colIsLocked.ReadOnly = true;
            this.colIsLocked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsLocked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsLocked.Width = 50;
            // 
            // listTSFooter
            // 
            this.listTSFooter.BackColor = System.Drawing.Color.Transparent;
            this.listTSFooter.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.listTSFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripSeparator4,
            this.tstxtRowRange,
            this.toolStripSeparator3,
            this.toolStripButton11,
            this.toolStripButton12,
            this.tslblRowCount});
            this.listTSFooter.Location = new System.Drawing.Point(20, 540);
            this.listTSFooter.Name = "listTSFooter";
            this.listTSFooter.Size = new System.Drawing.Size(1173, 38);
            this.listTSFooter.TabIndex = 62;
            this.listTSFooter.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.listTSFooter_ItemClicked);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.AutoSize = false;
            this.toolStripButton9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton9.Image = global::PWCOSTINGV1.Properties.Resources.first_page;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(35, 35);
            this.toolStripButton9.Tag = "first";
            this.toolStripButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.AutoSize = false;
            this.toolStripButton10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton10.Image = global::PWCOSTINGV1.Properties.Resources.prev;
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(35, 35);
            this.toolStripButton10.Tag = "prev";
            this.toolStripButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // tstxtRowRange
            // 
            this.tstxtRowRange.Enabled = false;
            this.tstxtRowRange.Name = "tstxtRowRange";
            this.tstxtRowRange.Size = new System.Drawing.Size(100, 38);
            this.tstxtRowRange.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.AutoSize = false;
            this.toolStripButton11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton11.Image = global::PWCOSTINGV1.Properties.Resources.next;
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(35, 35);
            this.toolStripButton11.Tag = "next";
            this.toolStripButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.AutoSize = false;
            this.toolStripButton12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton12.Image = global::PWCOSTINGV1.Properties.Resources.last_page;
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(35, 35);
            this.toolStripButton12.Tag = "last";
            this.toolStripButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tslblRowCount
            // 
            this.tslblRowCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslblRowCount.Name = "tslblRowCount";
            this.tslblRowCount.Size = new System.Drawing.Size(86, 35);
            this.tslblRowCount.Text = "toolStripLabel2";
            // 
            // frmComponentList
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 591);
            this.Controls.Add(this.listTSFooter);
            this.Controls.Add(this.mgridList);
            this.Controls.Add(this.listTS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmComponentList";
            this.Resizable = false;
            this.Tag = "list";
            this.Text = "List of Materials";
            this.Load += new System.EventHandler(this.frmComponentList_Load);
            this.listTS.ResumeLayout(false);
            this.listTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgridList)).EndInit();
            this.listTSFooter.ResumeLayout(false);
            this.listTSFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip listTS;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton _toolStripButton2;
        private System.Windows.Forms.ToolStripButton _toolStripButton3;
        private System.Windows.Forms.ToolStripButton _toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton _toolStripButton6;
        private System.Windows.Forms.ToolStripTextBox toolStriptxtSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private MetroFramework.Controls.MetroGrid mgridList;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStrip listTSFooter;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox tstxtRowRange;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripLabel tslblRowCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSectionDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWholeQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWholeUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWholePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConversionPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreviousPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastUpdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdatedBy;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsLocked;


    }
}