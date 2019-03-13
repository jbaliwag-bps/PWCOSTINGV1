namespace PWCOSTINGV1.Forms
{
    partial class frmMODRC
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
            this.mcbCosting = new MetroFramework.Controls.MetroCheckBox();
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.mbtnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtxtDesc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtxtCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mcbActive = new MetroFramework.Controls.MetroCheckBox();
            this.mtxtTime = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mcbCosting
            // 
            this.mcbCosting.AutoSize = true;
            this.mcbCosting.Location = new System.Drawing.Point(194, 175);
            this.mcbCosting.Name = "mcbCosting";
            this.mcbCosting.Size = new System.Drawing.Size(41, 15);
            this.mcbCosting.TabIndex = 64;
            this.mcbCosting.Text = "Yes";
            this.mcbCosting.UseSelectable = true;
            this.mcbCosting.CheckedChanged += new System.EventHandler(this.mcbCosting_CheckedChanged);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.Location = new System.Drawing.Point(271, 202);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(75, 40);
            this.mbtnCancel.TabIndex = 62;
            this.mbtnCancel.Text = "C&ANCEL";
            this.mbtnCancel.UseSelectable = true;
            // 
            // mbtnSave
            // 
            this.mbtnSave.Location = new System.Drawing.Point(194, 202);
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(75, 40);
            this.mbtnSave.TabIndex = 61;
            this.mbtnSave.Text = "Save";
            this.mbtnSave.UseSelectable = true;
            this.mbtnSave.Click += new System.EventHandler(this.mbtnSave_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(41, 129);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 59;
            this.metroLabel4.Text = "Time";
            // 
            // mtxtDesc
            // 
            // 
            // 
            // 
            this.mtxtDesc.CustomButton.Image = null;
            this.mtxtDesc.CustomButton.Location = new System.Drawing.Point(379, 1);
            this.mtxtDesc.CustomButton.Name = "";
            this.mtxtDesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtDesc.CustomButton.TabIndex = 1;
            this.mtxtDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtDesc.CustomButton.UseSelectable = true;
            this.mtxtDesc.CustomButton.Visible = false;
            this.mtxtDesc.Lines = new string[0];
            this.mtxtDesc.Location = new System.Drawing.Point(194, 96);
            this.mtxtDesc.MaxLength = 50;
            this.mtxtDesc.Name = "mtxtDesc";
            this.mtxtDesc.PasswordChar = '\0';
            this.mtxtDesc.PromptText = "Description";
            this.mtxtDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtDesc.SelectedText = "";
            this.mtxtDesc.SelectionLength = 0;
            this.mtxtDesc.SelectionStart = 0;
            this.mtxtDesc.ShortcutsEnabled = true;
            this.mtxtDesc.Size = new System.Drawing.Size(401, 23);
            this.mtxtDesc.TabIndex = 58;
            this.mtxtDesc.UseSelectable = true;
            this.mtxtDesc.WaterMark = "Description";
            this.mtxtDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(41, 96);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 57;
            this.metroLabel2.Text = "Description";
            // 
            // mtxtCode
            // 
            // 
            // 
            // 
            this.mtxtCode.CustomButton.Image = null;
            this.mtxtCode.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.mtxtCode.CustomButton.Name = "";
            this.mtxtCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtCode.CustomButton.TabIndex = 1;
            this.mtxtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtCode.CustomButton.UseSelectable = true;
            this.mtxtCode.CustomButton.Visible = false;
            this.mtxtCode.Lines = new string[0];
            this.mtxtCode.Location = new System.Drawing.Point(194, 74);
            this.mtxtCode.MaxLength = 10;
            this.mtxtCode.Name = "mtxtCode";
            this.mtxtCode.PasswordChar = '\0';
            this.mtxtCode.PromptText = "Code";
            this.mtxtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCode.SelectedText = "";
            this.mtxtCode.SelectionLength = 0;
            this.mtxtCode.SelectionStart = 0;
            this.mtxtCode.ShortcutsEnabled = true;
            this.mtxtCode.Size = new System.Drawing.Size(155, 23);
            this.mtxtCode.TabIndex = 56;
            this.mtxtCode.UseSelectable = true;
            this.mtxtCode.WaterMark = "Code";
            this.mtxtCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 55;
            this.metroLabel1.Text = "Code";
            // 
            // mcbActive
            // 
            this.mcbActive.AutoSize = true;
            this.mcbActive.Location = new System.Drawing.Point(194, 154);
            this.mcbActive.Name = "mcbActive";
            this.mcbActive.Size = new System.Drawing.Size(56, 15);
            this.mcbActive.TabIndex = 65;
            this.mcbActive.Text = "Active";
            this.mcbActive.UseSelectable = true;
            this.mcbActive.CheckedChanged += new System.EventHandler(this.mcbActive_CheckedChanged);
            // 
            // mtxtTime
            // 
            // 
            // 
            // 
            this.mtxtTime.CustomButton.Image = null;
            this.mtxtTime.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.mtxtTime.CustomButton.Name = "";
            this.mtxtTime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtTime.CustomButton.TabIndex = 1;
            this.mtxtTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtTime.CustomButton.UseSelectable = true;
            this.mtxtTime.CustomButton.Visible = false;
            this.mtxtTime.Lines = new string[0];
            this.mtxtTime.Location = new System.Drawing.Point(194, 125);
            this.mtxtTime.MaxLength = 10;
            this.mtxtTime.Name = "mtxtTime";
            this.mtxtTime.PasswordChar = '\0';
            this.mtxtTime.PromptText = "Time";
            this.mtxtTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtTime.SelectedText = "";
            this.mtxtTime.SelectionLength = 0;
            this.mtxtTime.SelectionStart = 0;
            this.mtxtTime.ShortcutsEnabled = true;
            this.mtxtTime.Size = new System.Drawing.Size(155, 23);
            this.mtxtTime.TabIndex = 66;
            this.mtxtTime.UseSelectable = true;
            this.mtxtTime.WaterMark = "Time";
            this.mtxtTime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtTime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtTime_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(41, 170);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 19);
            this.metroLabel3.TabIndex = 67;
            this.metroLabel3.Text = "Is For Costing?";
            // 
            // frmMODRC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 266);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtxtTime);
            this.Controls.Add(this.mcbActive);
            this.Controls.Add(this.mcbCosting);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mbtnSave);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mtxtDesc);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtxtCode);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmMODRC";
            this.Text = "MODRC";
            this.Load += new System.EventHandler(this.MODRC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox mcbCosting;
        private MetroFramework.Controls.MetroButton mbtnCancel;
        private MetroFramework.Controls.MetroButton mbtnSave;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mtxtDesc;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtxtCode;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox mcbActive;
        private MetroFramework.Controls.MetroTextBox mtxtTime;
        private MetroFramework.Controls.MetroLabel metroLabel3;

    }
}