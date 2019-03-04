namespace PWCOSTINGV1
{
    partial class frmMDI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.asdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.imglstMain = new System.Windows.Forms.ImageList(this.components);
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsMain
            // 
            this.mnsMain.BackColor = System.Drawing.Color.Transparent;
            this.mnsMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnsMain.Location = new System.Drawing.Point(10, 60);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.ShowItemToolTips = true;
            this.mnsMain.Size = new System.Drawing.Size(719, 24);
            this.mnsMain.TabIndex = 1;
            // 
            // asdfToolStripMenuItem
            // 
            this.asdfToolStripMenuItem.Name = "asdfToolStripMenuItem";
            this.asdfToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.asdfToolStripMenuItem.Text = "asdf";
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            // 
            // imglstMain
            // 
            this.imglstMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstMain.ImageStream")));
            this.imglstMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstMain.Images.SetKeyName(0, "filesbicon");
            this.imglstMain.Images.SetKeyName(1, "filesicon");
            this.imglstMain.Images.SetKeyName(2, "reportsbicon");
            this.imglstMain.Images.SetKeyName(3, "reportsicon");
            this.imglstMain.Images.SetKeyName(4, "settingsbicon");
            this.imglstMain.Images.SetKeyName(5, "settingsicon");
            this.imglstMain.Images.SetKeyName(6, "tpilogoicon");
            this.imglstMain.Images.SetKeyName(7, "utilitiesbicon");
            this.imglstMain.Images.SetKeyName(8, "utilitiesicon");
            this.imglstMain.Images.SetKeyName(9, "metrouiicon");
            this.imglstMain.Images.SetKeyName(10, "hobbyicon");
            this.imglstMain.Images.SetKeyName(11, "hobbybicon");
            this.imglstMain.Images.SetKeyName(12, "WIPbicon");
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Location = new System.Drawing.Point(137, 42);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(18, 23);
            this.miniToolStrip.TabIndex = 0;
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 434);
            this.Controls.Add(this.mnsMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMain;
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "frmMDI";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMain;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private System.Windows.Forms.ImageList imglstMain;
        private System.Windows.Forms.ToolStripMenuItem asdfToolStripMenuItem;
        private System.Windows.Forms.MenuStrip miniToolStrip;




    }
}

