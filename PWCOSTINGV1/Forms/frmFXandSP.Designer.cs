namespace PWCOSTINGV1.Forms
{
    partial class frmFXandSP
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
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.mbtnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mcboType = new MetroFramework.Controls.MetroComboBox();
            this.mdtpEffectiveDate = new MetroFramework.Controls.MetroDateTime();
            this.mtxtRate = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.Location = new System.Drawing.Point(294, 163);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(75, 40);
            this.mbtnCancel.TabIndex = 50;
            this.mbtnCancel.Text = "C&ANCEL";
            this.mbtnCancel.UseSelectable = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // mbtnSave
            // 
            this.mbtnSave.Location = new System.Drawing.Point(217, 163);
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(75, 40);
            this.mbtnSave.TabIndex = 49;
            this.mbtnSave.Text = "Save";
            this.mbtnSave.UseSelectable = true;
            this.mbtnSave.Click += new System.EventHandler(this.mbtnSave_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(64, 130);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(35, 19);
            this.metroLabel5.TabIndex = 53;
            this.metroLabel5.Text = "Rate";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(64, 102);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 52;
            this.metroLabel3.Text = "Effective Date";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(64, 74);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.TabIndex = 51;
            this.metroLabel4.Text = "Type";
            // 
            // mcboType
            // 
            this.mcboType.FormattingEnabled = true;
            this.mcboType.ItemHeight = 23;
            this.mcboType.Items.AddRange(new object[] {
            "FX",
            "SP"});
            this.mcboType.Location = new System.Drawing.Point(217, 72);
            this.mcboType.Name = "mcboType";
            this.mcboType.Size = new System.Drawing.Size(121, 29);
            this.mcboType.TabIndex = 54;
            this.mcboType.UseSelectable = true;
            // 
            // mdtpEffectiveDate
            // 
            this.mdtpEffectiveDate.Location = new System.Drawing.Point(217, 100);
            this.mdtpEffectiveDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtpEffectiveDate.Name = "mdtpEffectiveDate";
            this.mdtpEffectiveDate.Size = new System.Drawing.Size(200, 29);
            this.mdtpEffectiveDate.TabIndex = 55;
            // 
            // mtxtRate
            // 
            // 
            // 
            // 
            this.mtxtRate.CustomButton.Image = null;
            this.mtxtRate.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.mtxtRate.CustomButton.Name = "";
            this.mtxtRate.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mtxtRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtRate.CustomButton.TabIndex = 1;
            this.mtxtRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtRate.CustomButton.UseSelectable = true;
            this.mtxtRate.CustomButton.Visible = false;
            this.mtxtRate.Lines = new string[] {
        "0.0"};
            this.mtxtRate.Location = new System.Drawing.Point(217, 128);
            this.mtxtRate.MaxLength = 32767;
            this.mtxtRate.Name = "mtxtRate";
            this.mtxtRate.PasswordChar = '\0';
            this.mtxtRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtRate.SelectedText = "";
            this.mtxtRate.SelectionLength = 0;
            this.mtxtRate.SelectionStart = 0;
            this.mtxtRate.ShortcutsEnabled = true;
            this.mtxtRate.Size = new System.Drawing.Size(121, 29);
            this.mtxtRate.TabIndex = 56;
            this.mtxtRate.Text = "0.0";
            this.mtxtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtRate.UseSelectable = true;
            this.mtxtRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtRate_KeyPress);
            // 
            // frmFXandSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 226);
            this.Controls.Add(this.mtxtRate);
            this.Controls.Add(this.mdtpEffectiveDate);
            this.Controls.Add(this.mcboType);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mbtnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFXandSP";
            this.Resizable = false;
            this.Text = "FXandSP";
            this.Load += new System.EventHandler(this.frmFXandSP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mbtnCancel;
        private MetroFramework.Controls.MetroButton mbtnSave;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox mcboType;
        private MetroFramework.Controls.MetroDateTime mdtpEffectiveDate;
        private MetroFramework.Controls.MetroTextBox mtxtRate;
    }
}