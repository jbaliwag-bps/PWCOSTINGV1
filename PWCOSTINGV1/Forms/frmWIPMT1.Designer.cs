namespace PWCOSTINGV1.Forms
{
    partial class frmWIPMT1
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
            this.mtxtUsage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.mtxtPartNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtxtPartName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtxtProcess = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtxtVendor = new MetroFramework.Controls.MetroTextBox();
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.mbtnSave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mtxtUsage
            // 
            // 
            // 
            // 
            this.mtxtUsage.CustomButton.Image = null;
            this.mtxtUsage.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.mtxtUsage.CustomButton.Name = "";
            this.mtxtUsage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtUsage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUsage.CustomButton.TabIndex = 1;
            this.mtxtUsage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUsage.CustomButton.UseSelectable = true;
            this.mtxtUsage.CustomButton.Visible = false;
            this.mtxtUsage.Lines = new string[] {
        "0"};
            this.mtxtUsage.Location = new System.Drawing.Point(233, 132);
            this.mtxtUsage.MaxLength = 10;
            this.mtxtUsage.Name = "mtxtUsage";
            this.mtxtUsage.PasswordChar = '\0';
            this.mtxtUsage.PromptText = "0";
            this.mtxtUsage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUsage.SelectedText = "";
            this.mtxtUsage.SelectionLength = 0;
            this.mtxtUsage.SelectionStart = 0;
            this.mtxtUsage.ShortcutsEnabled = true;
            this.mtxtUsage.Size = new System.Drawing.Size(155, 23);
            this.mtxtUsage.TabIndex = 72;
            this.mtxtUsage.Text = "0";
            this.mtxtUsage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtUsage.UseSelectable = true;
            this.mtxtUsage.WaterMark = "0";
            this.mtxtUsage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUsage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtUsage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtUsage_KeyPress);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(44, 132);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(45, 19);
            this.metroLabel8.TabIndex = 71;
            this.metroLabel8.Text = "Usage";
            // 
            // mtxtPartNo
            // 
            // 
            // 
            // 
            this.mtxtPartNo.CustomButton.Image = null;
            this.mtxtPartNo.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.mtxtPartNo.CustomButton.Name = "";
            this.mtxtPartNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPartNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPartNo.CustomButton.TabIndex = 1;
            this.mtxtPartNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPartNo.CustomButton.UseSelectable = true;
            this.mtxtPartNo.CustomButton.Visible = false;
            this.mtxtPartNo.Lines = new string[0];
            this.mtxtPartNo.Location = new System.Drawing.Point(233, 73);
            this.mtxtPartNo.MaxLength = 50;
            this.mtxtPartNo.Name = "mtxtPartNo";
            this.mtxtPartNo.PasswordChar = '\0';
            this.mtxtPartNo.PromptText = "Part No.";
            this.mtxtPartNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPartNo.SelectedText = "";
            this.mtxtPartNo.SelectionLength = 0;
            this.mtxtPartNo.SelectionStart = 0;
            this.mtxtPartNo.ShortcutsEnabled = true;
            this.mtxtPartNo.Size = new System.Drawing.Size(155, 23);
            this.mtxtPartNo.TabIndex = 74;
            this.mtxtPartNo.UseSelectable = true;
            this.mtxtPartNo.WaterMark = "Part No.";
            this.mtxtPartNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPartNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(44, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(30, 19);
            this.metroLabel1.TabIndex = 73;
            this.metroLabel1.Text = "No.";
            // 
            // mtxtPartName
            // 
            this.mtxtPartName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtPartName.CustomButton.Image = null;
            this.mtxtPartName.CustomButton.Location = new System.Drawing.Point(426, 1);
            this.mtxtPartName.CustomButton.Name = "";
            this.mtxtPartName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPartName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPartName.CustomButton.TabIndex = 1;
            this.mtxtPartName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPartName.CustomButton.UseSelectable = true;
            this.mtxtPartName.CustomButton.Visible = false;
            this.mtxtPartName.Lines = new string[0];
            this.mtxtPartName.Location = new System.Drawing.Point(233, 102);
            this.mtxtPartName.MaxLength = 50;
            this.mtxtPartName.Name = "mtxtPartName";
            this.mtxtPartName.PasswordChar = '\0';
            this.mtxtPartName.PromptText = "Part Name";
            this.mtxtPartName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPartName.SelectedText = "";
            this.mtxtPartName.SelectionLength = 0;
            this.mtxtPartName.SelectionStart = 0;
            this.mtxtPartName.ShortcutsEnabled = true;
            this.mtxtPartName.Size = new System.Drawing.Size(448, 23);
            this.mtxtPartName.TabIndex = 76;
            this.mtxtPartName.UseSelectable = true;
            this.mtxtPartName.WaterMark = "Part Name";
            this.mtxtPartName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPartName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(44, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 75;
            this.metroLabel2.Text = "Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(44, 190);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 77;
            this.metroLabel3.Text = "Vendor";
            // 
            // mtxtProcess
            // 
            // 
            // 
            // 
            this.mtxtProcess.CustomButton.Image = null;
            this.mtxtProcess.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.mtxtProcess.CustomButton.Name = "";
            this.mtxtProcess.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtProcess.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtProcess.CustomButton.TabIndex = 1;
            this.mtxtProcess.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtProcess.CustomButton.UseSelectable = true;
            this.mtxtProcess.CustomButton.Visible = false;
            this.mtxtProcess.Lines = new string[0];
            this.mtxtProcess.Location = new System.Drawing.Point(233, 161);
            this.mtxtProcess.MaxLength = 10;
            this.mtxtProcess.Name = "mtxtProcess";
            this.mtxtProcess.PasswordChar = '\0';
            this.mtxtProcess.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtProcess.SelectedText = "";
            this.mtxtProcess.SelectionLength = 0;
            this.mtxtProcess.SelectionStart = 0;
            this.mtxtProcess.ShortcutsEnabled = true;
            this.mtxtProcess.Size = new System.Drawing.Size(155, 23);
            this.mtxtProcess.TabIndex = 80;
            this.mtxtProcess.UseSelectable = true;
            this.mtxtProcess.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtProcess.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(44, 161);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(53, 19);
            this.metroLabel4.TabIndex = 79;
            this.metroLabel4.Text = "Process";
            // 
            // mtxtVendor
            // 
            // 
            // 
            // 
            this.mtxtVendor.CustomButton.Image = null;
            this.mtxtVendor.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.mtxtVendor.CustomButton.Name = "";
            this.mtxtVendor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtVendor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtVendor.CustomButton.TabIndex = 1;
            this.mtxtVendor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtVendor.CustomButton.UseSelectable = true;
            this.mtxtVendor.CustomButton.Visible = false;
            this.mtxtVendor.Lines = new string[0];
            this.mtxtVendor.Location = new System.Drawing.Point(233, 190);
            this.mtxtVendor.MaxLength = 10;
            this.mtxtVendor.Name = "mtxtVendor";
            this.mtxtVendor.PasswordChar = '\0';
            this.mtxtVendor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtVendor.SelectedText = "";
            this.mtxtVendor.SelectionLength = 0;
            this.mtxtVendor.SelectionStart = 0;
            this.mtxtVendor.ShortcutsEnabled = true;
            this.mtxtVendor.Size = new System.Drawing.Size(155, 23);
            this.mtxtVendor.TabIndex = 78;
            this.mtxtVendor.UseSelectable = true;
            this.mtxtVendor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtVendor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.Location = new System.Drawing.Point(311, 232);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(75, 40);
            this.mbtnCancel.TabIndex = 82;
            this.mbtnCancel.Text = "C&ANCEL";
            this.mbtnCancel.UseSelectable = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // mbtnSave
            // 
            this.mbtnSave.Location = new System.Drawing.Point(234, 232);
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(75, 40);
            this.mbtnSave.TabIndex = 81;
            this.mbtnSave.Text = "Save";
            this.mbtnSave.UseSelectable = true;
            this.mbtnSave.Click += new System.EventHandler(this.mbtnSave_Click);
            // 
            // frmWIPMT1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 315);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mbtnSave);
            this.Controls.Add(this.mtxtProcess);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mtxtVendor);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtxtPartName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtxtPartNo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtxtUsage);
            this.Controls.Add(this.metroLabel8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWIPMT1";
            this.Resizable = false;
            this.Text = "MT";
            this.Load += new System.EventHandler(this.frmWIPMT1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mtxtUsage;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox mtxtPartNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtxtPartName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mtxtProcess;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mtxtVendor;
        private MetroFramework.Controls.MetroButton mbtnCancel;
        private MetroFramework.Controls.MetroButton mbtnSave;

    }
}