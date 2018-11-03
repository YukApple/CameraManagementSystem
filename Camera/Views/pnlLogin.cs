using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;
using MetroFramework.Forms;

namespace CameraSystem.Views
{

    public partial class pnlLogin : pnlSlider
    {
        public event EventHandler SettingClosed;
        public event EventHandler LogInSuccess;

        public pnlLogin(Form owner)
            : base(owner)
        {
            InitializeComponent();

            for (int i = 3; i < 13; i++)
            {
                MetroTile _tile = new MetroTile();
                _tile.Size = new Size(30, 30);
                _tile.Tag = i;
                _tile.Style = (MetroColorStyle)i;
                _tile.Click += _tile_Click;
                flpSettings.Controls.Add(_tile);
            }
        }

        void _tile_Click(object sender, EventArgs e)
        {
            ((MetroForm)this.Parent).StyleManager.Style = (MetroColorStyle)((MetroTile)sender).Tag;
        }

        public void ShowSettings()
        {
            pnlSettings.Visible = true;
        }

        private void lnkBack_Click(object sender, EventArgs e)
        {
            pnlSettings.Visible = false;

            EventHandler handler = SettingClosed;
            if (handler != null) handler(this, e);
        }

        private void mrbDark_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbDark.Checked )
            {
                ((MetroForm)this.Parent).StyleManager.Theme = MetroThemeStyle.Dark;
            }
        }

        private void mrbLight_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbLight.Checked)
            {
                ((MetroForm)this.Parent).StyleManager.Theme = MetroThemeStyle.Light;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            EventHandler handler = LogInSuccess;
            if (handler != null) handler(this, e);
        }
    }
}
