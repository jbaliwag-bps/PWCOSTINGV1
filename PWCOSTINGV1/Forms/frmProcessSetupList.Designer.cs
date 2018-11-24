namespace PWCOSTINGV1.Forms
{
    partial class frmProcessSetup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mcboDefaults = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.mbtnCopyPrev = new MetroFramework.Controls.MetroButton();
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.mbtnSave = new MetroFramework.Controls.MetroButton();
            this.colImportBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsImported = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCopyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsCopied = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeactivatedNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeactivatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCavity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSP_HC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProcessCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubProcessCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYEARUSED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelProcess = new System.Windows.Forms.DataGridViewImageColumn();
            this.mgridList = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.mgridList)).BeginInit();
            this.SuspendLayout();
            // 
            // mcboDefaults
            // 
            this.mcboDefaults.FormattingEnabled = true;
            this.mcboDefaults.ItemHeight = 23;
            this.mcboDefaults.Location = new System.Drawing.Point(150, 70);
            this.mcboDefaults.Name = "mcboDefaults";
            this.mcboDefaults.Size = new System.Drawing.Size(226, 29);
            this.mcboDefaults.TabIndex = 70;
            this.mcboDefaults.UseSelectable = true;
            this.mcboDefaults.SelectedIndexChanged += new System.EventHandler(this.mcboDefaults_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(82, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 71;
            this.metroLabel1.Text = "Process";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::PWCOSTINGV1.Properties.Resources.deleteicon;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 20;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Transparent;
            this.metroButton2.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.imp_exc_icon;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton2.Location = new System.Drawing.Point(781, 59);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(40, 40);
            this.metroButton2.TabIndex = 74;
            this.metroButton2.Text = " ";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // mbtnCopyPrev
            // 
            this.mbtnCopyPrev.BackColor = System.Drawing.Color.Transparent;
            this.mbtnCopyPrev.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.copy_prev_icon;
            this.mbtnCopyPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnCopyPrev.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.mbtnCopyPrev.Location = new System.Drawing.Point(737, 59);
            this.mbtnCopyPrev.Name = "mbtnCopyPrev";
            this.mbtnCopyPrev.Size = new System.Drawing.Size(40, 40);
            this.mbtnCopyPrev.TabIndex = 73;
            this.mbtnCopyPrev.Text = " ";
            this.mbtnCopyPrev.UseSelectable = true;
            this.mbtnCopyPrev.Click += new System.EventHandler(this.mbtnCopyPrev_Click);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.mbtnCancel.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.cancelicon;
            this.mbtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnCancel.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.mbtnCancel.Location = new System.Drawing.Point(869, 59);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(40, 40);
            this.mbtnCancel.TabIndex = 69;
            this.mbtnCancel.Text = " ";
            this.mbtnCancel.UseSelectable = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // mbtnSave
            // 
            this.mbtnSave.BackColor = System.Drawing.Color.Transparent;
            this.mbtnSave.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.editicon;
            this.mbtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnSave.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.mbtnSave.Location = new System.Drawing.Point(825, 59);
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(40, 40);
            this.mbtnSave.TabIndex = 68;
            this.mbtnSave.Text = " ";
            this.mbtnSave.UseSelectable = true;
            this.mbtnSave.Click += new System.EventHandler(this.mbtnSave_Click);
            // 
            // colImportBy
            // 
            this.colImportBy.DataPropertyName = "ImportBy";
            this.colImportBy.HeaderText = "ImportBy";
            this.colImportBy.Name = "colImportBy";
            this.colImportBy.Visible = false;
            // 
            // colImportDate
            // 
            this.colImportDate.DataPropertyName = "ImportDate";
            this.colImportDate.HeaderText = "ImportDate";
            this.colImportDate.Name = "colImportDate";
            this.colImportDate.Visible = false;
            // 
            // colIsImported
            // 
            this.colIsImported.DataPropertyName = "IsImported";
            this.colIsImported.HeaderText = "IsImported";
            this.colIsImported.Name = "colIsImported";
            this.colIsImported.Visible = false;
            // 
            // colCopyDate
            // 
            this.colCopyDate.DataPropertyName = "CopyDate";
            this.colCopyDate.HeaderText = "CopyDate";
            this.colCopyDate.Name = "colCopyDate";
            this.colCopyDate.Visible = false;
            // 
            // colIsCopied
            // 
            this.colIsCopied.DataPropertyName = "IsCopied";
            this.colIsCopied.HeaderText = "IsCopied";
            this.colIsCopied.Name = "colIsCopied";
            this.colIsCopied.Visible = false;
            // 
            // colUpdatedBy
            // 
            this.colUpdatedBy.DataPropertyName = "UpdatedBy";
            this.colUpdatedBy.HeaderText = "UpdatedBy";
            this.colUpdatedBy.Name = "colUpdatedBy";
            this.colUpdatedBy.Visible = false;
            // 
            // colUpdatedDate
            // 
            this.colUpdatedDate.DataPropertyName = "UpdatedDate";
            this.colUpdatedDate.HeaderText = "UpdatedDate";
            this.colUpdatedDate.Name = "colUpdatedDate";
            this.colUpdatedDate.Visible = false;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.DataPropertyName = "CreatedBy";
            this.colCreatedBy.HeaderText = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.Visible = false;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.DataPropertyName = "CreatedDate";
            this.colCreatedDate.HeaderText = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.Visible = false;
            // 
            // colDeactivatedNote
            // 
            this.colDeactivatedNote.DataPropertyName = "DeactivatedNote";
            this.colDeactivatedNote.HeaderText = "DeactivatedNote";
            this.colDeactivatedNote.Name = "colDeactivatedNote";
            this.colDeactivatedNote.Visible = false;
            // 
            // colDeactivatedDate
            // 
            this.colDeactivatedDate.DataPropertyName = "DeactivatedDate";
            this.colDeactivatedDate.HeaderText = "DeactivatedDate";
            this.colDeactivatedDate.Name = "colDeactivatedDate";
            this.colDeactivatedDate.Visible = false;
            // 
            // colIsActive
            // 
            this.colIsActive.DataPropertyName = "IsActive";
            this.colIsActive.HeaderText = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = false;
            // 
            // colRemarks
            // 
            this.colRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemarks.DataPropertyName = "Remarks";
            this.colRemarks.HeaderText = "Remarks";
            this.colRemarks.Name = "colRemarks";
            // 
            // colCavity
            // 
            this.colCavity.DataPropertyName = "StandardB";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.colCavity.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCavity.HeaderText = "Cavity/ PH";
            this.colCavity.Name = "colCavity";
            // 
            // colSP_HC
            // 
            this.colSP_HC.DataPropertyName = "StandardA";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.colSP_HC.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSP_HC.HeaderText = "SP/ HC";
            this.colSP_HC.Name = "colSP_HC";
            // 
            // colItemDesc
            // 
            this.colItemDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItemDesc.DataPropertyName = "ItemDescription";
            this.colItemDesc.HeaderText = "Description";
            this.colItemDesc.MinimumWidth = 150;
            this.colItemDesc.Name = "colItemDesc";
            // 
            // colProcessCode
            // 
            this.colProcessCode.DataPropertyName = "ProcessCode";
            this.colProcessCode.HeaderText = "ProcessCode";
            this.colProcessCode.Name = "colProcessCode";
            this.colProcessCode.Visible = false;
            // 
            // colSubProcessCode
            // 
            this.colSubProcessCode.DataPropertyName = "SubProcessCode";
            this.colSubProcessCode.HeaderText = "Code";
            this.colSubProcessCode.MinimumWidth = 100;
            this.colSubProcessCode.Name = "colSubProcessCode";
            this.colSubProcessCode.ReadOnly = true;
            // 
            // colYEARUSED
            // 
            this.colYEARUSED.DataPropertyName = "YEARUSED";
            this.colYEARUSED.HeaderText = "YEARUSED";
            this.colYEARUSED.Name = "colYEARUSED";
            this.colYEARUSED.Visible = false;
            // 
            // colRecID
            // 
            this.colRecID.DataPropertyName = "RecID";
            this.colRecID.HeaderText = "Rec ID";
            this.colRecID.Name = "colRecID";
            this.colRecID.Visible = false;
            // 
            // colDelProcess
            // 
            this.colDelProcess.HeaderText = "";
            this.colDelProcess.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.colDelProcess.Name = "colDelProcess";
            this.colDelProcess.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDelProcess.Width = 20;
            // 
            // mgridList
            // 
            this.mgridList.AllowUserToDeleteRows = false;
            this.mgridList.AllowUserToResizeRows = false;
            this.mgridList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgridList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgridList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgridList.ColumnHeadersHeight = 25;
            this.mgridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mgridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDelProcess,
            this.colRecID,
            this.colYEARUSED,
            this.colSubProcessCode,
            this.colProcessCode,
            this.colItemDesc,
            this.colSP_HC,
            this.colCavity,
            this.colRemarks,
            this.colIsActive,
            this.colDeactivatedDate,
            this.colDeactivatedNote,
            this.colCreatedDate,
            this.colCreatedBy,
            this.colUpdatedDate,
            this.colUpdatedBy,
            this.colIsCopied,
            this.colCopyDate,
            this.colIsImported,
            this.colImportDate,
            this.colImportBy});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgridList.DefaultCellStyle = dataGridViewCellStyle4;
            this.mgridList.EnableHeadersVisualStyles = false;
            this.mgridList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgridList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridList.Location = new System.Drawing.Point(20, 115);
            this.mgridList.Name = "mgridList";
            this.mgridList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.mgridList.RowHeadersWidth = 25;
            this.mgridList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgridList.Size = new System.Drawing.Size(893, 536);
            this.mgridList.TabIndex = 72;
            this.mgridList.Tag = "";
            this.mgridList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgridList_CellClick);
            this.mgridList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgridList_CellEndEdit);
            this.mgridList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.mgridList_DataError);
            this.mgridList.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.mgridList_EditingControlShowing);
            // 
            // frmProcessSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.mbtnCopyPrev);
            this.Controls.Add(this.mgridList);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mcboDefaults);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mbtnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcessSetup";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Tag = "list";
            this.Text = "Process Setup";
            this.Load += new System.EventHandler(this.frmProcessSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mbtnCancel;
        private MetroFramework.Controls.MetroButton mbtnSave;
        private MetroFramework.Controls.MetroComboBox mcboDefaults;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton mbtnCopyPrev;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImportBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsImported;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCopyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsCopied;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeactivatedNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeactivatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCavity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSP_HC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProcessCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubProcessCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYEARUSED;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecID;
        private System.Windows.Forms.DataGridViewImageColumn colDelProcess;
        private MetroFramework.Controls.MetroGrid mgridList;

    }
}