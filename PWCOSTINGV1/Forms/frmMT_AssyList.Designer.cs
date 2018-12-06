namespace PWCOSTINGV1.Forms
{
    partial class frmMT_AssyList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listTS = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this._tsbEdit = new System.Windows.Forms.ToolStripButton();
            this._tsbDelete = new System.Windows.Forms.ToolStripButton();
            this._tsbView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tstxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.mgridListAssy = new MetroFramework.Controls.MetroGrid();
            this.colDocIDAssy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartNoAssy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartNameAssy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRatePerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listTSFooter = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tstxtRowRange = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tslblRowCount = new System.Windows.Forms.ToolStripLabel();
            this.listTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgridListAssy)).BeginInit();
            this.listTSFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // listTS
            // 
            this.listTS.BackColor = System.Drawing.Color.Transparent;
            this.listTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.listTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this._tsbEdit,
            this._tsbDelete,
            this._tsbView,
            this.toolStripSeparator1,
            this.tsbRefresh,
            this.tstxtSearch,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton6,
            this.toolStripButton7});
            this.listTS.Location = new System.Drawing.Point(20, 60);
            this.listTS.Name = "listTS";
            this.listTS.Size = new System.Drawing.Size(893, 43);
            this.listTS.TabIndex = 59;
            this.listTS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.listTS_ItemClicked);
            // 
            // tsbNew
            // 
            this.tsbNew.AutoSize = false;
            this.tsbNew.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNew.Image = global::PWCOSTINGV1.Properties.Resources.new_file;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(50, 40);
            this.tsbNew.Tag = "new";
            this.tsbNew.Text = "&New";
            this.tsbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // _tsbEdit
            // 
            this._tsbEdit.AutoSize = false;
            this._tsbEdit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tsbEdit.Image = global::PWCOSTINGV1.Properties.Resources.edit_file;
            this._tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbEdit.Name = "_tsbEdit";
            this._tsbEdit.Size = new System.Drawing.Size(50, 40);
            this._tsbEdit.Tag = "edit";
            this._tsbEdit.Text = "&Edit";
            this._tsbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // _tsbDelete
            // 
            this._tsbDelete.AutoSize = false;
            this._tsbDelete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tsbDelete.Image = global::PWCOSTINGV1.Properties.Resources.delete_file;
            this._tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbDelete.Name = "_tsbDelete";
            this._tsbDelete.Size = new System.Drawing.Size(50, 40);
            this._tsbDelete.Tag = "delete";
            this._tsbDelete.Text = "&Delete";
            this._tsbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // _tsbView
            // 
            this._tsbView.AutoSize = false;
            this._tsbView.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tsbView.Image = global::PWCOSTINGV1.Properties.Resources.search_file;
            this._tsbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbView.Name = "_tsbView";
            this._tsbView.Size = new System.Drawing.Size(50, 40);
            this._tsbView.Tag = "view";
            this._tsbView.Text = "&View";
            this._tsbView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.AutoSize = false;
            this.tsbRefresh.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbRefresh.Image = global::PWCOSTINGV1.Properties.Resources.page_refresh_icon;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(50, 40);
            this.tsbRefresh.Tag = "refresh";
            this.tsbRefresh.Text = "&Refresh";
            this.tsbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tstxtSearch
            // 
            this.tstxtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxtSearch.Name = "tstxtSearch";
            this.tstxtSearch.Size = new System.Drawing.Size(100, 43);
            this.tstxtSearch.Tag = "search";
            this.tstxtSearch.TextChanged += new System.EventHandler(this.tstxtSearch_TextChanged);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.AutoSize = false;
            this.toolStripButton6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton6.Image = global::PWCOSTINGV1.Properties.Resources.copy_prev_icon;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(50, 40);
            this.toolStripButton6.Tag = "copy";
            this.toolStripButton6.Text = "&Copy";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton6.ToolTipText = "Copy Previous";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.AutoSize = false;
            this.toolStripButton7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton7.Image = global::PWCOSTINGV1.Properties.Resources.imp_exc_icon;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(50, 40);
            this.toolStripButton7.Tag = "import";
            this.toolStripButton7.Text = "&Import";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton7.ToolTipText = "Import Excel";
            // 
            // mgridListAssy
            // 
            this.mgridListAssy.AllowUserToAddRows = false;
            this.mgridListAssy.AllowUserToDeleteRows = false;
            this.mgridListAssy.AllowUserToResizeRows = false;
            this.mgridListAssy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridListAssy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgridListAssy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgridListAssy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridListAssy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgridListAssy.ColumnHeadersHeight = 25;
            this.mgridListAssy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mgridListAssy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDocIDAssy,
            this.colPartNoAssy,
            this.colPartNameAssy,
            this.colHC,
            this.colQty,
            this.colRatePerHour,
            this.colLastUpdated,
            this.colUpdatedBy});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgridListAssy.DefaultCellStyle = dataGridViewCellStyle4;
            this.mgridListAssy.Dock = System.Windows.Forms.DockStyle.Top;
            this.mgridListAssy.EnableHeadersVisualStyles = false;
            this.mgridListAssy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgridListAssy.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridListAssy.Location = new System.Drawing.Point(20, 103);
            this.mgridListAssy.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.mgridListAssy.Name = "mgridListAssy";
            this.mgridListAssy.ReadOnly = true;
            this.mgridListAssy.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridListAssy.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.mgridListAssy.RowHeadersWidth = 25;
            this.mgridListAssy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgridListAssy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgridListAssy.Size = new System.Drawing.Size(893, 437);
            this.mgridListAssy.TabIndex = 60;
            this.mgridListAssy.Tag = "list";
            this.mgridListAssy.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgridListAssy_CellDoubleClick);
            // 
            // colDocIDAssy
            // 
            this.colDocIDAssy.DataPropertyName = "DocID";
            this.colDocIDAssy.HeaderText = "Doc ID";
            this.colDocIDAssy.Name = "colDocIDAssy";
            this.colDocIDAssy.ReadOnly = true;
            this.colDocIDAssy.Visible = false;
            // 
            // colPartNoAssy
            // 
            this.colPartNoAssy.DataPropertyName = "PartNo";
            this.colPartNoAssy.HeaderText = "Part No.";
            this.colPartNoAssy.MinimumWidth = 100;
            this.colPartNoAssy.Name = "colPartNoAssy";
            this.colPartNoAssy.ReadOnly = true;
            // 
            // colPartNameAssy
            // 
            this.colPartNameAssy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPartNameAssy.DataPropertyName = "PartName";
            this.colPartNameAssy.HeaderText = "Part Name";
            this.colPartNameAssy.MinimumWidth = 150;
            this.colPartNameAssy.Name = "colPartNameAssy";
            this.colPartNameAssy.ReadOnly = true;
            // 
            // colHC
            // 
            this.colHC.DataPropertyName = "HC";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.colHC.DefaultCellStyle = dataGridViewCellStyle2;
            this.colHC.HeaderText = "H/C";
            this.colHC.Name = "colHC";
            this.colHC.ReadOnly = true;
            this.colHC.Width = 70;
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "Qty";
            dataGridViewCellStyle3.Format = "N0";
            this.colQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.colQty.HeaderText = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            this.colQty.Width = 70;
            // 
            // colRatePerHour
            // 
            this.colRatePerHour.DataPropertyName = "RatePerHour";
            this.colRatePerHour.HeaderText = "Rate Per Hour";
            this.colRatePerHour.MinimumWidth = 100;
            this.colRatePerHour.Name = "colRatePerHour";
            this.colRatePerHour.ReadOnly = true;
            this.colRatePerHour.Width = 120;
            // 
            // colLastUpdated
            // 
            this.colLastUpdated.DataPropertyName = "UpdatedDate";
            this.colLastUpdated.HeaderText = "Last Updated";
            this.colLastUpdated.Name = "colLastUpdated";
            this.colLastUpdated.ReadOnly = true;
            this.colLastUpdated.Width = 150;
            // 
            // colUpdatedBy
            // 
            this.colUpdatedBy.DataPropertyName = "UpdatedBy";
            this.colUpdatedBy.HeaderText = "Updated By";
            this.colUpdatedBy.Name = "colUpdatedBy";
            this.colUpdatedBy.ReadOnly = true;
            this.colUpdatedBy.Width = 150;
            // 
            // listTSFooter
            // 
            this.listTSFooter.BackColor = System.Drawing.Color.Transparent;
            this.listTSFooter.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.listTSFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.tstxtRowRange,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripButton4,
            this.tslblRowCount});
            this.listTSFooter.Location = new System.Drawing.Point(20, 540);
            this.listTSFooter.Name = "listTSFooter";
            this.listTSFooter.Size = new System.Drawing.Size(893, 38);
            this.listTSFooter.TabIndex = 61;
            this.listTSFooter.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.listTSFooter_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = global::PWCOSTINGV1.Properties.Resources.first_page;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(35, 35);
            this.toolStripButton1.Tag = "first";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = global::PWCOSTINGV1.Properties.Resources.prev;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(35, 35);
            this.toolStripButton2.Tag = "prev";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.Image = global::PWCOSTINGV1.Properties.Resources.next;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(35, 35);
            this.toolStripButton3.Tag = "next";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton4.Image = global::PWCOSTINGV1.Properties.Resources.last_page;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(35, 35);
            this.toolStripButton4.Tag = "last";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tslblRowCount
            // 
            this.tslblRowCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslblRowCount.Name = "tslblRowCount";
            this.tslblRowCount.Size = new System.Drawing.Size(86, 35);
            this.tslblRowCount.Text = "toolStripLabel2";
            // 
            // frmMT_AssyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 591);
            this.Controls.Add(this.listTSFooter);
            this.Controls.Add(this.mgridListAssy);
            this.Controls.Add(this.listTS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMT_AssyList";
            this.Resizable = false;
            this.Text = "List of MT- Assembly";
            this.Load += new System.EventHandler(this.frmMT_AssyList_Load);
            this.listTS.ResumeLayout(false);
            this.listTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgridListAssy)).EndInit();
            this.listTSFooter.ResumeLayout(false);
            this.listTSFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip listTS;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton _tsbEdit;
        private System.Windows.Forms.ToolStripButton _tsbDelete;
        private System.Windows.Forms.ToolStripButton _tsbView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripTextBox tstxtSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private MetroFramework.Controls.MetroGrid mgridListAssy;
        private System.Windows.Forms.ToolStrip listTSFooter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox tstxtRowRange;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel tslblRowCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocIDAssy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartNoAssy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartNameAssy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRatePerHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastUpdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdatedBy;
    }
}