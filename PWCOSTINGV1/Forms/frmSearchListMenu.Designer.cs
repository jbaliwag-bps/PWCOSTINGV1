namespace PWCOSTINGV1.Forms
{
    partial class frmSearchListMenu
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
            this.mgMenuList = new MetroFramework.Controls.MetroGrid();
            this.colCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMenuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mchkSelectAll = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.mgMenuList)).BeginInit();
            this.SuspendLayout();
            // 
            // mgMenuList
            // 
            this.mgMenuList.AllowUserToAddRows = false;
            this.mgMenuList.AllowUserToDeleteRows = false;
            this.mgMenuList.AllowUserToResizeRows = false;
            this.mgMenuList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mgMenuList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgMenuList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgMenuList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgMenuList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgMenuList.ColumnHeadersHeight = 25;
            this.mgMenuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mgMenuList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheckBox,
            this.colMenuID,
            this.colMenuName,
            this.colParentName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgMenuList.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgMenuList.EnableHeadersVisualStyles = false;
            this.mgMenuList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgMenuList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgMenuList.Location = new System.Drawing.Point(17, 63);
            this.mgMenuList.Name = "mgMenuList";
            this.mgMenuList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgMenuList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgMenuList.RowHeadersWidth = 25;
            this.mgMenuList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgMenuList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgMenuList.Size = new System.Drawing.Size(723, 245);
            this.mgMenuList.TabIndex = 0;
            // 
            // colCheckBox
            // 
            this.colCheckBox.DataPropertyName = "Selected";
            this.colCheckBox.HeaderText = "";
            this.colCheckBox.MinimumWidth = 50;
            this.colCheckBox.Name = "colCheckBox";
            this.colCheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCheckBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCheckBox.Width = 50;
            // 
            // colMenuID
            // 
            this.colMenuID.DataPropertyName = "MenuID";
            this.colMenuID.HeaderText = "ID";
            this.colMenuID.MinimumWidth = 80;
            this.colMenuID.Name = "colMenuID";
            this.colMenuID.ReadOnly = true;
            this.colMenuID.Width = 80;
            // 
            // colMenuName
            // 
            this.colMenuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMenuName.DataPropertyName = "MenuName";
            this.colMenuName.HeaderText = "Name";
            this.colMenuName.MinimumWidth = 100;
            this.colMenuName.Name = "colMenuName";
            this.colMenuName.ReadOnly = true;
            // 
            // colParentName
            // 
            this.colParentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colParentName.DataPropertyName = "ParentName";
            this.colParentName.HeaderText = "Parent Name";
            this.colParentName.MinimumWidth = 100;
            this.colParentName.Name = "colParentName";
            this.colParentName.ReadOnly = true;
            // 
            // mchkSelectAll
            // 
            this.mchkSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mchkSelectAll.AutoSize = true;
            this.mchkSelectAll.Location = new System.Drawing.Point(17, 317);
            this.mchkSelectAll.Name = "mchkSelectAll";
            this.mchkSelectAll.Size = new System.Drawing.Size(71, 15);
            this.mchkSelectAll.TabIndex = 1;
            this.mchkSelectAll.Text = "Select All";
            this.mchkSelectAll.UseSelectable = true;
            this.mchkSelectAll.CheckedChanged += new System.EventHandler(this.mchkSelectAll_CheckedChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(584, 317);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 35);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "A&DD";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.Location = new System.Drawing.Point(665, 317);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 35);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "C&ANCEL";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // frmSearchListMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 375);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.mchkSelectAll);
            this.Controls.Add(this.mgMenuList);
            this.Name = "frmSearchListMenu";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Search Menu List";
            this.Load += new System.EventHandler(this.frmSearchListMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgMenuList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mgMenuList;
        private MetroFramework.Controls.MetroCheckBox mchkSelectAll;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParentName;

    }
}