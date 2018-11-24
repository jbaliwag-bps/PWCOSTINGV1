namespace PWCOSTINGV1.Forms
{
    partial class frmMT_Assy
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
            this.mcbLocked = new MetroFramework.Controls.MetroCheckBox();
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.mbtnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtxtPartName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtxtPartNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtxtHC = new MetroFramework.Controls.MetroTextBox();
            this.mtxtRatePerHour = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mtxtQty = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // mcbLocked
            // 
            this.mcbLocked.AutoSize = true;
            this.mcbLocked.Location = new System.Drawing.Point(359, 78);
            this.mcbLocked.Name = "mcbLocked";
            this.mcbLocked.Size = new System.Drawing.Size(61, 15);
            this.mcbLocked.TabIndex = 77;
            this.mcbLocked.Text = "Locked";
            this.mcbLocked.UseSelectable = true;
            this.mcbLocked.CheckedChanged += new System.EventHandler(this.mcbLocked_CheckedChanged);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.Location = new System.Drawing.Point(272, 212);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(75, 40);
            this.mbtnCancel.TabIndex = 75;
            this.mbtnCancel.Text = "C&ANCEL";
            this.mbtnCancel.UseSelectable = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // mbtnSave
            // 
            this.mbtnSave.Location = new System.Drawing.Point(195, 212);
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(75, 40);
            this.mbtnSave.TabIndex = 74;
            this.mbtnSave.Text = "Save";
            this.mbtnSave.UseSelectable = true;
            this.mbtnSave.Click += new System.EventHandler(this.mbtnSave_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(48, 180);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(92, 19);
            this.metroLabel4.TabIndex = 72;
            this.metroLabel4.Text = "Rate Per Hour";
            // 
            // mtxtPartName
            // 
            this.mtxtPartName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtPartName.CustomButton.Image = null;
            this.mtxtPartName.CustomButton.Location = new System.Drawing.Point(429, 1);
            this.mtxtPartName.CustomButton.Name = "";
            this.mtxtPartName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPartName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPartName.CustomButton.TabIndex = 1;
            this.mtxtPartName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPartName.CustomButton.UseSelectable = true;
            this.mtxtPartName.CustomButton.Visible = false;
            this.mtxtPartName.Lines = new string[0];
            this.mtxtPartName.Location = new System.Drawing.Point(195, 96);
            this.mtxtPartName.MaxLength = 50;
            this.mtxtPartName.Name = "mtxtPartName";
            this.mtxtPartName.PasswordChar = '\0';
            this.mtxtPartName.PromptText = "Part Name";
            this.mtxtPartName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPartName.SelectedText = "";
            this.mtxtPartName.SelectionLength = 0;
            this.mtxtPartName.SelectionStart = 0;
            this.mtxtPartName.ShortcutsEnabled = true;
            this.mtxtPartName.Size = new System.Drawing.Size(451, 23);
            this.mtxtPartName.TabIndex = 71;
            this.mtxtPartName.UseSelectable = true;
            this.mtxtPartName.WaterMark = "Part Name";
            this.mtxtPartName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPartName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(48, 96);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 70;
            this.metroLabel2.Text = "Name";
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
            this.mtxtPartNo.Location = new System.Drawing.Point(195, 74);
            this.mtxtPartNo.MaxLength = 10;
            this.mtxtPartNo.Name = "mtxtPartNo";
            this.mtxtPartNo.PasswordChar = '\0';
            this.mtxtPartNo.PromptText = "Part No.";
            this.mtxtPartNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPartNo.SelectedText = "";
            this.mtxtPartNo.SelectionLength = 0;
            this.mtxtPartNo.SelectionStart = 0;
            this.mtxtPartNo.ShortcutsEnabled = true;
            this.mtxtPartNo.Size = new System.Drawing.Size(155, 23);
            this.mtxtPartNo.TabIndex = 69;
            this.mtxtPartNo.UseSelectable = true;
            this.mtxtPartNo.WaterMark = "Part No.";
            this.mtxtPartNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPartNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(48, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(30, 19);
            this.metroLabel1.TabIndex = 68;
            this.metroLabel1.Text = "No.";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(48, 125);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(32, 19);
            this.metroLabel3.TabIndex = 78;
            this.metroLabel3.Text = "H/C";
            // 
            // mtxtHC
            // 
            // 
            // 
            // 
            this.mtxtHC.CustomButton.Image = null;
            this.mtxtHC.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.mtxtHC.CustomButton.Name = "";
            this.mtxtHC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtHC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtHC.CustomButton.TabIndex = 1;
            this.mtxtHC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtHC.CustomButton.UseSelectable = true;
            this.mtxtHC.CustomButton.Visible = false;
            this.mtxtHC.Lines = new string[0];
            this.mtxtHC.Location = new System.Drawing.Point(195, 125);
            this.mtxtHC.MaxLength = 10;
            this.mtxtHC.Name = "mtxtHC";
            this.mtxtHC.PasswordChar = '\0';
            this.mtxtHC.PromptText = "0";
            this.mtxtHC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtHC.SelectedText = "";
            this.mtxtHC.SelectionLength = 0;
            this.mtxtHC.SelectionStart = 0;
            this.mtxtHC.ShortcutsEnabled = true;
            this.mtxtHC.Size = new System.Drawing.Size(155, 23);
            this.mtxtHC.TabIndex = 80;
            this.mtxtHC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtHC.UseSelectable = true;
            this.mtxtHC.WaterMark = "0";
            this.mtxtHC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtHC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtHC.TextChanged += new System.EventHandler(this.mtxtHC_TextChanged);
            this.mtxtHC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtHC_KeyPress);
            // 
            // mtxtRatePerHour
            // 
            this.mtxtRatePerHour.AllowDrop = true;
            // 
            // 
            // 
            this.mtxtRatePerHour.CustomButton.Image = null;
            this.mtxtRatePerHour.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.mtxtRatePerHour.CustomButton.Name = "";
            this.mtxtRatePerHour.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtRatePerHour.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtRatePerHour.CustomButton.TabIndex = 1;
            this.mtxtRatePerHour.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtRatePerHour.CustomButton.UseSelectable = true;
            this.mtxtRatePerHour.CustomButton.Visible = false;
            this.mtxtRatePerHour.Lines = new string[0];
            this.mtxtRatePerHour.Location = new System.Drawing.Point(195, 176);
            this.mtxtRatePerHour.MaxLength = 10;
            this.mtxtRatePerHour.Name = "mtxtRatePerHour";
            this.mtxtRatePerHour.PasswordChar = '\0';
            this.mtxtRatePerHour.PromptText = "0";
            this.mtxtRatePerHour.ReadOnly = true;
            this.mtxtRatePerHour.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtRatePerHour.SelectedText = "";
            this.mtxtRatePerHour.SelectionLength = 0;
            this.mtxtRatePerHour.SelectionStart = 0;
            this.mtxtRatePerHour.ShortcutsEnabled = true;
            this.mtxtRatePerHour.Size = new System.Drawing.Size(155, 23);
            this.mtxtRatePerHour.TabIndex = 73;
            this.mtxtRatePerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtRatePerHour.UseSelectable = true;
            this.mtxtRatePerHour.WaterMark = "0";
            this.mtxtRatePerHour.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtRatePerHour.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtRatePerHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtRatePerHour_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(48, 151);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(30, 19);
            this.metroLabel5.TabIndex = 82;
            this.metroLabel5.Text = "Qty";
            // 
            // mtxtQty
            // 
            // 
            // 
            // 
            this.mtxtQty.CustomButton.Image = null;
            this.mtxtQty.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.mtxtQty.CustomButton.Name = "";
            this.mtxtQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtQty.CustomButton.TabIndex = 1;
            this.mtxtQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtQty.CustomButton.UseSelectable = true;
            this.mtxtQty.CustomButton.Visible = false;
            this.mtxtQty.Lines = new string[0];
            this.mtxtQty.Location = new System.Drawing.Point(195, 147);
            this.mtxtQty.MaxLength = 10;
            this.mtxtQty.Name = "mtxtQty";
            this.mtxtQty.PasswordChar = '\0';
            this.mtxtQty.PromptText = "0";
            this.mtxtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtQty.SelectedText = "";
            this.mtxtQty.SelectionLength = 0;
            this.mtxtQty.SelectionStart = 0;
            this.mtxtQty.ShortcutsEnabled = true;
            this.mtxtQty.Size = new System.Drawing.Size(155, 23);
            this.mtxtQty.TabIndex = 83;
            this.mtxtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtQty.UseSelectable = true;
            this.mtxtQty.WaterMark = "0";
            this.mtxtQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtQty.TextChanged += new System.EventHandler(this.mtxtQty_TextChanged);
            this.mtxtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtQty_KeyPress);
            // 
            // frmMT_Assy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 269);
            this.Controls.Add(this.mtxtQty);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.mtxtHC);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mcbLocked);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mbtnSave);
            this.Controls.Add(this.mtxtRatePerHour);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mtxtPartName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtxtPartNo);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMT_Assy";
            this.Resizable = false;
            this.Text = "MT: Assembly";
            this.Load += new System.EventHandler(this.frmMT_Assy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox mcbLocked;
        private MetroFramework.Controls.MetroButton mbtnCancel;
        private MetroFramework.Controls.MetroButton mbtnSave;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mtxtPartName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtxtPartNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mtxtHC;
        private MetroFramework.Controls.MetroTextBox mtxtRatePerHour;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox mtxtQty;
    }
}