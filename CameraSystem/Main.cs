using CameraSystem.Views;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraSystem
{
    public partial class Main : MetroForm
    {
        private static Main _instance;
        public static Main Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Main();
                return _instance;
            }
        }
        public MetroStyleManager ManageStyle
        {
            get { return this.metroStyleManager1; }
            set { this.metroStyleManager1 = value; }
        }
        public MetroPanel MetroContainer
        {
            get { return this.pnlMainContent; }
            set { this.pnlMainContent = value; }
        }
        public Main()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _instance = this;
            ULogin login = new ULogin();
            login.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(login);
            
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if(metroToggle1.Checked)
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            }
            else
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
