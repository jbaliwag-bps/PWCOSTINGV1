namespace PWCOSTINGV1.Forms
{
    partial class frmPriceListReport
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
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mbtnGenerate = new MetroFramework.Controls.MetroButton();
            this.mbtnPreview = new MetroFramework.Controls.MetroButton();
            this.mbtnPreviewWDetails = new MetroFramework.Controls.MetroButton();
            this.mcboCategory = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(307, 51);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(26, 176);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 127);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(284, 25);
            this.label2.TabIndex = 151;
            this.label2.Text = "Parameter                                                  ";
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.metroCheckBox1.Location = new System.Drawing.Point(103, 215);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(135, 15);
            this.metroCheckBox1.TabIndex = 153;
            this.metroCheckBox1.Text = "View YEN on Report";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 272);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 19);
            this.metroLabel3.TabIndex = 154;
            this.metroLabel3.Text = "metroLabel3";
            // 
            // mbtnGenerate
            // 
            this.mbtnGenerate.Location = new System.Drawing.Point(347, 129);
            this.mbtnGenerate.Name = "mbtnGenerate";
            this.mbtnGenerate.Size = new System.Drawing.Size(192, 23);
            this.mbtnGenerate.TabIndex = 155;
            this.mbtnGenerate.Text = "Generate PriceList";
            this.mbtnGenerate.UseSelectable = true;
            this.mbtnGenerate.Click += new System.EventHandler(this.mbtnGenerate_Click);
            // 
            // mbtnPreview
            // 
            this.mbtnPreview.Location = new System.Drawing.Point(347, 172);
            this.mbtnPreview.Name = "mbtnPreview";
            this.mbtnPreview.Size = new System.Drawing.Size(192, 23);
            this.mbtnPreview.TabIndex = 156;
            this.mbtnPreview.Text = "Preview PriceList Summary";
            this.mbtnPreview.UseSelectable = true;
            this.mbtnPreview.Click += new System.EventHandler(this.mbtnPreview_Click);
            // 
            // mbtnPreviewWDetails
            // 
            this.mbtnPreviewWDetails.Location = new System.Drawing.Point(347, 216);
            this.mbtnPreviewWDetails.Name = "mbtnPreviewWDetails";
            this.mbtnPreviewWDetails.Size = new System.Drawing.Size(192, 36);
            this.mbtnPreviewWDetails.TabIndex = 157;
            this.mbtnPreviewWDetails.Text = "metroButton3";
            this.mbtnPreviewWDetails.UseSelectable = true;
            this.mbtnPreviewWDetails.Click += new System.EventHandler(this.mbtnPreviewWDetails_Click);
            // 
            // mcboCategory
            // 
            this.mcboCategory.FormattingEnabled = true;
            this.mcboCategory.ItemHeight = 23;
            this.mcboCategory.Location = new System.Drawing.Point(103, 174);
            this.mcboCategory.Name = "mcboCategory";
            this.mcboCategory.Size = new System.Drawing.Size(193, 29);
            this.mcboCategory.TabIndex = 158;
            this.mcboCategory.UseSelectable = true;
            // 
            // frmPriceListReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 313);
            this.Controls.Add(this.mcboCategory);
            this.Controls.Add(this.mbtnPreviewWDetails);
            this.Controls.Add(this.mbtnPreview);
            this.Controls.Add(this.mbtnGenerate);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPriceListReport";
            this.Resizable = false;
            this.Text = "Price List Report";
            this.Load += new System.EventHandler(this.frmPriceListReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton mbtnGenerate;
        private MetroFramework.Controls.MetroButton mbtnPreview;
        private MetroFramework.Controls.MetroButton mbtnPreviewWDetails;
        private MetroFramework.Controls.MetroComboBox mcboCategory;
    }
}