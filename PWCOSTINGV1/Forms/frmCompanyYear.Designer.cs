namespace PWCOSTINGV1.Forms
{
    partial class frmCompanyYear
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
            this.mtxtYear = new MetroFramework.Controls.MetroTextBox();
            this.mlblInstruction = new MetroFramework.Controls.MetroLabel();
            this.mbtnAdd = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mtxtYear
            // 
            // 
            // 
            // 
            this.mtxtYear.CustomButton.Image = null;
            this.mtxtYear.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.mtxtYear.CustomButton.Name = "";
            this.mtxtYear.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtYear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtYear.CustomButton.TabIndex = 1;
            this.mtxtYear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtYear.CustomButton.UseSelectable = true;
            this.mtxtYear.CustomButton.Visible = false;
            this.mtxtYear.Lines = new string[0];
            this.mtxtYear.Location = new System.Drawing.Point(159, 79);
            this.mtxtYear.MaxLength = 32767;
            this.mtxtYear.Name = "mtxtYear";
            this.mtxtYear.PasswordChar = '\0';
            this.mtxtYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtYear.SelectedText = "";
            this.mtxtYear.SelectionLength = 0;
            this.mtxtYear.SelectionStart = 0;
            this.mtxtYear.ShortcutsEnabled = true;
            this.mtxtYear.Size = new System.Drawing.Size(121, 23);
            this.mtxtYear.TabIndex = 0;
            this.mtxtYear.UseSelectable = true;
            this.mtxtYear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtYear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtYear_KeyPress);
            // 
            // mlblInstruction
            // 
            this.mlblInstruction.AutoSize = true;
            this.mlblInstruction.Location = new System.Drawing.Point(23, 79);
            this.mlblInstruction.Name = "mlblInstruction";
            this.mlblInstruction.Size = new System.Drawing.Size(125, 19);
            this.mlblInstruction.TabIndex = 2;
            this.mlblInstruction.Text = "Enter a year to add.";
            // 
            // mbtnAdd
            // 
            this.mbtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.mbtnAdd.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.saveicon1;
            this.mbtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnAdd.Location = new System.Drawing.Point(280, 27);
            this.mbtnAdd.Name = "mbtnAdd";
            this.mbtnAdd.Size = new System.Drawing.Size(40, 40);
            this.mbtnAdd.TabIndex = 3;
            this.mbtnAdd.UseSelectable = true;
            this.mbtnAdd.Click += new System.EventHandler(this.mbtnAdd_Click);
            // 
            // frmCompanyYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 149);
            this.Controls.Add(this.mbtnAdd);
            this.Controls.Add(this.mlblInstruction);
            this.Controls.Add(this.mtxtYear);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompanyYear";
            this.Resizable = false;
            this.Tag = "";
            this.Text = "Company Year";
            this.Load += new System.EventHandler(this.frmCompanyYear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mtxtYear;
        private MetroFramework.Controls.MetroLabel mlblInstruction;
        private MetroFramework.Controls.MetroButton mbtnAdd;
    }
}