namespace PWCOSTINGV1.Forms
{
    partial class frm_Importer
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mbtnOpenFile = new MetroFramework.Controls.MetroButton();
            this.mtxtFilePath = new MetroFramework.Controls.MetroTextBox();
            this.mbtnImport = new MetroFramework.Controls.MetroButton();
            this.mlblInstruction = new MetroFramework.Controls.MetroLabel();
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mcbOverWrite = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mbtnOpenFile
            // 
            this.mbtnOpenFile.Location = new System.Drawing.Point(316, 137);
            this.mbtnOpenFile.Name = "mbtnOpenFile";
            this.mbtnOpenFile.Size = new System.Drawing.Size(103, 23);
            this.mbtnOpenFile.TabIndex = 0;
            this.mbtnOpenFile.Text = "Browse File";
            this.mbtnOpenFile.UseSelectable = true;
            this.mbtnOpenFile.Click += new System.EventHandler(this.mbtnOpenFile_Click);
            // 
            // mtxtFilePath
            // 
            // 
            // 
            // 
            this.mtxtFilePath.CustomButton.Image = null;
            this.mtxtFilePath.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.mtxtFilePath.CustomButton.Name = "";
            this.mtxtFilePath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtFilePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtFilePath.CustomButton.TabIndex = 1;
            this.mtxtFilePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtFilePath.CustomButton.UseSelectable = true;
            this.mtxtFilePath.CustomButton.Visible = false;
            this.mtxtFilePath.Lines = new string[0];
            this.mtxtFilePath.Location = new System.Drawing.Point(64, 137);
            this.mtxtFilePath.MaxLength = 32767;
            this.mtxtFilePath.Name = "mtxtFilePath";
            this.mtxtFilePath.PasswordChar = '\0';
            this.mtxtFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtFilePath.SelectedText = "";
            this.mtxtFilePath.SelectionLength = 0;
            this.mtxtFilePath.SelectionStart = 0;
            this.mtxtFilePath.ShortcutsEnabled = true;
            this.mtxtFilePath.Size = new System.Drawing.Size(252, 23);
            this.mtxtFilePath.TabIndex = 1;
            this.mtxtFilePath.UseSelectable = true;
            this.mtxtFilePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtFilePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtnImport
            // 
            this.mbtnImport.Location = new System.Drawing.Point(224, 296);
            this.mbtnImport.Name = "mbtnImport";
            this.mbtnImport.Size = new System.Drawing.Size(75, 23);
            this.mbtnImport.TabIndex = 2;
            this.mbtnImport.Text = "Import";
            this.mbtnImport.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mbtnImport.UseSelectable = true;
            this.mbtnImport.Click += new System.EventHandler(this.mbtnImport_Click);
            // 
            // mlblInstruction
            // 
            this.mlblInstruction.AutoSize = true;
            this.mlblInstruction.Location = new System.Drawing.Point(21, 72);
            this.mlblInstruction.Name = "mlblInstruction";
            this.mlblInstruction.Size = new System.Drawing.Size(184, 19);
            this.mlblInstruction.TabIndex = 7;
            this.mlblInstruction.Text = "Please select file to copy data.";
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.Location = new System.Drawing.Point(300, 296);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(75, 23);
            this.mbtnCancel.TabIndex = 15;
            this.mbtnCancel.Text = "Cancel";
            this.mbtnCancel.UseSelectable = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 213);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // mcbOverWrite
            // 
            this.mcbOverWrite.AutoSize = true;
            this.mcbOverWrite.Location = new System.Drawing.Point(26, 171);
            this.mcbOverWrite.Name = "mcbOverWrite";
            this.mcbOverWrite.Size = new System.Drawing.Size(117, 15);
            this.mcbOverWrite.TabIndex = 16;
            this.mcbOverWrite.Text = "Overwrite Existing";
            this.mcbOverWrite.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 141);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(29, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "File";
            // 
            // frm_Importer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 345);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mcbOverWrite);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mlblInstruction);
            this.Controls.Add(this.mbtnImport);
            this.Controls.Add(this.mtxtFilePath);
            this.Controls.Add(this.mbtnOpenFile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Importer";
            this.Resizable = false;
            this.Text = "Import File";
            this.Load += new System.EventHandler(this.frm_Importer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroButton mbtnOpenFile;
        private MetroFramework.Controls.MetroTextBox mtxtFilePath;
        private MetroFramework.Controls.MetroButton mbtnImport;
        private MetroFramework.Controls.MetroLabel mlblInstruction;
        private MetroFramework.Controls.MetroButton mbtnCancel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox mcbOverWrite;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}