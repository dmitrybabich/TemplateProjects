namespace WindowsApplication1
{
    partial class Form1
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
            DevExpress.XtraEditors.TileItemFrame tileItemFrame1 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame2 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame3 = new DevExpress.XtraEditors.TileItemFrame();
            this.pnlMain = new DevExpress.XtraEditors.TileControl();
            this.tgMain = new DevExpress.XtraEditors.TileGroup();
            this.tiListing = new DevExpress.XtraEditors.TileItem();
            this.tiUserManagement = new DevExpress.XtraEditors.TileItem();
            this.tiSettings = new DevExpress.XtraEditors.TileItem();
            this.tiAgents = new DevExpress.XtraEditors.TileItem();
            this.tiResearch = new DevExpress.XtraEditors.TileItem();
            this.tgUtils = new DevExpress.XtraEditors.TileGroup();
            this.tiStats = new DevExpress.XtraEditors.TileItem();
            this.tiZillow = new DevExpress.XtraEditors.TileItem();
            this.tiBanks = new DevExpress.XtraEditors.TileItem();
            this.tiLoanCalc = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Groups.Add(this.tgMain);
            this.pnlMain.Groups.Add(this.tgUtils);
            this.pnlMain.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.pnlMain.ItemAppearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlMain.ItemAppearance.Options.UseFont = true;
            this.pnlMain.ItemSize = 130;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(58, 18, 18, 18);
            this.pnlMain.Size = new System.Drawing.Size(963, 699);
            this.pnlMain.TabIndex = 1;
            // 
            // tgMain
            // 
            this.tgMain.Items.Add(this.tiListing);
            this.tgMain.Items.Add(this.tiUserManagement);
            this.tgMain.Items.Add(this.tiSettings);
            this.tgMain.Items.Add(this.tiAgents);
            this.tgMain.Items.Add(this.tiResearch);
            this.tgMain.Name = "tgMain";
            // 
            // tiListing
            // 
            this.tiListing.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tiListing.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            this.tiListing.CurrentFrameIndex = 99;
            this.tiListing.FrameAnimationInterval = 100;
            tileItemFrame1.AnimateBackgroundImage = true;
            tileItemFrame1.AnimateImage = true;
            tileItemFrame1.AnimateText = true;
            tileItemFrame1.Text = "Test";
            tileItemFrame1.UseBackgroundImage = true;
            tileItemFrame1.UseImage = true;
            tileItemFrame1.UseText = true;
            tileItemFrame2.AnimateBackgroundImage = true;
            tileItemFrame2.AnimateImage = true;
            tileItemFrame2.AnimateText = true;
            tileItemFrame2.Text = "Test2";
            tileItemFrame2.UseBackgroundImage = true;
            tileItemFrame2.UseImage = true;
            tileItemFrame2.UseText = true;
            tileItemFrame3.AnimateBackgroundImage = true;
            tileItemFrame3.AnimateImage = true;
            tileItemFrame3.AnimateText = true;
            tileItemFrame3.Text = "Test3";
            tileItemFrame3.UseBackgroundImage = true;
            tileItemFrame3.UseImage = true;
            tileItemFrame3.UseText = true;
            this.tiListing.Frames.Add(tileItemFrame1);
            this.tiListing.Frames.Add(tileItemFrame2);
            this.tiListing.Frames.Add(tileItemFrame3);
            this.tiListing.IsLarge = true;
            this.tiListing.Name = "tiListing";
            this.tiListing.Padding = new System.Windows.Forms.Padding(0);
            this.tiListing.Text = "Listings";
            // 
            // tiUserManagement
            // 
            this.tiUserManagement.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(220)))));
            this.tiUserManagement.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.tiUserManagement.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(184)))), ((int)(((byte)(225)))));
            this.tiUserManagement.Appearance.Options.UseBackColor = true;
            this.tiUserManagement.Appearance.Options.UseBorderColor = true;
            this.tiUserManagement.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tiUserManagement.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            this.tiUserManagement.Name = "tiUserManagement";
            this.tiUserManagement.Text = "User Management";
            this.tiUserManagement.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            // 
            // tiSettings
            // 
            this.tiSettings.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(175)))), ((int)(((byte)(14)))));
            this.tiSettings.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.tiSettings.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(203)))), ((int)(((byte)(52)))));
            this.tiSettings.Appearance.Options.UseBackColor = true;
            this.tiSettings.Appearance.Options.UseBorderColor = true;
            this.tiSettings.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tiSettings.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            this.tiSettings.Name = "tiSettings";
            this.tiSettings.Text = "System Information";
            this.tiSettings.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            // 
            // tiAgents
            // 
            this.tiAgents.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tiAgents.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tiAgents.Appearance.Options.UseBackColor = true;
            this.tiAgents.Appearance.Options.UseBorderColor = true;
            this.tiAgents.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tiAgents.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            this.tiAgents.IsLarge = true;
            this.tiAgents.Name = "tiAgents";
            this.tiAgents.Text = "Agents";
            // 
            // tiResearch
            // 
            this.tiResearch.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.tiResearch.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(200)))), ((int)(((byte)(26)))));
            this.tiResearch.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(187)))), ((int)(((byte)(38)))));
            this.tiResearch.Appearance.Options.UseBackColor = true;
            this.tiResearch.Appearance.Options.UseBorderColor = true;
            this.tiResearch.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tiResearch.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            this.tiResearch.Name = "tiResearch";
            this.tiResearch.Text = "Research";
            this.tiResearch.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            // 
            // tgUtils
            // 
            this.tgUtils.Items.Add(this.tiStats);
            this.tgUtils.Items.Add(this.tiZillow);
            this.tgUtils.Items.Add(this.tiBanks);
            this.tgUtils.Items.Add(this.tiLoanCalc);
            this.tgUtils.Name = "tgUtils";
            // 
            // tiStats
            // 
            this.tiStats.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(82)))), ((int)(((byte)(162)))));
            this.tiStats.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.tiStats.Appearance.Options.UseBackColor = true;
            this.tiStats.Appearance.Options.UseBorderColor = true;
            this.tiStats.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tiStats.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            this.tiStats.ImageToTextIndent = 20;
            this.tiStats.IsLarge = true;
            this.tiStats.Name = "tiStats";
            this.tiStats.Text = "Statistics";
            this.tiStats.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            // 
            // tiZillow
            // 
            this.tiZillow.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(199)))), ((int)(((byte)(227)))));
            this.tiZillow.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            this.tiZillow.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(199)))), ((int)(((byte)(227)))));
            this.tiZillow.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(119)))), ((int)(((byte)(187)))));
            this.tiZillow.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.tiZillow.Appearance.Options.UseBackColor = true;
            this.tiZillow.Appearance.Options.UseBorderColor = true;
            this.tiZillow.Appearance.Options.UseForeColor = true;
            this.tiZillow.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tiZillow.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            this.tiZillow.IsLarge = true;
            this.tiZillow.Name = "tiZillow";
            this.tiZillow.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            // 
            // tiBanks
            // 
            this.tiBanks.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.tiBanks.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(116)))), ((int)(((byte)(39)))));
            this.tiBanks.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(137)))), ((int)(((byte)(71)))));
            this.tiBanks.Appearance.Options.UseBackColor = true;
            this.tiBanks.Appearance.Options.UseBorderColor = true;
            this.tiBanks.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tiBanks.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            this.tiBanks.Name = "tiBanks";
            this.tiBanks.Text = "Mortgage Rates";
            this.tiBanks.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            // 
            // tiLoanCalc
            // 
            this.tiLoanCalc.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(33)))), ((int)(((byte)(63)))));
            this.tiLoanCalc.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(40)))), ((int)(((byte)(77)))));
            this.tiLoanCalc.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.tiLoanCalc.Appearance.Options.UseBackColor = true;
            this.tiLoanCalc.Appearance.Options.UseBorderColor = true;
            this.tiLoanCalc.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tiLoanCalc.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            this.tiLoanCalc.Name = "tiLoanCalc";
            this.tiLoanCalc.Text = "Loan Calculator";
            this.tiLoanCalc.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 699);
            this.Controls.Add(this.pnlMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl pnlMain;
        private DevExpress.XtraEditors.TileGroup tgMain;
        private DevExpress.XtraEditors.TileItem tiListing;
        private DevExpress.XtraEditors.TileItem tiUserManagement;
        private DevExpress.XtraEditors.TileItem tiSettings;
        private DevExpress.XtraEditors.TileItem tiAgents;
        private DevExpress.XtraEditors.TileItem tiResearch;
        private DevExpress.XtraEditors.TileGroup tgUtils;
        private DevExpress.XtraEditors.TileItem tiStats;
        private DevExpress.XtraEditors.TileItem tiZillow;
        private DevExpress.XtraEditors.TileItem tiBanks;
        private DevExpress.XtraEditors.TileItem tiLoanCalc;
    }
}

