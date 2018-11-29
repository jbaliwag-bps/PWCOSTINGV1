﻿namespace PWCOSTINGV1.Forms
{
    partial class frmMT_PIList
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
            this.mgridListPI = new MetroFramework.Controls.MetroGrid();
            this.listTSFooter = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tstxtRowRange = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tslblRowCount = new System.Windows.Forms.ToolStripLabel();
            this.colDocIDPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoldNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCavity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoldSetup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurgePerGram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgridListPI)).BeginInit();
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
            this.listTS.Size = new System.Drawing.Size(1082, 43);
            this.listTS.TabIndex = 57;
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
            // mgridListPI
            // 
            this.mgridListPI.AllowUserToAddRows = false;
            this.mgridListPI.AllowUserToDeleteRows = false;
            this.mgridListPI.AllowUserToResizeRows = false;
            this.mgridListPI.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridListPI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgridListPI.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgridListPI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridListPI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgridListPI.ColumnHeadersHeight = 25;
            this.mgridListPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mgridListPI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDocIDPI,
            this.colMoldNo,
            this.colMoldName,
            this.colSPH,
            this.colCavity,
            this.colPPH,
            this.colUsage,
            this.colMoldSetup,
            this.colOz,
            this.colPurgePerGram,
            this.colLastUpdated,
            this.colUpdatedBy});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgridListPI.DefaultCellStyle = dataGridViewCellStyle7;
            this.mgridListPI.Dock = System.Windows.Forms.DockStyle.Top;
            this.mgridListPI.EnableHeadersVisualStyles = false;
            this.mgridListPI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgridListPI.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridListPI.Location = new System.Drawing.Point(20, 103);
            this.mgridListPI.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.mgridListPI.Name = "mgridListPI";
            this.mgridListPI.ReadOnly = true;
            this.mgridListPI.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridListPI.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.mgridListPI.RowHeadersWidth = 25;
            this.mgridListPI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgridListPI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgridListPI.Size = new System.Drawing.Size(1082, 437);
            this.mgridListPI.TabIndex = 58;
            this.mgridListPI.Tag = "";
            this.mgridListPI.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgridListPI_CellDoubleClick);
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
            this.listTSFooter.Size = new System.Drawing.Size(1082, 38);
            this.listTSFooter.TabIndex = 59;
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
            // colDocIDPI
            // 
            this.colDocIDPI.DataPropertyName = "DocID";
            dataGridViewCellStyle2.NullValue = "0";
            this.colDocIDPI.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDocIDPI.HeaderText = "Doc ID";
            this.colDocIDPI.Name = "colDocIDPI";
            this.colDocIDPI.ReadOnly = true;
            this.colDocIDPI.Visible = false;
            // 
            // colMoldNo
            // 
            this.colMoldNo.DataPropertyName = "MoldNo";
            this.colMoldNo.HeaderText = "Mold No.";
            this.colMoldNo.MinimumWidth = 100;
            this.colMoldNo.Name = "colMoldNo";
            this.colMoldNo.ReadOnly = true;
            // 
            // colMoldName
            // 
            this.colMoldName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMoldName.DataPropertyName = "MoldName";
            this.colMoldName.HeaderText = "Mold Name";
            this.colMoldName.MinimumWidth = 150;
            this.colMoldName.Name = "colMoldName";
            this.colMoldName.ReadOnly = true;
            // 
            // colSPH
            // 
            this.colSPH.DataPropertyName = "SPH";
            dataGridViewCellStyle3.Format = "N0";
            this.colSPH.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSPH.HeaderText = "Shots Per Hour";
            this.colSPH.Name = "colSPH";
            this.colSPH.ReadOnly = true;
            this.colSPH.Width = 90;
            // 
            // colCavity
            // 
            this.colCavity.DataPropertyName = "Cavity";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.colCavity.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCavity.HeaderText = "Cavity";
            this.colCavity.Name = "colCavity";
            this.colCavity.ReadOnly = true;
            this.colCavity.Width = 70;
            // 
            // colPPH
            // 
            this.colPPH.DataPropertyName = "PPH";
            dataGridViewCellStyle5.Format = "N0";
            this.colPPH.DefaultCellStyle = dataGridViewCellStyle5;
            this.colPPH.HeaderText = "Pieces Per Hour";
            this.colPPH.Name = "colPPH";
            this.colPPH.ReadOnly = true;
            this.colPPH.Width = 90;
            // 
            // colUsage
            // 
            this.colUsage.DataPropertyName = "Usage";
            dataGridViewCellStyle6.Format = "N0";
            this.colUsage.DefaultCellStyle = dataGridViewCellStyle6;
            this.colUsage.HeaderText = "Usage";
            this.colUsage.Name = "colUsage";
            this.colUsage.ReadOnly = true;
            this.colUsage.Width = 70;
            // 
            // colMoldSetup
            // 
            this.colMoldSetup.DataPropertyName = "MolSetUpTime";
            this.colMoldSetup.HeaderText = "Mold Setup(Hr)";
            this.colMoldSetup.Name = "colMoldSetup";
            this.colMoldSetup.ReadOnly = true;
            this.colMoldSetup.Width = 90;
            // 
            // colOz
            // 
            this.colOz.DataPropertyName = "Oz";
            this.colOz.HeaderText = "Oz";
            this.colOz.Name = "colOz";
            this.colOz.ReadOnly = true;
            this.colOz.Width = 70;
            // 
            // colPurgePerGram
            // 
            this.colPurgePerGram.DataPropertyName = "PurgePerG";
            this.colPurgePerGram.HeaderText = "Purge Per Gram";
            this.colPurgePerGram.Name = "colPurgePerGram";
            this.colPurgePerGram.ReadOnly = true;
            this.colPurgePerGram.Width = 90;
            // 
            // colLastUpdated
            // 
            this.colLastUpdated.DataPropertyName = "UpdatedDate";
            this.colLastUpdated.HeaderText = "Last Updated";
            this.colLastUpdated.Name = "colLastUpdated";
            this.colLastUpdated.ReadOnly = true;
            this.colLastUpdated.Width = 105;
            // 
            // colUpdatedBy
            // 
            this.colUpdatedBy.DataPropertyName = "UpdatedBy";
            this.colUpdatedBy.HeaderText = "Updated By";
            this.colUpdatedBy.Name = "colUpdatedBy";
            this.colUpdatedBy.ReadOnly = true;
            this.colUpdatedBy.Width = 105;
            // 
            // frmMT_PIList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 591);
            this.Controls.Add(this.listTSFooter);
            this.Controls.Add(this.mgridListPI);
            this.Controls.Add(this.listTS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMT_PIList";
            this.Resizable = false;
            this.Tag = "list";
            this.Text = "List of MT- Plastic Injections";
            this.Load += new System.EventHandler(this.frmMT_PIList_Load);
            this.listTS.ResumeLayout(false);
            this.listTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgridListPI)).EndInit();
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
        private MetroFramework.Controls.MetroGrid mgridListPI;
        private System.Windows.Forms.ToolStrip listTSFooter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripTextBox tstxtRowRange;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel tslblRowCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocIDPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoldNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCavity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoldSetup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOz;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurgePerGram;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastUpdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdatedBy;
    }
}