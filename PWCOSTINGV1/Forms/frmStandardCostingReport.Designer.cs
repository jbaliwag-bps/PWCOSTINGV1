namespace PWCOSTINGV1.Forms
{
    partial class frmStandardCostingReport
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
            this.mbtnPreview = new MetroFramework.Controls.MetroButton();
            this.mbtnPrint = new MetroFramework.Controls.MetroButton();
            this.mbtnExport = new MetroFramework.Controls.MetroButton();
            this.mbtnGenerate = new MetroFramework.Controls.MetroButton();
            this.mcbMPT = new MetroFramework.Controls.MetroCheckBox();
            this.mcbItemTabSheet = new MetroFramework.Controls.MetroCheckBox();
            this.mcbSMCost = new MetroFramework.Controls.MetroCheckBox();
            this.mcbWMPT = new MetroFramework.Controls.MetroCheckBox();
            this.mcbWFreight = new MetroFramework.Controls.MetroCheckBox();
            this.mcbF2017Purge = new MetroFramework.Controls.MetroCheckBox();
            this.mcbTenpQuot = new MetroFramework.Controls.MetroCheckBox();
            this.mcbF2013MPT = new MetroFramework.Controls.MetroCheckBox();
            this.mcbF2013 = new MetroFramework.Controls.MetroCheckBox();
            this.mcbPriceQuot = new MetroFramework.Controls.MetroCheckBox();
            this.mtxtReviPosition2 = new MetroFramework.Controls.MetroTextBox();
            this.mtxtReviName2 = new MetroFramework.Controls.MetroTextBox();
            this.mtxtReviPosition1 = new MetroFramework.Controls.MetroTextBox();
            this.mtxtReviName1 = new MetroFramework.Controls.MetroTextBox();
            this.mtxtPrepPosition2 = new MetroFramework.Controls.MetroTextBox();
            this.mtxtPrepName2 = new MetroFramework.Controls.MetroTextBox();
            this.mtxtPrepPosition1 = new MetroFramework.Controls.MetroTextBox();
            this.mtxtPrepName1 = new MetroFramework.Controls.MetroTextBox();
            this.mtxtApprPosition2 = new MetroFramework.Controls.MetroTextBox();
            this.mtxtApprName2 = new MetroFramework.Controls.MetroTextBox();
            this.mtxtApprPosition1 = new MetroFramework.Controls.MetroTextBox();
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.mbtnModify = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mbtnSearchItem = new MetroFramework.Controls.MetroButton();
            this.mtxtApprName1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtxtItemDesc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtxtItemNo = new MetroFramework.Controls.MetroTextBox();
            this.mlblItemNo = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtYear = new MetroFramework.Controls.MetroTextBox();
            this.mdtDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtxtMPT = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // mbtnPreview
            // 
            this.mbtnPreview.Location = new System.Drawing.Point(747, 492);
            this.mbtnPreview.Name = "mbtnPreview";
            this.mbtnPreview.Size = new System.Drawing.Size(75, 23);
            this.mbtnPreview.TabIndex = 148;
            this.mbtnPreview.Text = "Preview";
            this.mbtnPreview.UseSelectable = true;
            this.mbtnPreview.Click += new System.EventHandler(this.mbtnPreview_Click);
            // 
            // mbtnPrint
            // 
            this.mbtnPrint.Location = new System.Drawing.Point(671, 492);
            this.mbtnPrint.Name = "mbtnPrint";
            this.mbtnPrint.Size = new System.Drawing.Size(75, 23);
            this.mbtnPrint.TabIndex = 147;
            this.mbtnPrint.Text = "Print";
            this.mbtnPrint.UseSelectable = true;
            this.mbtnPrint.Click += new System.EventHandler(this.mbtnPrint_Click);
            // 
            // mbtnExport
            // 
            this.mbtnExport.Location = new System.Drawing.Point(595, 492);
            this.mbtnExport.Name = "mbtnExport";
            this.mbtnExport.Size = new System.Drawing.Size(75, 23);
            this.mbtnExport.TabIndex = 146;
            this.mbtnExport.Text = "Export";
            this.mbtnExport.UseSelectable = true;
            this.mbtnExport.Click += new System.EventHandler(this.mbtnExport_Click);
            // 
            // mbtnGenerate
            // 
            this.mbtnGenerate.Location = new System.Drawing.Point(519, 492);
            this.mbtnGenerate.Name = "mbtnGenerate";
            this.mbtnGenerate.Size = new System.Drawing.Size(75, 23);
            this.mbtnGenerate.TabIndex = 145;
            this.mbtnGenerate.Text = "Generate";
            this.mbtnGenerate.UseSelectable = true;
            this.mbtnGenerate.Click += new System.EventHandler(this.mbtnGenerate_Click);
            // 
            // mcbMPT
            // 
            this.mcbMPT.AutoSize = true;
            this.mcbMPT.Location = new System.Drawing.Point(519, 425);
            this.mcbMPT.Name = "mcbMPT";
            this.mcbMPT.Size = new System.Drawing.Size(175, 15);
            this.mcbMPT.TabIndex = 144;
            this.mcbMPT.Text = "Manufacturing Process Time";
            this.mcbMPT.UseSelectable = true;
            // 
            // mcbItemTabSheet
            // 
            this.mcbItemTabSheet.AutoSize = true;
            this.mcbItemTabSheet.Location = new System.Drawing.Point(519, 399);
            this.mcbItemTabSheet.Name = "mcbItemTabSheet";
            this.mcbItemTabSheet.Size = new System.Drawing.Size(139, 15);
            this.mcbItemTabSheet.TabIndex = 143;
            this.mcbItemTabSheet.Text = "Item Tabulation Sheet";
            this.mcbItemTabSheet.UseSelectable = true;
            // 
            // mcbSMCost
            // 
            this.mcbSMCost.AutoSize = true;
            this.mcbSMCost.Location = new System.Drawing.Point(519, 373);
            this.mcbSMCost.Name = "mcbSMCost";
            this.mcbSMCost.Size = new System.Drawing.Size(143, 15);
            this.mcbSMCost.TabIndex = 142;
            this.mcbSMCost.Text = "Standard Material Cost";
            this.mcbSMCost.UseSelectable = true;
            // 
            // mcbWMPT
            // 
            this.mcbWMPT.AutoSize = true;
            this.mcbWMPT.Location = new System.Drawing.Point(554, 302);
            this.mcbWMPT.Name = "mcbWMPT";
            this.mcbWMPT.Size = new System.Drawing.Size(65, 15);
            this.mcbWMPT.TabIndex = 141;
            this.mcbWMPT.Text = "w/ MPT";
            this.mcbWMPT.UseSelectable = true;
            // 
            // mcbWFreight
            // 
            this.mcbWFreight.AutoSize = true;
            this.mcbWFreight.Location = new System.Drawing.Point(554, 270);
            this.mcbWFreight.Name = "mcbWFreight";
            this.mcbWFreight.Size = new System.Drawing.Size(77, 15);
            this.mcbWFreight.TabIndex = 140;
            this.mcbWFreight.Text = "w/ Freight";
            this.mcbWFreight.UseSelectable = true;
            // 
            // mcbF2017Purge
            // 
            this.mcbF2017Purge.AutoSize = true;
            this.mcbF2017Purge.Location = new System.Drawing.Point(536, 240);
            this.mcbF2017Purge.Name = "mcbF2017Purge";
            this.mcbF2017Purge.Size = new System.Drawing.Size(139, 15);
            this.mcbF2017Purge.TabIndex = 139;
            this.mcbF2017Purge.Text = "2017 Format w/ Purge";
            this.mcbF2017Purge.UseSelectable = true;
            // 
            // mcbTenpQuot
            // 
            this.mcbTenpQuot.AutoSize = true;
            this.mcbTenpQuot.Location = new System.Drawing.Point(537, 212);
            this.mcbTenpQuot.Name = "mcbTenpQuot";
            this.mcbTenpQuot.Size = new System.Drawing.Size(138, 15);
            this.mcbTenpQuot.TabIndex = 138;
            this.mcbTenpQuot.Text = "Temporary Quotation";
            this.mcbTenpQuot.UseSelectable = true;
            // 
            // mcbF2013MPT
            // 
            this.mcbF2013MPT.AutoSize = true;
            this.mcbF2013MPT.Location = new System.Drawing.Point(537, 184);
            this.mcbF2013MPT.Name = "mcbF2013MPT";
            this.mcbF2013MPT.Size = new System.Drawing.Size(133, 15);
            this.mcbF2013MPT.TabIndex = 137;
            this.mcbF2013MPT.Text = "2013 Format w/ MPT";
            this.mcbF2013MPT.UseSelectable = true;
            // 
            // mcbF2013
            // 
            this.mcbF2013.AutoSize = true;
            this.mcbF2013.Location = new System.Drawing.Point(537, 157);
            this.mcbF2013.Name = "mcbF2013";
            this.mcbF2013.Size = new System.Drawing.Size(88, 15);
            this.mcbF2013.TabIndex = 136;
            this.mcbF2013.Text = "2013 Format";
            this.mcbF2013.UseSelectable = true;
            // 
            // mcbPriceQuot
            // 
            this.mcbPriceQuot.AutoSize = true;
            this.mcbPriceQuot.Location = new System.Drawing.Point(519, 131);
            this.mcbPriceQuot.Name = "mcbPriceQuot";
            this.mcbPriceQuot.Size = new System.Drawing.Size(106, 15);
            this.mcbPriceQuot.TabIndex = 135;
            this.mcbPriceQuot.Text = "Price Quotation";
            this.mcbPriceQuot.UseSelectable = true;
            // 
            // mtxtReviPosition2
            // 
            // 
            // 
            // 
            this.mtxtReviPosition2.CustomButton.Image = null;
            this.mtxtReviPosition2.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtReviPosition2.CustomButton.Name = "";
            this.mtxtReviPosition2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtReviPosition2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtReviPosition2.CustomButton.TabIndex = 1;
            this.mtxtReviPosition2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtReviPosition2.CustomButton.UseSelectable = true;
            this.mtxtReviPosition2.CustomButton.Visible = false;
            this.mtxtReviPosition2.Lines = new string[0];
            this.mtxtReviPosition2.Location = new System.Drawing.Point(302, 390);
            this.mtxtReviPosition2.MaxLength = 32767;
            this.mtxtReviPosition2.Name = "mtxtReviPosition2";
            this.mtxtReviPosition2.PasswordChar = '\0';
            this.mtxtReviPosition2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtReviPosition2.SelectedText = "";
            this.mtxtReviPosition2.SelectionLength = 0;
            this.mtxtReviPosition2.SelectionStart = 0;
            this.mtxtReviPosition2.ShortcutsEnabled = true;
            this.mtxtReviPosition2.Size = new System.Drawing.Size(160, 23);
            this.mtxtReviPosition2.TabIndex = 132;
            this.mtxtReviPosition2.UseSelectable = true;
            this.mtxtReviPosition2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtReviPosition2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtReviName2
            // 
            // 
            // 
            // 
            this.mtxtReviName2.CustomButton.Image = null;
            this.mtxtReviName2.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtReviName2.CustomButton.Name = "";
            this.mtxtReviName2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtReviName2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtReviName2.CustomButton.TabIndex = 1;
            this.mtxtReviName2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtReviName2.CustomButton.UseSelectable = true;
            this.mtxtReviName2.CustomButton.Visible = false;
            this.mtxtReviName2.Lines = new string[0];
            this.mtxtReviName2.Location = new System.Drawing.Point(125, 390);
            this.mtxtReviName2.MaxLength = 32767;
            this.mtxtReviName2.Name = "mtxtReviName2";
            this.mtxtReviName2.PasswordChar = '\0';
            this.mtxtReviName2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtReviName2.SelectedText = "";
            this.mtxtReviName2.SelectionLength = 0;
            this.mtxtReviName2.SelectionStart = 0;
            this.mtxtReviName2.ShortcutsEnabled = true;
            this.mtxtReviName2.Size = new System.Drawing.Size(160, 23);
            this.mtxtReviName2.TabIndex = 131;
            this.mtxtReviName2.UseSelectable = true;
            this.mtxtReviName2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtReviName2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtReviPosition1
            // 
            // 
            // 
            // 
            this.mtxtReviPosition1.CustomButton.Image = null;
            this.mtxtReviPosition1.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtReviPosition1.CustomButton.Name = "";
            this.mtxtReviPosition1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtReviPosition1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtReviPosition1.CustomButton.TabIndex = 1;
            this.mtxtReviPosition1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtReviPosition1.CustomButton.UseSelectable = true;
            this.mtxtReviPosition1.CustomButton.Visible = false;
            this.mtxtReviPosition1.Lines = new string[0];
            this.mtxtReviPosition1.Location = new System.Drawing.Point(302, 367);
            this.mtxtReviPosition1.MaxLength = 32767;
            this.mtxtReviPosition1.Name = "mtxtReviPosition1";
            this.mtxtReviPosition1.PasswordChar = '\0';
            this.mtxtReviPosition1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtReviPosition1.SelectedText = "";
            this.mtxtReviPosition1.SelectionLength = 0;
            this.mtxtReviPosition1.SelectionStart = 0;
            this.mtxtReviPosition1.ShortcutsEnabled = true;
            this.mtxtReviPosition1.Size = new System.Drawing.Size(160, 23);
            this.mtxtReviPosition1.TabIndex = 130;
            this.mtxtReviPosition1.UseSelectable = true;
            this.mtxtReviPosition1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtReviPosition1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtReviName1
            // 
            // 
            // 
            // 
            this.mtxtReviName1.CustomButton.Image = null;
            this.mtxtReviName1.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtReviName1.CustomButton.Name = "";
            this.mtxtReviName1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtReviName1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtReviName1.CustomButton.TabIndex = 1;
            this.mtxtReviName1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtReviName1.CustomButton.UseSelectable = true;
            this.mtxtReviName1.CustomButton.Visible = false;
            this.mtxtReviName1.Lines = new string[0];
            this.mtxtReviName1.Location = new System.Drawing.Point(125, 367);
            this.mtxtReviName1.MaxLength = 32767;
            this.mtxtReviName1.Name = "mtxtReviName1";
            this.mtxtReviName1.PasswordChar = '\0';
            this.mtxtReviName1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtReviName1.SelectedText = "";
            this.mtxtReviName1.SelectionLength = 0;
            this.mtxtReviName1.SelectionStart = 0;
            this.mtxtReviName1.ShortcutsEnabled = true;
            this.mtxtReviName1.Size = new System.Drawing.Size(160, 23);
            this.mtxtReviName1.TabIndex = 129;
            this.mtxtReviName1.UseSelectable = true;
            this.mtxtReviName1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtReviName1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtPrepPosition2
            // 
            // 
            // 
            // 
            this.mtxtPrepPosition2.CustomButton.Image = null;
            this.mtxtPrepPosition2.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtPrepPosition2.CustomButton.Name = "";
            this.mtxtPrepPosition2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPrepPosition2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPrepPosition2.CustomButton.TabIndex = 1;
            this.mtxtPrepPosition2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPrepPosition2.CustomButton.UseSelectable = true;
            this.mtxtPrepPosition2.CustomButton.Visible = false;
            this.mtxtPrepPosition2.Lines = new string[0];
            this.mtxtPrepPosition2.Location = new System.Drawing.Point(302, 336);
            this.mtxtPrepPosition2.MaxLength = 32767;
            this.mtxtPrepPosition2.Name = "mtxtPrepPosition2";
            this.mtxtPrepPosition2.PasswordChar = '\0';
            this.mtxtPrepPosition2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPrepPosition2.SelectedText = "";
            this.mtxtPrepPosition2.SelectionLength = 0;
            this.mtxtPrepPosition2.SelectionStart = 0;
            this.mtxtPrepPosition2.ShortcutsEnabled = true;
            this.mtxtPrepPosition2.Size = new System.Drawing.Size(160, 23);
            this.mtxtPrepPosition2.TabIndex = 128;
            this.mtxtPrepPosition2.UseSelectable = true;
            this.mtxtPrepPosition2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPrepPosition2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtPrepName2
            // 
            // 
            // 
            // 
            this.mtxtPrepName2.CustomButton.Image = null;
            this.mtxtPrepName2.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtPrepName2.CustomButton.Name = "";
            this.mtxtPrepName2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPrepName2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPrepName2.CustomButton.TabIndex = 1;
            this.mtxtPrepName2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPrepName2.CustomButton.UseSelectable = true;
            this.mtxtPrepName2.CustomButton.Visible = false;
            this.mtxtPrepName2.Lines = new string[0];
            this.mtxtPrepName2.Location = new System.Drawing.Point(125, 336);
            this.mtxtPrepName2.MaxLength = 32767;
            this.mtxtPrepName2.Name = "mtxtPrepName2";
            this.mtxtPrepName2.PasswordChar = '\0';
            this.mtxtPrepName2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPrepName2.SelectedText = "";
            this.mtxtPrepName2.SelectionLength = 0;
            this.mtxtPrepName2.SelectionStart = 0;
            this.mtxtPrepName2.ShortcutsEnabled = true;
            this.mtxtPrepName2.Size = new System.Drawing.Size(160, 23);
            this.mtxtPrepName2.TabIndex = 127;
            this.mtxtPrepName2.UseSelectable = true;
            this.mtxtPrepName2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPrepName2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtPrepPosition1
            // 
            // 
            // 
            // 
            this.mtxtPrepPosition1.CustomButton.Image = null;
            this.mtxtPrepPosition1.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtPrepPosition1.CustomButton.Name = "";
            this.mtxtPrepPosition1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPrepPosition1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPrepPosition1.CustomButton.TabIndex = 1;
            this.mtxtPrepPosition1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPrepPosition1.CustomButton.UseSelectable = true;
            this.mtxtPrepPosition1.CustomButton.Visible = false;
            this.mtxtPrepPosition1.Lines = new string[0];
            this.mtxtPrepPosition1.Location = new System.Drawing.Point(302, 313);
            this.mtxtPrepPosition1.MaxLength = 32767;
            this.mtxtPrepPosition1.Name = "mtxtPrepPosition1";
            this.mtxtPrepPosition1.PasswordChar = '\0';
            this.mtxtPrepPosition1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPrepPosition1.SelectedText = "";
            this.mtxtPrepPosition1.SelectionLength = 0;
            this.mtxtPrepPosition1.SelectionStart = 0;
            this.mtxtPrepPosition1.ShortcutsEnabled = true;
            this.mtxtPrepPosition1.Size = new System.Drawing.Size(160, 23);
            this.mtxtPrepPosition1.TabIndex = 126;
            this.mtxtPrepPosition1.UseSelectable = true;
            this.mtxtPrepPosition1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPrepPosition1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtPrepName1
            // 
            // 
            // 
            // 
            this.mtxtPrepName1.CustomButton.Image = null;
            this.mtxtPrepName1.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtPrepName1.CustomButton.Name = "";
            this.mtxtPrepName1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPrepName1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPrepName1.CustomButton.TabIndex = 1;
            this.mtxtPrepName1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPrepName1.CustomButton.UseSelectable = true;
            this.mtxtPrepName1.CustomButton.Visible = false;
            this.mtxtPrepName1.Lines = new string[0];
            this.mtxtPrepName1.Location = new System.Drawing.Point(125, 313);
            this.mtxtPrepName1.MaxLength = 32767;
            this.mtxtPrepName1.Name = "mtxtPrepName1";
            this.mtxtPrepName1.PasswordChar = '\0';
            this.mtxtPrepName1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPrepName1.SelectedText = "";
            this.mtxtPrepName1.SelectionLength = 0;
            this.mtxtPrepName1.SelectionStart = 0;
            this.mtxtPrepName1.ShortcutsEnabled = true;
            this.mtxtPrepName1.Size = new System.Drawing.Size(160, 23);
            this.mtxtPrepName1.TabIndex = 125;
            this.mtxtPrepName1.UseSelectable = true;
            this.mtxtPrepName1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPrepName1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtApprPosition2
            // 
            // 
            // 
            // 
            this.mtxtApprPosition2.CustomButton.Image = null;
            this.mtxtApprPosition2.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtApprPosition2.CustomButton.Name = "";
            this.mtxtApprPosition2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtApprPosition2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtApprPosition2.CustomButton.TabIndex = 1;
            this.mtxtApprPosition2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtApprPosition2.CustomButton.UseSelectable = true;
            this.mtxtApprPosition2.CustomButton.Visible = false;
            this.mtxtApprPosition2.Lines = new string[0];
            this.mtxtApprPosition2.Location = new System.Drawing.Point(302, 283);
            this.mtxtApprPosition2.MaxLength = 32767;
            this.mtxtApprPosition2.Name = "mtxtApprPosition2";
            this.mtxtApprPosition2.PasswordChar = '\0';
            this.mtxtApprPosition2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtApprPosition2.SelectedText = "";
            this.mtxtApprPosition2.SelectionLength = 0;
            this.mtxtApprPosition2.SelectionStart = 0;
            this.mtxtApprPosition2.ShortcutsEnabled = true;
            this.mtxtApprPosition2.Size = new System.Drawing.Size(160, 23);
            this.mtxtApprPosition2.TabIndex = 124;
            this.mtxtApprPosition2.UseSelectable = true;
            this.mtxtApprPosition2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtApprPosition2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtApprName2
            // 
            // 
            // 
            // 
            this.mtxtApprName2.CustomButton.Image = null;
            this.mtxtApprName2.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtApprName2.CustomButton.Name = "";
            this.mtxtApprName2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtApprName2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtApprName2.CustomButton.TabIndex = 1;
            this.mtxtApprName2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtApprName2.CustomButton.UseSelectable = true;
            this.mtxtApprName2.CustomButton.Visible = false;
            this.mtxtApprName2.Lines = new string[0];
            this.mtxtApprName2.Location = new System.Drawing.Point(125, 283);
            this.mtxtApprName2.MaxLength = 32767;
            this.mtxtApprName2.Name = "mtxtApprName2";
            this.mtxtApprName2.PasswordChar = '\0';
            this.mtxtApprName2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtApprName2.SelectedText = "";
            this.mtxtApprName2.SelectionLength = 0;
            this.mtxtApprName2.SelectionStart = 0;
            this.mtxtApprName2.ShortcutsEnabled = true;
            this.mtxtApprName2.Size = new System.Drawing.Size(160, 23);
            this.mtxtApprName2.TabIndex = 123;
            this.mtxtApprName2.UseSelectable = true;
            this.mtxtApprName2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtApprName2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtApprPosition1
            // 
            this.mtxtApprPosition1.AccessibleDescription = "";
            // 
            // 
            // 
            this.mtxtApprPosition1.CustomButton.Image = null;
            this.mtxtApprPosition1.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtApprPosition1.CustomButton.Name = "";
            this.mtxtApprPosition1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtApprPosition1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtApprPosition1.CustomButton.TabIndex = 1;
            this.mtxtApprPosition1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtApprPosition1.CustomButton.UseSelectable = true;
            this.mtxtApprPosition1.CustomButton.Visible = false;
            this.mtxtApprPosition1.Lines = new string[0];
            this.mtxtApprPosition1.Location = new System.Drawing.Point(302, 260);
            this.mtxtApprPosition1.MaxLength = 32767;
            this.mtxtApprPosition1.Name = "mtxtApprPosition1";
            this.mtxtApprPosition1.PasswordChar = '\0';
            this.mtxtApprPosition1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtApprPosition1.SelectedText = "";
            this.mtxtApprPosition1.SelectionLength = 0;
            this.mtxtApprPosition1.SelectionStart = 0;
            this.mtxtApprPosition1.ShortcutsEnabled = true;
            this.mtxtApprPosition1.Size = new System.Drawing.Size(160, 23);
            this.mtxtApprPosition1.TabIndex = 122;
            this.mtxtApprPosition1.UseSelectable = true;
            this.mtxtApprPosition1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtApprPosition1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.Location = new System.Drawing.Point(386, 492);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(75, 23);
            this.mbtnCancel.TabIndex = 121;
            this.mbtnCancel.Text = "Cancel";
            this.mbtnCancel.UseSelectable = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // mbtnModify
            // 
            this.mbtnModify.Location = new System.Drawing.Point(310, 492);
            this.mbtnModify.Name = "mbtnModify";
            this.mbtnModify.Size = new System.Drawing.Size(75, 23);
            this.mbtnModify.TabIndex = 120;
            this.mbtnModify.Text = "Modify";
            this.mbtnModify.UseSelectable = true;
            this.mbtnModify.Click += new System.EventHandler(this.mbtnModify_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(32, 464);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(39, 19);
            this.metroLabel7.TabIndex = 119;
            this.metroLabel7.Text = "Date:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(29, 435);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(39, 19);
            this.metroLabel6.TabIndex = 118;
            this.metroLabel6.Text = "Year:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(32, 367);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(85, 19);
            this.metroLabel5.TabIndex = 117;
            this.metroLabel5.Text = "Reviewed By:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(32, 313);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(85, 19);
            this.metroLabel4.TabIndex = 116;
            this.metroLabel4.Text = "Prepared By:";
            // 
            // mbtnSearchItem
            // 
            this.mbtnSearchItem.Location = new System.Drawing.Point(371, 131);
            this.mbtnSearchItem.Name = "mbtnSearchItem";
            this.mbtnSearchItem.Size = new System.Drawing.Size(90, 23);
            this.mbtnSearchItem.TabIndex = 115;
            this.mbtnSearchItem.Text = "List";
            this.mbtnSearchItem.UseSelectable = true;
            this.mbtnSearchItem.Click += new System.EventHandler(this.mbtnSearchItem_Click);
            // 
            // mtxtApprName1
            // 
            // 
            // 
            // 
            this.mtxtApprName1.CustomButton.Image = null;
            this.mtxtApprName1.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtApprName1.CustomButton.Name = "";
            this.mtxtApprName1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtApprName1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtApprName1.CustomButton.TabIndex = 1;
            this.mtxtApprName1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtApprName1.CustomButton.UseSelectable = true;
            this.mtxtApprName1.CustomButton.Visible = false;
            this.mtxtApprName1.Lines = new string[0];
            this.mtxtApprName1.Location = new System.Drawing.Point(125, 260);
            this.mtxtApprName1.MaxLength = 32767;
            this.mtxtApprName1.Name = "mtxtApprName1";
            this.mtxtApprName1.PasswordChar = '\0';
            this.mtxtApprName1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtApprName1.SelectedText = "";
            this.mtxtApprName1.SelectionLength = 0;
            this.mtxtApprName1.SelectionStart = 0;
            this.mtxtApprName1.ShortcutsEnabled = true;
            this.mtxtApprName1.Size = new System.Drawing.Size(160, 23);
            this.mtxtApprName1.TabIndex = 114;
            this.mtxtApprName1.UseSelectable = true;
            this.mtxtApprName1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtApprName1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(32, 260);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 113;
            this.metroLabel3.Text = "Approved By:";
            // 
            // mtxtItemDesc
            // 
            // 
            // 
            // 
            this.mtxtItemDesc.CustomButton.Image = null;
            this.mtxtItemDesc.CustomButton.Location = new System.Drawing.Point(280, 2);
            this.mtxtItemDesc.CustomButton.Name = "";
            this.mtxtItemDesc.CustomButton.Size = new System.Drawing.Size(53, 53);
            this.mtxtItemDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtItemDesc.CustomButton.TabIndex = 1;
            this.mtxtItemDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtItemDesc.CustomButton.UseSelectable = true;
            this.mtxtItemDesc.CustomButton.Visible = false;
            this.mtxtItemDesc.Lines = new string[0];
            this.mtxtItemDesc.Location = new System.Drawing.Point(125, 154);
            this.mtxtItemDesc.MaxLength = 10;
            this.mtxtItemDesc.Multiline = true;
            this.mtxtItemDesc.Name = "mtxtItemDesc";
            this.mtxtItemDesc.PasswordChar = '\0';
            this.mtxtItemDesc.PromptText = "Item Desc.";
            this.mtxtItemDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtItemDesc.SelectedText = "";
            this.mtxtItemDesc.SelectionLength = 0;
            this.mtxtItemDesc.SelectionStart = 0;
            this.mtxtItemDesc.ShortcutsEnabled = true;
            this.mtxtItemDesc.Size = new System.Drawing.Size(336, 58);
            this.mtxtItemDesc.TabIndex = 110;
            this.mtxtItemDesc.UseSelectable = true;
            this.mtxtItemDesc.WaterMark = "Item Desc.";
            this.mtxtItemDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtItemDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 155);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 109;
            this.metroLabel1.Text = "Description";
            // 
            // mtxtItemNo
            // 
            this.mtxtItemNo.AccessibleDescription = "";
            this.mtxtItemNo.AccessibleName = "";
            // 
            // 
            // 
            this.mtxtItemNo.CustomButton.Image = null;
            this.mtxtItemNo.CustomButton.Location = new System.Drawing.Point(225, 1);
            this.mtxtItemNo.CustomButton.Name = "";
            this.mtxtItemNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtItemNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtItemNo.CustomButton.TabIndex = 1;
            this.mtxtItemNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtItemNo.CustomButton.UseSelectable = true;
            this.mtxtItemNo.CustomButton.Visible = false;
            this.mtxtItemNo.Lines = new string[0];
            this.mtxtItemNo.Location = new System.Drawing.Point(125, 131);
            this.mtxtItemNo.MaxLength = 10;
            this.mtxtItemNo.Name = "mtxtItemNo";
            this.mtxtItemNo.PasswordChar = '\0';
            this.mtxtItemNo.PromptText = "Item No.";
            this.mtxtItemNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtItemNo.SelectedText = "";
            this.mtxtItemNo.SelectionLength = 0;
            this.mtxtItemNo.SelectionStart = 0;
            this.mtxtItemNo.ShortcutsEnabled = true;
            this.mtxtItemNo.Size = new System.Drawing.Size(247, 23);
            this.mtxtItemNo.TabIndex = 108;
            this.mtxtItemNo.UseSelectable = true;
            this.mtxtItemNo.WaterMark = "Item No.";
            this.mtxtItemNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtItemNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtItemNo.TextChanged += new System.EventHandler(this.mtxtItemNo_TextChanged);
            // 
            // mlblItemNo
            // 
            this.mlblItemNo.AutoSize = true;
            this.mlblItemNo.Location = new System.Drawing.Point(32, 131);
            this.mlblItemNo.Name = "mlblItemNo";
            this.mlblItemNo.Size = new System.Drawing.Size(60, 19);
            this.mlblItemNo.TabIndex = 107;
            this.mlblItemNo.Text = "Item No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 93);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(431, 25);
            this.label1.TabIndex = 149;
            this.label1.Text = "Parameters                                                                       " +
    "              ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(516, 93);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(306, 25);
            this.label2.TabIndex = 150;
            this.label2.Text = "Options                                                            ";
            // 
            // mtxtYear
            // 
            // 
            // 
            // 
            this.mtxtYear.CustomButton.Image = null;
            this.mtxtYear.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.mtxtYear.CustomButton.Name = "";
            this.mtxtYear.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtYear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtYear.CustomButton.TabIndex = 1;
            this.mtxtYear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtYear.CustomButton.UseSelectable = true;
            this.mtxtYear.CustomButton.Visible = false;
            this.mtxtYear.Enabled = false;
            this.mtxtYear.Lines = new string[0];
            this.mtxtYear.Location = new System.Drawing.Point(125, 429);
            this.mtxtYear.MaxLength = 32767;
            this.mtxtYear.Name = "mtxtYear";
            this.mtxtYear.PasswordChar = '\0';
            this.mtxtYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtYear.SelectedText = "";
            this.mtxtYear.SelectionLength = 0;
            this.mtxtYear.SelectionStart = 0;
            this.mtxtYear.ShortcutsEnabled = true;
            this.mtxtYear.Size = new System.Drawing.Size(160, 23);
            this.mtxtYear.TabIndex = 151;
            this.mtxtYear.UseSelectable = true;
            this.mtxtYear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtYear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mdtDate
            // 
            this.mdtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mdtDate.Location = new System.Drawing.Point(125, 454);
            this.mdtDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtDate.Name = "mdtDate";
            this.mdtDate.Size = new System.Drawing.Size(200, 29);
            this.mdtDate.TabIndex = 133;
            this.mdtDate.ValueChanged += new System.EventHandler(this.mdtDate_ValueChanged);
            this.mdtDate.Validating += new System.ComponentModel.CancelEventHandler(this.mdtDate_Validating);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 214);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 111;
            this.metroLabel2.Text = "MPT";
            // 
            // mtxtMPT
            // 
            // 
            // 
            // 
            this.mtxtMPT.CustomButton.Image = null;
            this.mtxtMPT.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.mtxtMPT.CustomButton.Name = "";
            this.mtxtMPT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtMPT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtMPT.CustomButton.TabIndex = 1;
            this.mtxtMPT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtMPT.CustomButton.UseSelectable = true;
            this.mtxtMPT.CustomButton.Visible = false;
            this.mtxtMPT.Lines = new string[] {
        "16.5600"};
            this.mtxtMPT.Location = new System.Drawing.Point(125, 214);
            this.mtxtMPT.MaxLength = 32767;
            this.mtxtMPT.Name = "mtxtMPT";
            this.mtxtMPT.PasswordChar = '\0';
            this.mtxtMPT.PromptText = "0";
            this.mtxtMPT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtMPT.SelectedText = "";
            this.mtxtMPT.SelectionLength = 0;
            this.mtxtMPT.SelectionStart = 0;
            this.mtxtMPT.ShortcutsEnabled = true;
            this.mtxtMPT.Size = new System.Drawing.Size(170, 23);
            this.mtxtMPT.TabIndex = 112;
            this.mtxtMPT.Text = "16.5600";
            this.mtxtMPT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtMPT.UseSelectable = true;
            this.mtxtMPT.WaterMark = "0";
            this.mtxtMPT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtMPT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtMPT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtMPT_KeyPress);
            // 
            // frmStandardCostingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 574);
            this.Controls.Add(this.mtxtYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mbtnPreview);
            this.Controls.Add(this.mbtnPrint);
            this.Controls.Add(this.mbtnExport);
            this.Controls.Add(this.mbtnGenerate);
            this.Controls.Add(this.mcbMPT);
            this.Controls.Add(this.mcbItemTabSheet);
            this.Controls.Add(this.mcbSMCost);
            this.Controls.Add(this.mcbWMPT);
            this.Controls.Add(this.mcbWFreight);
            this.Controls.Add(this.mcbF2017Purge);
            this.Controls.Add(this.mcbTenpQuot);
            this.Controls.Add(this.mcbF2013MPT);
            this.Controls.Add(this.mcbF2013);
            this.Controls.Add(this.mcbPriceQuot);
            this.Controls.Add(this.mdtDate);
            this.Controls.Add(this.mtxtReviPosition2);
            this.Controls.Add(this.mtxtReviName2);
            this.Controls.Add(this.mtxtReviPosition1);
            this.Controls.Add(this.mtxtReviName1);
            this.Controls.Add(this.mtxtPrepPosition2);
            this.Controls.Add(this.mtxtPrepName2);
            this.Controls.Add(this.mtxtPrepPosition1);
            this.Controls.Add(this.mtxtPrepName1);
            this.Controls.Add(this.mtxtApprPosition2);
            this.Controls.Add(this.mtxtApprName2);
            this.Controls.Add(this.mtxtApprPosition1);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mbtnModify);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mbtnSearchItem);
            this.Controls.Add(this.mtxtApprName1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtxtMPT);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtxtItemDesc);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtxtItemNo);
            this.Controls.Add(this.mlblItemNo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmStandardCostingReport";
            this.Resizable = false;
            this.Tag = "list";
            this.Text = "Standard Costing Report";
            this.Load += new System.EventHandler(this.frmStandardCostingReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mbtnPreview;
        private MetroFramework.Controls.MetroButton mbtnPrint;
        private MetroFramework.Controls.MetroButton mbtnExport;
        private MetroFramework.Controls.MetroButton mbtnGenerate;
        private MetroFramework.Controls.MetroCheckBox mcbMPT;
        private MetroFramework.Controls.MetroCheckBox mcbItemTabSheet;
        private MetroFramework.Controls.MetroCheckBox mcbSMCost;
        private MetroFramework.Controls.MetroCheckBox mcbWMPT;
        private MetroFramework.Controls.MetroCheckBox mcbWFreight;
        private MetroFramework.Controls.MetroCheckBox mcbF2017Purge;
        private MetroFramework.Controls.MetroCheckBox mcbTenpQuot;
        private MetroFramework.Controls.MetroCheckBox mcbF2013MPT;
        private MetroFramework.Controls.MetroCheckBox mcbF2013;
        private MetroFramework.Controls.MetroCheckBox mcbPriceQuot;
        private MetroFramework.Controls.MetroTextBox mtxtReviPosition2;
        private MetroFramework.Controls.MetroTextBox mtxtReviName2;
        private MetroFramework.Controls.MetroTextBox mtxtReviPosition1;
        private MetroFramework.Controls.MetroTextBox mtxtReviName1;
        private MetroFramework.Controls.MetroTextBox mtxtPrepPosition2;
        private MetroFramework.Controls.MetroTextBox mtxtPrepName2;
        private MetroFramework.Controls.MetroTextBox mtxtPrepPosition1;
        private MetroFramework.Controls.MetroTextBox mtxtPrepName1;
        private MetroFramework.Controls.MetroTextBox mtxtApprPosition2;
        private MetroFramework.Controls.MetroTextBox mtxtApprName2;
        private MetroFramework.Controls.MetroTextBox mtxtApprPosition1;
        private MetroFramework.Controls.MetroButton mbtnCancel;
        private MetroFramework.Controls.MetroButton mbtnModify;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton mbtnSearchItem;
        private MetroFramework.Controls.MetroTextBox mtxtApprName1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroTextBox mtxtItemDesc;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroTextBox mtxtItemNo;
        private MetroFramework.Controls.MetroLabel mlblItemNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox mtxtYear;
        private MetroFramework.Controls.MetroDateTime mdtDate;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtxtMPT;


    }
}