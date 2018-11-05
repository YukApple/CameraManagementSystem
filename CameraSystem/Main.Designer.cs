namespace CameraSystem
{
    partial class Main
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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlMainContent = new MetroFramework.Controls.MetroPanel();
            this.lblconnectstatus = new MetroFramework.Controls.MetroLabel();
            this.mpnlSetting = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.flColor = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mrbDark = new MetroFramework.Controls.MetroRadioButton();
            this.mrbLight = new MetroFramework.Controls.MetroRadioButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.pconnect = new System.Windows.Forms.PictureBox();
            this.btnLogout = new MetroFramework.Controls.MetroLink();
            this.btnSetting = new MetroFramework.Controls.MetroLink();
            this.btnClose = new MetroFramework.Controls.MetroLink();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtIpServer = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnCheckServerConnect = new MetroFramework.Controls.MetroButton();
            this.btnSaveIpServer = new MetroFramework.Controls.MetroButton();
            this.txtPortServer = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.mpnlSetting.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pconnect)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainContent.HorizontalScrollbarBarColor = true;
            this.pnlMainContent.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMainContent.HorizontalScrollbarSize = 10;
            this.pnlMainContent.Location = new System.Drawing.Point(13, 63);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(1340, 682);
            this.pnlMainContent.Style = MetroFramework.MetroColorStyle.Green;
            this.pnlMainContent.TabIndex = 0;
            this.pnlMainContent.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlMainContent.VerticalScrollbarBarColor = true;
            this.pnlMainContent.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMainContent.VerticalScrollbarSize = 10;
            // 
            // lblconnectstatus
            // 
            this.lblconnectstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblconnectstatus.AutoSize = true;
            this.lblconnectstatus.Location = new System.Drawing.Point(1172, 10);
            this.lblconnectstatus.Name = "lblconnectstatus";
            this.lblconnectstatus.Size = new System.Drawing.Size(86, 19);
            this.lblconnectstatus.TabIndex = 2;
            this.lblconnectstatus.Text = "Disconnected";
            // 
            // mpnlSetting
            // 
            this.mpnlSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpnlSetting.BackColor = System.Drawing.Color.Transparent;
            this.mpnlSetting.Controls.Add(this.metroTabControl1);
            this.mpnlSetting.Controls.Add(this.metroPanel2);
            this.mpnlSetting.Controls.Add(this.metroLink1);
            this.mpnlSetting.HorizontalScrollbarBarColor = true;
            this.mpnlSetting.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlSetting.HorizontalScrollbarSize = 10;
            this.mpnlSetting.Location = new System.Drawing.Point(1066, 32);
            this.mpnlSetting.Name = "mpnlSetting";
            this.mpnlSetting.Size = new System.Drawing.Size(300, 735);
            this.mpnlSetting.TabIndex = 5;
            this.mpnlSetting.VerticalScrollbarBarColor = true;
            this.mpnlSetting.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlSetting.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(8, 57);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(286, 644);
            this.metroTabControl1.TabIndex = 5;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.metroPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(278, 602);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.metroPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(278, 602);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Theme";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.flColor);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Controls.Add(this.mrbDark);
            this.metroPanel3.Controls.Add(this.mrbLight);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(278, 602);
            this.metroPanel3.TabIndex = 0;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // flColor
            // 
            this.flColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flColor.Location = new System.Drawing.Point(15, 100);
            this.flColor.Name = "flColor";
            this.flColor.Size = new System.Drawing.Size(244, 484);
            this.flColor.TabIndex = 4;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(15, 72);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 25);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Style:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(15, 21);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 25);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Theme:";
            // 
            // mrbDark
            // 
            this.mrbDark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mrbDark.AutoSize = true;
            this.mrbDark.Location = new System.Drawing.Point(169, 55);
            this.mrbDark.Name = "mrbDark";
            this.mrbDark.Size = new System.Drawing.Size(47, 15);
            this.mrbDark.TabIndex = 2;
            this.mrbDark.Text = "Dark";
            this.mrbDark.UseSelectable = true;
            this.mrbDark.CheckedChanged += new System.EventHandler(this.mrbLight_CheckedChanged);
            // 
            // mrbLight
            // 
            this.mrbLight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mrbLight.AutoSize = true;
            this.mrbLight.Location = new System.Drawing.Point(75, 55);
            this.mrbLight.Name = "mrbLight";
            this.mrbLight.Size = new System.Drawing.Size(50, 15);
            this.mrbLight.TabIndex = 2;
            this.mrbLight.Text = "Light";
            this.mrbLight.UseSelectable = true;
            this.mrbLight.CheckedChanged += new System.EventHandler(this.mrbLight_CheckedChanged);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1, 735);
            this.metroPanel2.TabIndex = 4;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLink1
            // 
            this.metroLink1.BackColor = System.Drawing.Color.Transparent;
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.metroLink1.Image = global::CameraSystem.Properties.Resources.back2;
            this.metroLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.ImageSize = 20;
            this.metroLink1.Location = new System.Drawing.Point(8, 3);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.NoFocusImage = global::CameraSystem.Properties.Resources.back2;
            this.metroLink1.Size = new System.Drawing.Size(129, 35);
            this.metroLink1.TabIndex = 3;
            this.metroLink1.Text = "Settings";
            this.metroLink1.UseCustomBackColor = true;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.btnCloseSetting);
            // 
            // pconnect
            // 
            this.pconnect.Image = global::CameraSystem.Properties.Resources.GLOBES_RED;
            this.pconnect.Location = new System.Drawing.Point(1146, 9);
            this.pconnect.Name = "pconnect";
            this.pconnect.Size = new System.Drawing.Size(20, 20);
            this.pconnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pconnect.TabIndex = 4;
            this.pconnect.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Image = global::CameraSystem.Properties.Resources.exit;
            this.btnLogout.Location = new System.Drawing.Point(1267, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NoFocusImage = global::CameraSystem.Properties.Resources.exit;
            this.btnLogout.Size = new System.Drawing.Size(27, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.UseCustomBackColor = true;
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.Image = global::CameraSystem.Properties.Resources.setting;
            this.btnSetting.Location = new System.Drawing.Point(1300, 8);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.NoFocusImage = global::CameraSystem.Properties.Resources.setting;
            this.btnSetting.Size = new System.Drawing.Size(27, 23);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.UseCustomBackColor = true;
            this.btnSetting.UseSelectable = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::CameraSystem.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1333, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.NoFocusImage = global::CameraSystem.Properties.Resources.close;
            this.btnClose.Size = new System.Drawing.Size(27, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnSaveIpServer);
            this.metroPanel1.Controls.Add(this.btnCheckServerConnect);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtPortServer);
            this.metroPanel1.Controls.Add(this.txtIpServer);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(278, 602);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtIpServer
            // 
            this.txtIpServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtIpServer.CustomButton.Image = null;
            this.txtIpServer.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.txtIpServer.CustomButton.Name = "";
            this.txtIpServer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIpServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIpServer.CustomButton.TabIndex = 1;
            this.txtIpServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIpServer.CustomButton.UseSelectable = true;
            this.txtIpServer.CustomButton.Visible = false;
            this.txtIpServer.Lines = new string[0];
            this.txtIpServer.Location = new System.Drawing.Point(13, 56);
            this.txtIpServer.MaxLength = 32767;
            this.txtIpServer.Name = "txtIpServer";
            this.txtIpServer.PasswordChar = '\0';
            this.txtIpServer.PromptText = "Server Input";
            this.txtIpServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIpServer.SelectedText = "";
            this.txtIpServer.SelectionLength = 0;
            this.txtIpServer.SelectionStart = 0;
            this.txtIpServer.ShortcutsEnabled = true;
            this.txtIpServer.Size = new System.Drawing.Size(249, 23);
            this.txtIpServer.TabIndex = 2;
            this.txtIpServer.UseSelectable = true;
            this.txtIpServer.WaterMark = "Server Input";
            this.txtIpServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIpServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(5, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(131, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Server Connect:";
            // 
            // btnCheckServerConnect
            // 
            this.btnCheckServerConnect.Location = new System.Drawing.Point(13, 141);
            this.btnCheckServerConnect.Name = "btnCheckServerConnect";
            this.btnCheckServerConnect.Size = new System.Drawing.Size(101, 34);
            this.btnCheckServerConnect.TabIndex = 4;
            this.btnCheckServerConnect.Text = "Test Connection";
            this.btnCheckServerConnect.UseSelectable = true;
            this.btnCheckServerConnect.Click += new System.EventHandler(this.btnCheckServerConnect_Click);
            // 
            // btnSaveIpServer
            // 
            this.btnSaveIpServer.Location = new System.Drawing.Point(161, 141);
            this.btnSaveIpServer.Name = "btnSaveIpServer";
            this.btnSaveIpServer.Size = new System.Drawing.Size(101, 34);
            this.btnSaveIpServer.TabIndex = 4;
            this.btnSaveIpServer.Text = "Save";
            this.btnSaveIpServer.UseSelectable = true;
            this.btnSaveIpServer.Click += new System.EventHandler(this.btnSaveIpServer_Click);
            // 
            // txtPortServer
            // 
            this.txtPortServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtPortServer.CustomButton.Image = null;
            this.txtPortServer.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.txtPortServer.CustomButton.Name = "";
            this.txtPortServer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPortServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPortServer.CustomButton.TabIndex = 1;
            this.txtPortServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPortServer.CustomButton.UseSelectable = true;
            this.txtPortServer.CustomButton.Visible = false;
            this.txtPortServer.Lines = new string[0];
            this.txtPortServer.Location = new System.Drawing.Point(13, 99);
            this.txtPortServer.MaxLength = 32767;
            this.txtPortServer.Name = "txtPortServer";
            this.txtPortServer.PasswordChar = '\0';
            this.txtPortServer.PromptText = "Port Input";
            this.txtPortServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPortServer.SelectedText = "";
            this.txtPortServer.SelectionLength = 0;
            this.txtPortServer.SelectionStart = 0;
            this.txtPortServer.ShortcutsEnabled = true;
            this.txtPortServer.Size = new System.Drawing.Size(249, 23);
            this.txtPortServer.TabIndex = 2;
            this.txtPortServer.UseSelectable = true;
            this.txtPortServer.WaterMark = "Port Input";
            this.txtPortServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPortServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.mpnlSetting);
            this.Controls.Add(this.pconnect);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblconnectstatus);
            this.Controls.Add(this.pnlMainContent);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "CMS - Camera Management System";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.mpnlSetting.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pconnect)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroPanel pnlMainContent;
        private MetroFramework.Controls.MetroLink btnClose;
        private MetroFramework.Controls.MetroLink btnLogout;
        private MetroFramework.Controls.MetroLink btnSetting;
        private MetroFramework.Controls.MetroLabel lblconnectstatus;
        private System.Windows.Forms.PictureBox pconnect;
        private MetroFramework.Controls.MetroPanel mpnlSetting;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroRadioButton mrbDark;
        private MetroFramework.Controls.MetroRadioButton mrbLight;
        private System.Windows.Forms.FlowLayoutPanel flColor;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnCheckServerConnect;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtIpServer;
        private MetroFramework.Controls.MetroButton btnSaveIpServer;
        private MetroFramework.Controls.MetroTextBox txtPortServer;
    }
}

