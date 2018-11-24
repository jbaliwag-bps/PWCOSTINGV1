namespace PWCOSTINGV1.Helpers
{
    partial class frm_Preloader
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
            this.CRViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CRViewer
            // 
            this.CRViewer.ActiveViewIndex = -1;
            this.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRViewer.Location = new System.Drawing.Point(20, 60);
            this.CRViewer.Name = "CRViewer";
            this.CRViewer.Size = new System.Drawing.Size(893, 620);
            this.CRViewer.TabIndex = 1;
            this.CRViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Preloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 700);
            this.Controls.Add(this.CRViewer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Preloader";
            this.Resizable = false;
            this.Text = "frm_Preloader";
            this.TransparencyKey = System.Drawing.Color.MintCream;
            this.Load += new System.EventHandler(this.frm_Preloader_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRViewer;
        private System.Windows.Forms.Timer timer1;
    }
}