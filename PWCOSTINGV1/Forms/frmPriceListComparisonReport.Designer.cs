namespace PWCOSTINGV1.Forms
{
    partial class frmPriceListComparisonReport
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.mbtnGenerate = new MetroFramework.Controls.MetroButton();
            this.btnPreview = new MetroFramework.Controls.MetroButton();
            this.mcbofrstYear = new MetroFramework.Controls.MetroComboBox();
            this.mcboscndYear = new MetroFramework.Controls.MetroComboBox();
            this.mcboCategory = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 188);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "YEAR";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(29, 234);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(99, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "AGAINST YEAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(284, 25);
            this.label2.TabIndex = 152;
            this.label2.Text = "Parameter                                                  ";
            // 
            // mbtnGenerate
            // 
            this.mbtnGenerate.Location = new System.Drawing.Point(343, 163);
            this.mbtnGenerate.Name = "mbtnGenerate";
            this.mbtnGenerate.Size = new System.Drawing.Size(192, 23);
            this.mbtnGenerate.TabIndex = 156;
            this.mbtnGenerate.Text = "Generate PriceLists";
            this.mbtnGenerate.UseSelectable = true;
            this.mbtnGenerate.Click += new System.EventHandler(this.mbtnGenerate_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(343, 213);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(192, 23);
            this.btnPreview.TabIndex = 157;
            this.btnPreview.Text = "Preview Comparison";
            this.btnPreview.UseSelectable = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // mcbofrstYear
            // 
            this.mcbofrstYear.FormattingEnabled = true;
            this.mcbofrstYear.ItemHeight = 23;
            this.mcbofrstYear.Location = new System.Drawing.Point(147, 185);
            this.mcbofrstYear.Name = "mcbofrstYear";
            this.mcbofrstYear.Size = new System.Drawing.Size(147, 29);
            this.mcbofrstYear.TabIndex = 158;
            this.mcbofrstYear.UseSelectable = true;
            // 
            // mcboscndYear
            // 
            this.mcboscndYear.FormattingEnabled = true;
            this.mcboscndYear.ItemHeight = 23;
            this.mcboscndYear.Location = new System.Drawing.Point(147, 230);
            this.mcboscndYear.Name = "mcboscndYear";
            this.mcboscndYear.Size = new System.Drawing.Size(147, 29);
            this.mcboscndYear.TabIndex = 159;
            this.mcboscndYear.UseSelectable = true;
            // 
            // mcboCategory
            // 
            this.mcboCategory.FormattingEnabled = true;
            this.mcboCategory.ItemHeight = 23;
            this.mcboCategory.Location = new System.Drawing.Point(101, 137);
            this.mcboCategory.Name = "mcboCategory";
            this.mcboCategory.Size = new System.Drawing.Size(193, 29);
            this.mcboCategory.TabIndex = 160;
            this.mcboCategory.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(25, 137);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 161;
            this.metroLabel3.Text = "Category";
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.metroCheckBox1.Location = new System.Drawing.Point(159, 275);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(135, 15);
            this.metroCheckBox1.TabIndex = 162;
            this.metroCheckBox1.Text = "View YEN on Report";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // frmPriceListComparisonReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 336);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mcboCategory);
            this.Controls.Add(this.mcboscndYear);
            this.Controls.Add(this.mcbofrstYear);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.mbtnGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPriceListComparisonReport";
            this.Resizable = false;
            this.Text = "Price List Comparison";
            this.Load += new System.EventHandler(this.frmPriceListComparisonReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton mbtnGenerate;
        private MetroFramework.Controls.MetroButton btnPreview;
        private MetroFramework.Controls.MetroComboBox mcbofrstYear;
        private MetroFramework.Controls.MetroComboBox mcboscndYear;
        private MetroFramework.Controls.MetroComboBox mcboCategory;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
    }
}