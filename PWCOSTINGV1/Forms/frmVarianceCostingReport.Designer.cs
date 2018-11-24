namespace PWCOSTINGV1.Forms
{
    partial class frmVarianceCostingReport
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
            this.label2 = new System.Windows.Forms.Label();
            this.mbtnPreview = new MetroFramework.Controls.MetroButton();
            this.mbtnPrint = new MetroFramework.Controls.MetroButton();
            this.mbtnGenerate = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mcboMonth = new MetroFramework.Controls.MetroComboBox();
            this.mtxtYear = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(291, 25);
            this.label2.TabIndex = 152;
            this.label2.Text = "Parameters                                                  ";
            // 
            // mbtnPreview
            // 
            this.mbtnPreview.Location = new System.Drawing.Point(339, 186);
            this.mbtnPreview.Name = "mbtnPreview";
            this.mbtnPreview.Size = new System.Drawing.Size(101, 23);
            this.mbtnPreview.TabIndex = 155;
            this.mbtnPreview.Text = "Preview";
            this.mbtnPreview.UseSelectable = true;
            this.mbtnPreview.Click += new System.EventHandler(this.mbtnPreview_Click);
            // 
            // mbtnPrint
            // 
            this.mbtnPrint.Location = new System.Drawing.Point(339, 140);
            this.mbtnPrint.Name = "mbtnPrint";
            this.mbtnPrint.Size = new System.Drawing.Size(101, 23);
            this.mbtnPrint.TabIndex = 154;
            this.mbtnPrint.Text = "Print";
            this.mbtnPrint.UseSelectable = true;
            // 
            // mbtnGenerate
            // 
            this.mbtnGenerate.Location = new System.Drawing.Point(339, 96);
            this.mbtnGenerate.Name = "mbtnGenerate";
            this.mbtnGenerate.Size = new System.Drawing.Size(101, 23);
            this.mbtnGenerate.TabIndex = 153;
            this.mbtnGenerate.Text = "Generate";
            this.mbtnGenerate.UseSelectable = true;
            this.mbtnGenerate.Click += new System.EventHandler(this.mbtnGenerate_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 144);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 157;
            this.metroLabel1.Text = "Month";
            // 
            // mcboMonth
            // 
            this.mcboMonth.FormattingEnabled = true;
            this.mcboMonth.ItemHeight = 23;
            this.mcboMonth.Location = new System.Drawing.Point(95, 140);
            this.mcboMonth.Name = "mcboMonth";
            this.mcboMonth.Size = new System.Drawing.Size(219, 29);
            this.mcboMonth.TabIndex = 158;
            this.mcboMonth.UseSelectable = true;
            // 
            // mtxtYear
            // 
            // 
            // 
            // 
            this.mtxtYear.CustomButton.Image = null;
            this.mtxtYear.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.mtxtYear.CustomButton.Name = "";
            this.mtxtYear.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtYear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtYear.CustomButton.TabIndex = 1;
            this.mtxtYear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtYear.CustomButton.UseSelectable = true;
            this.mtxtYear.CustomButton.Visible = false;
            this.mtxtYear.Lines = new string[0];
            this.mtxtYear.Location = new System.Drawing.Point(95, 186);
            this.mtxtYear.MaxLength = 32767;
            this.mtxtYear.Name = "mtxtYear";
            this.mtxtYear.PasswordChar = '\0';
            this.mtxtYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtYear.SelectedText = "";
            this.mtxtYear.SelectionLength = 0;
            this.mtxtYear.SelectionStart = 0;
            this.mtxtYear.ShortcutsEnabled = true;
            this.mtxtYear.Size = new System.Drawing.Size(219, 23);
            this.mtxtYear.TabIndex = 159;
            this.mtxtYear.UseSelectable = true;
            this.mtxtYear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtYear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtYear_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 190);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 160;
            this.metroLabel2.Text = "Year";
            // 
            // frmVarianceCostingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 262);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtxtYear);
            this.Controls.Add(this.mcboMonth);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mbtnPreview);
            this.Controls.Add(this.mbtnPrint);
            this.Controls.Add(this.mbtnGenerate);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVarianceCostingReport";
            this.Resizable = false;
            this.Text = "Variance Costing Report";
            this.Load += new System.EventHandler(this.frmVarianceCostingReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton mbtnPreview;
        private MetroFramework.Controls.MetroButton mbtnPrint;
        private MetroFramework.Controls.MetroButton mbtnGenerate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox mcboMonth;
        private MetroFramework.Controls.MetroTextBox mtxtYear;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}