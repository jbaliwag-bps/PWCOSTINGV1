namespace PWCOSTINGV1.Forms
{
    partial class frm_Copier
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
            this.mlblInstruction = new MetroFramework.Controls.MetroLabel();
            this.mtxtItemNo = new MetroFramework.Controls.MetroTextBox();
            this.mbtnViewList = new MetroFramework.Controls.MetroButton();
            this.mtxtItemDesc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mlblItemNo = new MetroFramework.Controls.MetroLabel();
            this.mtxtCurLogYear = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mcbOverWrite = new MetroFramework.Controls.MetroCheckBox();
            this.mcboYear = new MetroFramework.Controls.MetroComboBox();
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.mbtnOk = new MetroFramework.Controls.MetroButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // mlblInstruction
            // 
            this.mlblInstruction.AutoSize = true;
            this.mlblInstruction.Location = new System.Drawing.Point(23, 79);
            this.mlblInstruction.Name = "mlblInstruction";
            this.mlblInstruction.Size = new System.Drawing.Size(256, 19);
            this.mlblInstruction.TabIndex = 7;
            this.mlblInstruction.Text = "Please select a previous year to copy data.";
            // 
            // mtxtItemNo
            // 
            // 
            // 
            // 
            this.mtxtItemNo.CustomButton.Image = null;
            this.mtxtItemNo.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.mtxtItemNo.CustomButton.Name = "";
            this.mtxtItemNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtItemNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtItemNo.CustomButton.TabIndex = 1;
            this.mtxtItemNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtItemNo.CustomButton.UseSelectable = true;
            this.mtxtItemNo.CustomButton.Visible = false;
            this.mtxtItemNo.Lines = new string[0];
            this.mtxtItemNo.Location = new System.Drawing.Point(120, 242);
            this.mtxtItemNo.MaxLength = 32767;
            this.mtxtItemNo.Name = "mtxtItemNo";
            this.mtxtItemNo.PasswordChar = '\0';
            this.mtxtItemNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtItemNo.SelectedText = "";
            this.mtxtItemNo.SelectionLength = 0;
            this.mtxtItemNo.SelectionStart = 0;
            this.mtxtItemNo.ShortcutsEnabled = true;
            this.mtxtItemNo.Size = new System.Drawing.Size(190, 23);
            this.mtxtItemNo.TabIndex = 169;
            this.mtxtItemNo.UseSelectable = true;
            this.mtxtItemNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtItemNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtItemNo.TextChanged += new System.EventHandler(this.mtxtItemNo_TextChanged);
            // 
            // mbtnViewList
            // 
            this.mbtnViewList.Location = new System.Drawing.Point(310, 242);
            this.mbtnViewList.Name = "mbtnViewList";
            this.mbtnViewList.Size = new System.Drawing.Size(58, 23);
            this.mbtnViewList.TabIndex = 168;
            this.mbtnViewList.Text = "List";
            this.mbtnViewList.UseSelectable = true;
            this.mbtnViewList.Click += new System.EventHandler(this.mbtnViewList_Click);
            // 
            // mtxtItemDesc
            // 
            // 
            // 
            // 
            this.mtxtItemDesc.CustomButton.Image = null;
            this.mtxtItemDesc.CustomButton.Location = new System.Drawing.Point(196, 2);
            this.mtxtItemDesc.CustomButton.Name = "";
            this.mtxtItemDesc.CustomButton.Size = new System.Drawing.Size(49, 49);
            this.mtxtItemDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtItemDesc.CustomButton.TabIndex = 1;
            this.mtxtItemDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtItemDesc.CustomButton.UseSelectable = true;
            this.mtxtItemDesc.CustomButton.Visible = false;
            this.mtxtItemDesc.Lines = new string[0];
            this.mtxtItemDesc.Location = new System.Drawing.Point(120, 268);
            this.mtxtItemDesc.MaxLength = 50;
            this.mtxtItemDesc.Multiline = true;
            this.mtxtItemDesc.Name = "mtxtItemDesc";
            this.mtxtItemDesc.PasswordChar = '\0';
            this.mtxtItemDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtItemDesc.SelectedText = "";
            this.mtxtItemDesc.SelectionLength = 0;
            this.mtxtItemDesc.SelectionStart = 0;
            this.mtxtItemDesc.ShortcutsEnabled = true;
            this.mtxtItemDesc.Size = new System.Drawing.Size(248, 54);
            this.mtxtItemDesc.TabIndex = 167;
            this.mtxtItemDesc.UseSelectable = true;
            this.mtxtItemDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtItemDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 268);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 166;
            this.metroLabel3.Text = "Description";
            // 
            // mlblItemNo
            // 
            this.mlblItemNo.AutoSize = true;
            this.mlblItemNo.Location = new System.Drawing.Point(26, 242);
            this.mlblItemNo.Name = "mlblItemNo";
            this.mlblItemNo.Size = new System.Drawing.Size(30, 19);
            this.mlblItemNo.TabIndex = 165;
            this.mlblItemNo.Text = "No.";
            // 
            // mtxtCurLogYear
            // 
            // 
            // 
            // 
            this.mtxtCurLogYear.CustomButton.Image = null;
            this.mtxtCurLogYear.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.mtxtCurLogYear.CustomButton.Name = "";
            this.mtxtCurLogYear.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtCurLogYear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtCurLogYear.CustomButton.TabIndex = 1;
            this.mtxtCurLogYear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtCurLogYear.CustomButton.UseSelectable = true;
            this.mtxtCurLogYear.CustomButton.Visible = false;
            this.mtxtCurLogYear.Enabled = false;
            this.mtxtCurLogYear.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtxtCurLogYear.Lines = new string[0];
            this.mtxtCurLogYear.Location = new System.Drawing.Point(120, 195);
            this.mtxtCurLogYear.MaxLength = 32767;
            this.mtxtCurLogYear.Name = "mtxtCurLogYear";
            this.mtxtCurLogYear.PasswordChar = '\0';
            this.mtxtCurLogYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCurLogYear.SelectedText = "";
            this.mtxtCurLogYear.SelectionLength = 0;
            this.mtxtCurLogYear.SelectionStart = 0;
            this.mtxtCurLogYear.ShortcutsEnabled = true;
            this.mtxtCurLogYear.Size = new System.Drawing.Size(190, 23);
            this.mtxtCurLogYear.TabIndex = 175;
            this.mtxtCurLogYear.UseSelectable = true;
            this.mtxtCurLogYear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtCurLogYear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(26, 198);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(24, 19);
            this.metroLabel4.TabIndex = 174;
            this.metroLabel4.Text = "To";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 163);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 173;
            this.metroLabel1.Text = "From";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 359);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 172;
            this.metroLabel2.Text = "metroLabel2";
            // 
            // mcbOverWrite
            // 
            this.mcbOverWrite.AutoSize = true;
            this.mcbOverWrite.Location = new System.Drawing.Point(120, 328);
            this.mcbOverWrite.Name = "mcbOverWrite";
            this.mcbOverWrite.Size = new System.Drawing.Size(117, 15);
            this.mcbOverWrite.TabIndex = 171;
            this.mcbOverWrite.Text = "Overwrite Existing";
            this.mcbOverWrite.UseSelectable = true;
            // 
            // mcboYear
            // 
            this.mcboYear.FormattingEnabled = true;
            this.mcboYear.ItemHeight = 23;
            this.mcboYear.Location = new System.Drawing.Point(120, 163);
            this.mcboYear.Name = "mcboYear";
            this.mcboYear.Size = new System.Drawing.Size(190, 29);
            this.mcboYear.TabIndex = 170;
            this.mcboYear.UseSelectable = true;
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.Location = new System.Drawing.Point(310, 442);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(75, 23);
            this.mbtnCancel.TabIndex = 177;
            this.mbtnCancel.Text = "Cancel";
            this.mbtnCancel.UseSelectable = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // mbtnOk
            // 
            this.mbtnOk.Location = new System.Drawing.Point(234, 442);
            this.mbtnOk.Name = "mbtnOk";
            this.mbtnOk.Size = new System.Drawing.Size(75, 23);
            this.mbtnOk.TabIndex = 176;
            this.mbtnOk.Text = "Ok";
            this.mbtnOk.UseSelectable = true;
            this.mbtnOk.Click += new System.EventHandler(this.mbtnOk_Click);
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(153, 120);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(62, 15);
            this.metroRadioButton1.TabIndex = 178;
            this.metroRadioButton1.Text = "By Year";
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(23, 120);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(63, 15);
            this.metroRadioButton2.TabIndex = 179;
            this.metroRadioButton2.Text = "By Item";
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // frm_Copier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 485);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mbtnOk);
            this.Controls.Add(this.mtxtCurLogYear);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mcbOverWrite);
            this.Controls.Add(this.mcboYear);
            this.Controls.Add(this.mtxtItemNo);
            this.Controls.Add(this.mbtnViewList);
            this.Controls.Add(this.mtxtItemDesc);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mlblItemNo);
            this.Controls.Add(this.mlblInstruction);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Copier";
            this.Resizable = false;
            this.Text = "Copy Item";
            this.Load += new System.EventHandler(this.frm_Copier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlblInstruction;
        private MetroFramework.Controls.MetroButton mbtnViewList;
        private MetroFramework.Controls.MetroTextBox mtxtItemDesc;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel mlblItemNo;
        private MetroFramework.Controls.MetroTextBox mtxtCurLogYear;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox mcbOverWrite;
        public MetroFramework.Controls.MetroComboBox mcboYear;
        private MetroFramework.Controls.MetroButton mbtnCancel;
        private MetroFramework.Controls.MetroButton mbtnOk;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        public MetroFramework.Controls.MetroTextBox mtxtItemNo;
    }
}