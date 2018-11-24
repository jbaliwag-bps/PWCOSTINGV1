namespace PWCOSTINGV1.Forms
{
    partial class frm_YearHelper
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
            this.mcboYear = new MetroFramework.Controls.MetroComboBox();
            this.mlblInstruction = new MetroFramework.Controls.MetroLabel();
            this.mcbOverWrite = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtxtCurLogYear = new MetroFramework.Controls.MetroTextBox();
            this.mbtnOk = new MetroFramework.Controls.MetroButton();
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mcboYear
            // 
            this.mcboYear.FormattingEnabled = true;
            this.mcboYear.ItemHeight = 23;
            this.mcboYear.Location = new System.Drawing.Point(122, 110);
            this.mcboYear.Name = "mcboYear";
            this.mcboYear.Size = new System.Drawing.Size(190, 29);
            this.mcboYear.TabIndex = 5;
            this.mcboYear.UseSelectable = true;
            // 
            // mlblInstruction
            // 
            this.mlblInstruction.AutoSize = true;
            this.mlblInstruction.Location = new System.Drawing.Point(23, 79);
            this.mlblInstruction.Name = "mlblInstruction";
            this.mlblInstruction.Size = new System.Drawing.Size(256, 19);
            this.mlblInstruction.TabIndex = 6;
            this.mlblInstruction.Text = "Please select a previous year to copy data.";
            // 
            // mcbOverWrite
            // 
            this.mcbOverWrite.AutoSize = true;
            this.mcbOverWrite.Location = new System.Drawing.Point(122, 176);
            this.mcbOverWrite.Name = "mcbOverWrite";
            this.mcbOverWrite.Size = new System.Drawing.Size(117, 15);
            this.mcbOverWrite.TabIndex = 7;
            this.mcbOverWrite.Text = "Overwrite Existing";
            this.mcbOverWrite.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 220);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(28, 110);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "From";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(28, 145);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(24, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "To";
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
            this.mtxtCurLogYear.Location = new System.Drawing.Point(122, 142);
            this.mtxtCurLogYear.MaxLength = 32767;
            this.mtxtCurLogYear.Name = "mtxtCurLogYear";
            this.mtxtCurLogYear.PasswordChar = '\0';
            this.mtxtCurLogYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCurLogYear.SelectedText = "";
            this.mtxtCurLogYear.SelectionLength = 0;
            this.mtxtCurLogYear.SelectionStart = 0;
            this.mtxtCurLogYear.ShortcutsEnabled = true;
            this.mtxtCurLogYear.Size = new System.Drawing.Size(190, 23);
            this.mtxtCurLogYear.TabIndex = 12;
            this.mtxtCurLogYear.UseSelectable = true;
            this.mtxtCurLogYear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtCurLogYear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtnOk
            // 
            this.mbtnOk.Location = new System.Drawing.Point(226, 303);
            this.mbtnOk.Name = "mbtnOk";
            this.mbtnOk.Size = new System.Drawing.Size(75, 23);
            this.mbtnOk.TabIndex = 13;
            this.mbtnOk.Text = "Ok";
            this.mbtnOk.UseSelectable = true;
            this.mbtnOk.Click += new System.EventHandler(this.mbtnOk_Click);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.Location = new System.Drawing.Point(302, 303);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(75, 23);
            this.mbtnCancel.TabIndex = 14;
            this.mbtnCancel.Text = "Cancel";
            this.mbtnCancel.UseSelectable = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // frm_YearHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 345);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mbtnOk);
            this.Controls.Add(this.mtxtCurLogYear);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mcbOverWrite);
            this.Controls.Add(this.mlblInstruction);
            this.Controls.Add(this.mcboYear);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_YearHelper";
            this.Resizable = false;
            this.Text = "frm_YearHelper";
            this.Load += new System.EventHandler(this.frm_YearHelper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlblInstruction;
        private MetroFramework.Controls.MetroCheckBox mcbOverWrite;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mtxtCurLogYear;
        private MetroFramework.Controls.MetroButton mbtnOk;
        private MetroFramework.Controls.MetroButton mbtnCancel;
        public MetroFramework.Controls.MetroComboBox mcboYear;
    }
}