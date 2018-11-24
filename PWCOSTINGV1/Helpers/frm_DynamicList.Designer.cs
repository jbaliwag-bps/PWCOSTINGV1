namespace PWCOSTINGV1.Forms
{
    partial class frm_DynamicList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listTS = new System.Windows.Forms.ToolStrip();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.tstxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.mgridList = new MetroFramework.Controls.MetroGrid();
            this.colDocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYEARUSED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbtnAdd = new MetroFramework.Controls.MetroButton();
            this.listTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgridList)).BeginInit();
            this.SuspendLayout();
            // 
            // listTS
            // 
            this.listTS.BackColor = System.Drawing.Color.Transparent;
            this.listTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.listTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton6,
            this.tstxtSearch,
            this.toolStripLabel1});
            this.listTS.Location = new System.Drawing.Point(20, 60);
            this.listTS.Name = "listTS";
            this.listTS.Size = new System.Drawing.Size(1044, 43);
            this.listTS.TabIndex = 6;
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.AutoSize = false;
            this.toolStripButton6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton6.Image = global::PWCOSTINGV1.Properties.Resources.page_refresh_icon;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(50, 40);
            this.toolStripButton6.Tag = "refresh";
            this.toolStripButton6.Text = "&Refresh";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tstxtSearch
            // 
            this.tstxtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxtSearch.Name = "tstxtSearch";
            this.tstxtSearch.Size = new System.Drawing.Size(100, 43);
            this.tstxtSearch.Tag = "search";
            this.tstxtSearch.TextChanged += new System.EventHandler(this.toolStriptxtSearch_TextChanged);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgridList.ColumnHeadersHeight = 25;
            this.mgridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDocID,
            this.colYEARUSED});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgridList.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgridList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mgridList.EnableHeadersVisualStyles = false;
            this.mgridList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgridList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridList.Location = new System.Drawing.Point(20, 103);
            this.mgridList.Name = "mgridList";
            this.mgridList.ReadOnly = true;
            this.mgridList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgridList.RowHeadersWidth = 25;
            this.mgridList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgridList.Size = new System.Drawing.Size(1044, 451);
            this.mgridList.TabIndex = 9;
            this.mgridList.Tag = "";
            // 
            // colDocID
            // 
            this.colDocID.DataPropertyName = "DocID";
            this.colDocID.HeaderText = "Doc ID";
            this.colDocID.Name = "colDocID";
            this.colDocID.ReadOnly = true;
            this.colDocID.Visible = false;
            // 
            // colYEARUSED
            // 
            this.colYEARUSED.DataPropertyName = "YEARUSED";
            this.colYEARUSED.HeaderText = "Year Used";
            this.colYEARUSED.Name = "colYEARUSED";
            this.colYEARUSED.ReadOnly = true;
            this.colYEARUSED.Visible = false;
            // 
            // mbtnAdd
            // 
            this.mbtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnAdd.Location = new System.Drawing.Point(1016, 26);
            this.mbtnAdd.Name = "mbtnAdd";
            this.mbtnAdd.Size = new System.Drawing.Size(45, 40);
            this.mbtnAdd.TabIndex = 58;
            this.mbtnAdd.Text = "Ok";
            this.mbtnAdd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mbtnAdd.UseSelectable = true;
            this.mbtnAdd.Click += new System.EventHandler(this.mbtnAdd_Click);
            // 
            // frm_DynamicList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 574);
            this.Controls.Add(this.mbtnAdd);
            this.Controls.Add(this.mgridList);
            this.Controls.Add(this.listTS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DynamicList";
            this.Resizable = false;
            this.Text = "Dynamic List";
            this.Load += new System.EventHandler(this.frm_DynamicList_Load);
            this.listTS.ResumeLayout(false);
            this.listTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip listTS;
        private System.Windows.Forms.ToolStripTextBox tstxtSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private MetroFramework.Controls.MetroGrid mgridList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYEARUSED;
        private MetroFramework.Controls.MetroButton mbtnAdd;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
    }
}