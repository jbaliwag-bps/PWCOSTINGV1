namespace PWCOSTINGV1.Forms
{
    partial class frmExistingItemLoad
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.mgridList = new MetroFramework.Controls.MetroGrid();
            this.colDocIDCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colchkSelection = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mgridList)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(325, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Please select item to load with it\'s corresponding year.";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(312, 204);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Cancel";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
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
            this.colDocIDCL,
            this.colItemNo,
            this.colchkSelection});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgridList.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgridList.EnableHeadersVisualStyles = false;
            this.mgridList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgridList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridList.Location = new System.Drawing.Point(35, 78);
            this.mgridList.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.mgridList.Name = "mgridList";
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
            this.mgridList.Size = new System.Drawing.Size(352, 113);
            this.mgridList.TabIndex = 19;
            this.mgridList.Tag = "";
            this.mgridList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgridList_CellContentClick);
            // 
            // colDocIDCL
            // 
            this.colDocIDCL.DataPropertyName = "YEARUSED";
            this.colDocIDCL.HeaderText = "Year";
            this.colDocIDCL.MinimumWidth = 70;
            this.colDocIDCL.Name = "colDocIDCL";
            this.colDocIDCL.Width = 70;
            // 
            // colItemNo
            // 
            this.colItemNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItemNo.DataPropertyName = "ItemNo";
            this.colItemNo.HeaderText = "Item No.";
            this.colItemNo.Name = "colItemNo";
            // 
            // colchkSelection
            // 
            this.colchkSelection.DataPropertyName = "Selection";
            this.colchkSelection.HeaderText = "Selection";
            this.colchkSelection.Name = "colchkSelection";
            this.colchkSelection.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colchkSelection.Text = "";
            // 
            // frmExistingItemLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 242);
            this.Controls.Add(this.mgridList);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "frmExistingItemLoad";
            this.Resizable = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmExistingItemLoad_FormClosed);
            this.Load += new System.EventHandler(this.frmExistingItemLoad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        public MetroFramework.Controls.MetroGrid mgridList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocIDCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemNo;
        private System.Windows.Forms.DataGridViewButtonColumn colchkSelection;
    }
}