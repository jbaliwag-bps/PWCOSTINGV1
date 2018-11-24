namespace PWCOSTINGV1
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mlblAppName = new MetroFramework.Controls.MetroLabel();
            this.mlblAppVersion = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.mlblSystemStatus = new MetroFramework.Controls.MetroLabel();
            this.mlblAppVendor = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PWCOSTINGV1.Properties.Resources.TPI_LOGO_FINAL;
            this.pictureBox1.Location = new System.Drawing.Point(23, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mlblAppName
            // 
            this.mlblAppName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblAppName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblAppName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblAppName.Location = new System.Drawing.Point(171, 67);
            this.mlblAppName.Name = "mlblAppName";
            this.mlblAppName.Size = new System.Drawing.Size(315, 23);
            this.mlblAppName.TabIndex = 1;
            this.mlblAppName.Text = "Application Name";
            // 
            // mlblAppVersion
            // 
            this.mlblAppVersion.AutoSize = true;
            this.mlblAppVersion.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblAppVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mlblAppVersion.Location = new System.Drawing.Point(171, 96);
            this.mlblAppVersion.Name = "mlblAppVersion";
            this.mlblAppVersion.Size = new System.Drawing.Size(140, 19);
            this.mlblAppVersion.TabIndex = 2;
            this.mlblAppVersion.Text = "Application Version";
            this.mlblAppVersion.UseCustomForeColor = true;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar1.Location = new System.Drawing.Point(24, 166);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.metroProgressBar1.Size = new System.Drawing.Size(465, 23);
            this.metroProgressBar1.TabIndex = 3;
            this.metroProgressBar1.Click += new System.EventHandler(this.metroProgressBar1_Click);
            this.metroProgressBar1.Validating += new System.ComponentModel.CancelEventHandler(this.metroProgressBar1_Validating);
            // 
            // mlblSystemStatus
            // 
            this.mlblSystemStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblSystemStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblSystemStatus.Location = new System.Drawing.Point(25, 193);
            this.mlblSystemStatus.Name = "mlblSystemStatus";
            this.mlblSystemStatus.Size = new System.Drawing.Size(464, 23);
            this.mlblSystemStatus.TabIndex = 4;
            this.mlblSystemStatus.Text = "Connecting to Server ...";
            this.mlblSystemStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlblAppVendor
            // 
            this.mlblAppVendor.AutoSize = true;
            this.mlblAppVendor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblAppVendor.Location = new System.Drawing.Point(171, 121);
            this.mlblAppVendor.Name = "mlblAppVendor";
            this.mlblAppVendor.Size = new System.Drawing.Size(126, 19);
            this.mlblAppVendor.TabIndex = 5;
            this.mlblAppVendor.Text = "Application Vendor";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 243);
            this.ControlBox = false;
            this.Controls.Add(this.mlblAppVendor);
            this.Controls.Add(this.mlblSystemStatus);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.mlblAppVersion);
            this.Controls.Add(this.mlblAppName);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSplash";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel mlblAppName;
        private MetroFramework.Controls.MetroLabel mlblAppVersion;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroLabel mlblSystemStatus;
        private MetroFramework.Controls.MetroLabel mlblAppVendor;
    }
}