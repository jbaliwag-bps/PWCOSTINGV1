namespace PWCOSTINGV1.Forms
{
    partial class frmUserGroup
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
            this.mtxtGroupDesc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtxtGroupCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tbUserRights = new System.Windows.Forms.TabPage();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.mgridRights = new MetroFramework.Controls.MetroGrid();
            this.colUserGroupCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMenuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCanAdd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCanEdit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCanDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCanView = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCanPreview = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCanPrint = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbOthers = new System.Windows.Forms.TabPage();
            this.mtxtRemarks = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mcbActive = new MetroFramework.Controls.MetroCheckBox();
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.mbtnSave = new MetroFramework.Controls.MetroButton();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.mlblNoRecords = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.tbUserRights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgridRights)).BeginInit();
            this.tbOthers.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxtGroupDesc
            // 
            // 
            // 
            // 
            this.mtxtGroupDesc.CustomButton.Image = null;
            this.mtxtGroupDesc.CustomButton.Location = new System.Drawing.Point(460, 1);
            this.mtxtGroupDesc.CustomButton.Name = "";
            this.mtxtGroupDesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtGroupDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtGroupDesc.CustomButton.TabIndex = 1;
            this.mtxtGroupDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtGroupDesc.CustomButton.UseSelectable = true;
            this.mtxtGroupDesc.CustomButton.Visible = false;
            this.mtxtGroupDesc.Lines = new string[0];
            this.mtxtGroupDesc.Location = new System.Drawing.Point(198, 96);
            this.mtxtGroupDesc.MaxLength = 50;
            this.mtxtGroupDesc.Name = "mtxtGroupDesc";
            this.mtxtGroupDesc.PasswordChar = '\0';
            this.mtxtGroupDesc.PromptText = "Group Description";
            this.mtxtGroupDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtGroupDesc.SelectedText = "";
            this.mtxtGroupDesc.SelectionLength = 0;
            this.mtxtGroupDesc.SelectionStart = 0;
            this.mtxtGroupDesc.ShortcutsEnabled = true;
            this.mtxtGroupDesc.Size = new System.Drawing.Size(482, 23);
            this.mtxtGroupDesc.TabIndex = 7;
            this.mtxtGroupDesc.UseSelectable = true;
            this.mtxtGroupDesc.WaterMark = "Group Description";
            this.mtxtGroupDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtGroupDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(53, 96);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Description";
            // 
            // mtxtGroupCode
            // 
            // 
            // 
            // 
            this.mtxtGroupCode.CustomButton.Image = null;
            this.mtxtGroupCode.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.mtxtGroupCode.CustomButton.Name = "";
            this.mtxtGroupCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtGroupCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtGroupCode.CustomButton.TabIndex = 1;
            this.mtxtGroupCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtGroupCode.CustomButton.UseSelectable = true;
            this.mtxtGroupCode.CustomButton.Visible = false;
            this.mtxtGroupCode.Lines = new string[0];
            this.mtxtGroupCode.Location = new System.Drawing.Point(198, 74);
            this.mtxtGroupCode.MaxLength = 10;
            this.mtxtGroupCode.Name = "mtxtGroupCode";
            this.mtxtGroupCode.PasswordChar = '\0';
            this.mtxtGroupCode.PromptText = "Group Code";
            this.mtxtGroupCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtGroupCode.SelectedText = "";
            this.mtxtGroupCode.SelectionLength = 0;
            this.mtxtGroupCode.SelectionStart = 0;
            this.mtxtGroupCode.ShortcutsEnabled = true;
            this.mtxtGroupCode.Size = new System.Drawing.Size(155, 23);
            this.mtxtGroupCode.TabIndex = 5;
            this.mtxtGroupCode.UseSelectable = true;
            this.mtxtGroupCode.WaterMark = "Group Code";
            this.mtxtGroupCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtGroupCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(53, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Code";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tbUserRights);
            this.metroTabControl1.Controls.Add(this.tbOthers);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 128);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(688, 339);
            this.metroTabControl1.TabIndex = 25;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tbUserRights
            // 
            this.tbUserRights.BackColor = System.Drawing.Color.Transparent;
            this.tbUserRights.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserRights.Controls.Add(this.mlblNoRecords);
            this.tbUserRights.Controls.Add(this.metroButton2);
            this.tbUserRights.Controls.Add(this.metroButton1);
            this.tbUserRights.Controls.Add(this.mgridRights);
            this.tbUserRights.Location = new System.Drawing.Point(4, 38);
            this.tbUserRights.Name = "tbUserRights";
            this.tbUserRights.Size = new System.Drawing.Size(680, 297);
            this.tbUserRights.TabIndex = 0;
            this.tbUserRights.Text = "User Rights";
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.deleteicon;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton2.Location = new System.Drawing.Point(46, 252);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(35, 35);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = " ";
            this.metroToolTip1.SetToolTip(this.metroButton2, "Remove User Rights");
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.addicon;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton1.Location = new System.Drawing.Point(5, 252);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(35, 35);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = " ";
            this.metroToolTip1.SetToolTip(this.metroButton1, "Add User Rights");
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // mgridRights
            // 
            this.mgridRights.AllowUserToAddRows = false;
            this.mgridRights.AllowUserToDeleteRows = false;
            this.mgridRights.AllowUserToResizeRows = false;
            this.mgridRights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mgridRights.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridRights.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridRights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgridRights.ColumnHeadersHeight = 25;
            this.mgridRights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserGroupCode,
            this.colDateCreated,
            this.colMenuID,
            this.colMenuName,
            this.colCanAdd,
            this.colCanEdit,
            this.colCanDelete,
            this.colCanView,
            this.colCanPreview,
            this.colCanPrint});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgridRights.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgridRights.EnableHeadersVisualStyles = false;
            this.mgridRights.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgridRights.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridRights.Location = new System.Drawing.Point(3, 3);
            this.mgridRights.Name = "mgridRights";
            this.mgridRights.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridRights.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgridRights.RowHeadersWidth = 25;
            this.mgridRights.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgridRights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgridRights.Size = new System.Drawing.Size(671, 242);
            this.mgridRights.TabIndex = 0;
            // 
            // colUserGroupCode
            // 
            this.colUserGroupCode.DataPropertyName = "UserGroupCode";
            this.colUserGroupCode.HeaderText = "Code";
            this.colUserGroupCode.Name = "colUserGroupCode";
            this.colUserGroupCode.ReadOnly = true;
            this.colUserGroupCode.Visible = false;
            // 
            // colDateCreated
            // 
            this.colDateCreated.DataPropertyName = "DateCreated";
            this.colDateCreated.HeaderText = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Visible = false;
            // 
            // colMenuID
            // 
            this.colMenuID.DataPropertyName = "MenuID";
            this.colMenuID.HeaderText = "ID";
            this.colMenuID.MinimumWidth = 70;
            this.colMenuID.Name = "colMenuID";
            this.colMenuID.ReadOnly = true;
            this.colMenuID.Width = 70;
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
            // colCanAdd
            // 
            this.colCanAdd.DataPropertyName = "CanAdd";
            this.colCanAdd.HeaderText = "ADD";
            this.colCanAdd.MinimumWidth = 60;
            this.colCanAdd.Name = "colCanAdd";
            this.colCanAdd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCanAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCanAdd.Width = 60;
            // 
            // colCanEdit
            // 
            this.colCanEdit.DataPropertyName = "CanEdit";
            this.colCanEdit.HeaderText = "EDIT";
            this.colCanEdit.MinimumWidth = 60;
            this.colCanEdit.Name = "colCanEdit";
            this.colCanEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCanEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCanEdit.Width = 60;
            // 
            // colCanDelete
            // 
            this.colCanDelete.DataPropertyName = "CanDelete";
            this.colCanDelete.HeaderText = "DELETE";
            this.colCanDelete.MinimumWidth = 60;
            this.colCanDelete.Name = "colCanDelete";
            this.colCanDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCanDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCanDelete.Width = 60;
            // 
            // colCanView
            // 
            this.colCanView.DataPropertyName = "CanView";
            this.colCanView.HeaderText = "VIEW";
            this.colCanView.MinimumWidth = 60;
            this.colCanView.Name = "colCanView";
            this.colCanView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCanView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCanView.Width = 60;
            // 
            // colCanPreview
            // 
            this.colCanPreview.DataPropertyName = "CanPreview";
            this.colCanPreview.HeaderText = "PREVIEW";
            this.colCanPreview.MinimumWidth = 60;
            this.colCanPreview.Name = "colCanPreview";
            this.colCanPreview.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCanPreview.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCanPreview.Width = 60;
            // 
            // colCanPrint
            // 
            this.colCanPrint.DataPropertyName = "CanPrint";
            this.colCanPrint.HeaderText = "PRINT";
            this.colCanPrint.MinimumWidth = 60;
            this.colCanPrint.Name = "colCanPrint";
            this.colCanPrint.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCanPrint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCanPrint.Width = 60;
            // 
            // tbOthers
            // 
            this.tbOthers.BackColor = System.Drawing.Color.Transparent;
            this.tbOthers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOthers.Controls.Add(this.mtxtRemarks);
            this.tbOthers.Controls.Add(this.metroLabel3);
            this.tbOthers.Location = new System.Drawing.Point(4, 38);
            this.tbOthers.Name = "tbOthers";
            this.tbOthers.Size = new System.Drawing.Size(680, 297);
            this.tbOthers.TabIndex = 1;
            this.tbOthers.Text = "Others";
            // 
            // mtxtRemarks
            // 
            // 
            // 
            // 
            this.mtxtRemarks.CustomButton.Image = null;
            this.mtxtRemarks.CustomButton.Location = new System.Drawing.Point(347, 2);
            this.mtxtRemarks.CustomButton.Name = "";
            this.mtxtRemarks.CustomButton.Size = new System.Drawing.Size(67, 67);
            this.mtxtRemarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtRemarks.CustomButton.TabIndex = 1;
            this.mtxtRemarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtRemarks.CustomButton.UseSelectable = true;
            this.mtxtRemarks.CustomButton.Visible = false;
            this.mtxtRemarks.Lines = new string[0];
            this.mtxtRemarks.Location = new System.Drawing.Point(171, 16);
            this.mtxtRemarks.MaxLength = 32767;
            this.mtxtRemarks.Multiline = true;
            this.mtxtRemarks.Name = "mtxtRemarks";
            this.mtxtRemarks.PasswordChar = '\0';
            this.mtxtRemarks.PromptText = "Remarks";
            this.mtxtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtRemarks.SelectedText = "";
            this.mtxtRemarks.SelectionLength = 0;
            this.mtxtRemarks.SelectionStart = 0;
            this.mtxtRemarks.ShortcutsEnabled = true;
            this.mtxtRemarks.Size = new System.Drawing.Size(417, 72);
            this.mtxtRemarks.TabIndex = 1;
            this.mtxtRemarks.UseSelectable = true;
            this.mtxtRemarks.WaterMark = "Remarks";
            this.mtxtRemarks.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtRemarks.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.Location = new System.Drawing.Point(30, 21);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Remarks";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // mcbActive
            // 
            this.mcbActive.AutoSize = true;
            this.mcbActive.Location = new System.Drawing.Point(371, 78);
            this.mcbActive.Name = "mcbActive";
            this.mcbActive.Size = new System.Drawing.Size(56, 15);
            this.mcbActive.TabIndex = 54;
            this.mcbActive.Text = "Active";
            this.mcbActive.UseSelectable = true;
            this.mcbActive.CheckedChanged += new System.EventHandler(this.mcbActive_CheckedChanged);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.mbtnCancel.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.cancelicon;
            this.mbtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnCancel.Location = new System.Drawing.Point(667, 25);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(40, 40);
            this.mbtnCancel.TabIndex = 56;
            this.mbtnCancel.Text = " ";
            this.metroToolTip1.SetToolTip(this.mbtnCancel, "Cancel");
            this.mbtnCancel.UseSelectable = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // mbtnSave
            // 
            this.mbtnSave.BackColor = System.Drawing.Color.Transparent;
            this.mbtnSave.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.saveicon1;
            this.mbtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnSave.Location = new System.Drawing.Point(621, 25);
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(40, 40);
            this.mbtnSave.TabIndex = 55;
            this.mbtnSave.Text = " ";
            this.metroToolTip1.SetToolTip(this.mbtnSave, "Save User Group");
            this.mbtnSave.UseSelectable = true;
            this.mbtnSave.Click += new System.EventHandler(this.mbtnSave_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mlblNoRecords
            // 
            this.mlblNoRecords.AutoSize = true;
            this.mlblNoRecords.Location = new System.Drawing.Point(87, 252);
            this.mlblNoRecords.Name = "mlblNoRecords";
            this.mlblNoRecords.Size = new System.Drawing.Size(94, 19);
            this.mlblNoRecords.TabIndex = 5;
            this.mlblNoRecords.Text = "No. of records";
            // 
            // frmUserGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(734, 497);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mbtnSave);
            this.Controls.Add(this.mcbActive);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.mtxtGroupDesc);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtxtGroupCode);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserGroup";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "User Group";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.frmUserProfile_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tbUserRights.ResumeLayout(false);
            this.tbUserRights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgridRights)).EndInit();
            this.tbOthers.ResumeLayout(false);
            this.tbOthers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mtxtGroupDesc;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtxtGroupCode;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tbUserRights;
        private System.Windows.Forms.TabPage tbOthers;
        private MetroFramework.Controls.MetroTextBox mtxtRemarks;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroCheckBox mcbActive;
        private MetroFramework.Controls.MetroButton mbtnCancel;
        private MetroFramework.Controls.MetroButton mbtnSave;
        private MetroFramework.Controls.MetroGrid mgridRights;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserGroupCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenuName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCanAdd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCanEdit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCanDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCanView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCanPreview;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCanPrint;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroLabel mlblNoRecords;
    }
}