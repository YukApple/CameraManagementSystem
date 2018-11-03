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
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnLogout = new MetroFramework.Controls.MetroLink();
            this.btnSetting = new MetroFramework.Controls.MetroLink();
            this.btnClose = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
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
            // metroToggle1
            // 
            this.metroToggle1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(1173, 11);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.TabIndex = 1;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(1131, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Light";
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.pnlMainContent);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "CMS - Camera Management System";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroPanel pnlMainContent;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink btnClose;
        private MetroFramework.Controls.MetroLink btnLogout;
        private MetroFramework.Controls.MetroLink btnSetting;
    }
}

