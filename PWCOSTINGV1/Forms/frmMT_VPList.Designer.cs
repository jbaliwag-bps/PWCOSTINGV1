namespace PWCOSTINGV1.Forms
{
    partial class frmMT_VPList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listTS = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tstxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.mgridListVP = new MetroFramework.Controls.MetroGrid();
            this.listTSFooter = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tstxtRowRange = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tslblRowCount = new System.Windows.Forms.ToolStripLabel();
            this.colDocIDVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartNoVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartNameVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgridListVP)).BeginInit();
            this.listTSFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // listTS
            // 
            this.listTS.BackColor = System.Drawing.Color.Transparent;
            this.listTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.listTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbEdit,
            this.tsbDelete,
            this.tsbView,
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
            this.listTS.TabIndex = 58;
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
            // tsbEdit
            // 
            this.tsbEdit.AutoSize = false;
            this.tsbEdit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbEdit.Image = global::PWCOSTINGV1.Properties.Resources.edit_file;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(50, 40);
            this.tsbEdit.Tag = "edit";
            this.tsbEdit.Text = "&Edit";
            this.tsbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbDelete
            // 
            this.tsbDelete.AutoSize = false;
            this.tsbDelete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbDelete.Image = global::PWCOSTINGV1.Properties.Resources.delete_file;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(50, 40);
            this.tsbDelete.Tag = "delete";
            this.tsbDelete.Text = "&Delete";
            this.tsbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbView
            // 
            this.tsbView.AutoSize = false;
            this.tsbView.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbView.Image = global::PWCOSTINGV1.Properties.Resources.search_file;
            this.tsbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbView.Name = "tsbView";
            this.tsbView.Size = new System.Drawing.Size(50, 40);
            this.tsbView.Tag = "view";
            this.tsbView.Text = "&View";
            this.tsbView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // mgridListVP
            // 
            this.mgridListVP.AllowUserToAddRows = false;
            this.mgridListVP.AllowUserToDeleteRows = false;
            this.mgridListVP.AllowUserToResizeRows = false;
            this.mgridListVP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridListVP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgridListVP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgridListVP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridListVP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgridListVP.ColumnHeadersHeight = 25;
            this.mgridListVP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mgridListVP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDocIDVP,
            this.colPartNoVP,
            this.colPartNameVP,
            this.colSourceData,
            this.colLastUpdated,
            this.colUpdatedBy});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgridListVP.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgridListVP.Dock = System.Windows.Forms.DockStyle.Top;
            this.mgridListVP.EnableHeadersVisualStyles = false;
            this.mgridListVP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgridListVP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridListVP.Location = new System.Drawing.Point(20, 103);
            this.mgridListVP.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.mgridListVP.Name = "mgridListVP";
            this.mgridListVP.ReadOnly = true;
            this.mgridListVP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridListVP.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgridListVP.RowHeadersWidth = 25;
            this.mgridListVP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgridListVP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgridListVP.Size = new System.Drawing.Size(893, 437);
            this.mgridListVP.TabIndex = 59;
            this.mgridListVP.Tag = "list";
            this.mgridListVP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgridListVP_CellDoubleClick);
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
            this.listTSFooter.TabIndex = 60;
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
            // colDocIDVP
            // 
            this.colDocIDVP.DataPropertyName = "DocID";
            this.colDocIDVP.HeaderText = "Doc ID";
            this.colDocIDVP.Name = "colDocIDVP";
            this.colDocIDVP.ReadOnly = true;
            this.colDocIDVP.Visible = false;
            // 
            // colPartNoVP
            // 
            this.colPartNoVP.DataPropertyName = "PartNo";
            this.colPartNoVP.HeaderText = "Part No.";
            this.colPartNoVP.MinimumWidth = 100;
            this.colPartNoVP.Name = "colPartNoVP";
            this.colPartNoVP.ReadOnly = true;
            // 
            // colPartNameVP
            // 
            this.colPartNameVP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPartNameVP.DataPropertyName = "PartName";
            this.colPartNameVP.HeaderText = "Part Name";
            this.colPartNameVP.MinimumWidth = 150;
            this.colPartNameVP.Name = "colPartNameVP";
            this.colPartNameVP.ReadOnly = true;
            // 
            // colSourceData
            // 
            this.colSourceData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSourceData.DataPropertyName = "SourceData";
            this.colSourceData.HeaderText = "Source Data";
            this.colSourceData.MinimumWidth = 100;
            this.colSourceData.Name = "colSourceData";
            this.colSourceData.ReadOnly = true;
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
            this.colUpdatedBy.Width = 150;
            // 
            // frmMT_VPList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 591);
            this.Controls.Add(this.listTSFooter);
            this.Controls.Add(this.mgridListVP);
            this.Controls.Add(this.listTS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMT_VPList";
            this.Resizable = false;
            this.Text = "List of MT- Vacuum Plating/ Forming ";
            this.Load += new System.EventHandler(this.frmMT_VPList_Load);
            this.listTS.ResumeLayout(false);
            this.listTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgridListVP)).EndInit();
            this.listTSFooter.ResumeLayout(false);
            this.listTSFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip listTS;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripTextBox tstxtSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private MetroFramework.Controls.MetroGrid mgridListVP;
        private System.Windows.Forms.ToolStrip listTSFooter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox tstxtRowRange;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel tslblRowCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocIDVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartNoVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartNameVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastUpdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdatedBy;
    }
}