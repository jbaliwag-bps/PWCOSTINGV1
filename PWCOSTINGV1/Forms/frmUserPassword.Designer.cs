namespace PWCOSTINGV1.Forms
{
    partial class frmUserPassword
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtxtOldPass = new MetroFramework.Controls.MetroTextBox();
            this.mtxtNewPass = new MetroFramework.Controls.MetroTextBox();
            this.mtxtConPass = new MetroFramework.Controls.MetroTextBox();
            this.mbtnSave = new MetroFramework.Controls.MetroButton();
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.mttipSave = new MetroFramework.Components.MetroToolTip();
            this.mttipCancel = new MetroFramework.Components.MetroToolTip();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Old Password";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 129);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "New Password";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 154);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(116, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Confirm Password";
            // 
            // mtxtOldPass
            // 
            // 
            // 
            // 
            this.mtxtOldPass.CustomButton.Image = null;
            this.mtxtOldPass.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.mtxtOldPass.CustomButton.Name = "";
            this.mtxtOldPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtOldPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtOldPass.CustomButton.TabIndex = 1;
            this.mtxtOldPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtOldPass.CustomButton.UseSelectable = true;
            this.mtxtOldPass.CustomButton.Visible = false;
            this.mtxtOldPass.Lines = new string[0];
            this.mtxtOldPass.Location = new System.Drawing.Point(168, 96);
            this.mtxtOldPass.MaxLength = 32767;
            this.mtxtOldPass.Name = "mtxtOldPass";
            this.mtxtOldPass.PasswordChar = '*';
            this.mtxtOldPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtOldPass.SelectedText = "";
            this.mtxtOldPass.SelectionLength = 0;
            this.mtxtOldPass.SelectionStart = 0;
            this.mtxtOldPass.ShortcutsEnabled = true;
            this.mtxtOldPass.Size = new System.Drawing.Size(219, 23);
            this.mtxtOldPass.TabIndex = 3;
            this.mtxtOldPass.UseSelectable = true;
            this.mtxtOldPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtOldPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtNewPass
            // 
            // 
            // 
            // 
            this.mtxtNewPass.CustomButton.Image = null;
            this.mtxtNewPass.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.mtxtNewPass.CustomButton.Name = "";
            this.mtxtNewPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtNewPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtNewPass.CustomButton.TabIndex = 1;
            this.mtxtNewPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtNewPass.CustomButton.UseSelectable = true;
            this.mtxtNewPass.CustomButton.Visible = false;
            this.mtxtNewPass.Lines = new string[0];
            this.mtxtNewPass.Location = new System.Drawing.Point(168, 125);
            this.mtxtNewPass.MaxLength = 32767;
            this.mtxtNewPass.Name = "mtxtNewPass";
            this.mtxtNewPass.PasswordChar = '*';
            this.mtxtNewPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtNewPass.SelectedText = "";
            this.mtxtNewPass.SelectionLength = 0;
            this.mtxtNewPass.SelectionStart = 0;
            this.mtxtNewPass.ShortcutsEnabled = true;
            this.mtxtNewPass.Size = new System.Drawing.Size(219, 23);
            this.mtxtNewPass.TabIndex = 4;
            this.mtxtNewPass.UseSelectable = true;
            this.mtxtNewPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtNewPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtConPass
            // 
            // 
            // 
            // 
            this.mtxtConPass.CustomButton.Image = null;
            this.mtxtConPass.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.mtxtConPass.CustomButton.Name = "";
            this.mtxtConPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtConPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtConPass.CustomButton.TabIndex = 1;
            this.mtxtConPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtConPass.CustomButton.UseSelectable = true;
            this.mtxtConPass.CustomButton.Visible = false;
            this.mtxtConPass.Lines = new string[0];
            this.mtxtConPass.Location = new System.Drawing.Point(168, 150);
            this.mtxtConPass.MaxLength = 32767;
            this.mtxtConPass.Name = "mtxtConPass";
            this.mtxtConPass.PasswordChar = '*';
            this.mtxtConPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtConPass.SelectedText = "";
            this.mtxtConPass.SelectionLength = 0;
            this.mtxtConPass.SelectionStart = 0;
            this.mtxtConPass.ShortcutsEnabled = true;
            this.mtxtConPass.Size = new System.Drawing.Size(219, 23);
            this.mtxtConPass.TabIndex = 5;
            this.mtxtConPass.UseSelectable = true;
            this.mtxtConPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtConPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtnSave
            // 
            this.mbtnSave.BackColor = System.Drawing.Color.Transparent;
            this.mbtnSave.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.saveicon1;
            this.mbtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnSave.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.mbtnSave.Location = new System.Drawing.Point(333, 35);
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(40, 40);
            this.mbtnSave.TabIndex = 67;
            this.mbtnSave.Text = " ";
            this.mttipSave.SetToolTip(this.mbtnSave, "Save Changes");
            this.mbtnSave.UseSelectable = true;
            this.mbtnSave.Click += new System.EventHandler(this.mbtnChange_Click);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.mbtnCancel.BackgroundImage = global::PWCOSTINGV1.Properties.Resources.cancelicon;
            this.mbtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnCancel.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.mbtnCancel.Location = new System.Drawing.Point(379, 35);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(40, 40);
            this.mbtnCancel.TabIndex = 68;
            this.mbtnCancel.Text = " ";
            this.mttipSave.SetToolTip(this.mbtnCancel, "Cancel");
            this.mbtnCancel.UseSelectable = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // mttipSave
            // 
            this.mttipSave.Style = MetroFramework.MetroColorStyle.Blue;
            this.mttipSave.StyleManager = null;
            this.mttipSave.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mttipCancel
            // 
            this.mttipCancel.Style = MetroFramework.MetroColorStyle.Blue;
            this.mttipCancel.StyleManager = null;
            this.mttipCancel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 207);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mbtnSave);
            this.Controls.Add(this.mtxtConPass);
            this.Controls.Add(this.mtxtNewPass);
            this.Controls.Add(this.mtxtOldPass);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserPassword";
            this.Resizable = false;
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mtxtOldPass;
        private MetroFramework.Controls.MetroTextBox mtxtNewPass;
        private MetroFramework.Controls.MetroTextBox mtxtConPass;
        private MetroFramework.Controls.MetroButton mbtnSave;
        private MetroFramework.Controls.MetroButton mbtnCancel;
        private MetroFramework.Components.MetroToolTip mttipSave;
        private MetroFramework.Components.MetroToolTip mttipCancel;
    }
}