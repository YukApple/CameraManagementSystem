using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Components;

namespace CameraSystem.Views
{
    public partial class UDashboard : MetroUserControl
    {
        public UDashboard()
        {
            InitializeComponent();
            SetTheme();
            
        }

        private void SetTheme()
        {
            MetroStyleManager styleManager = new MetroStyleManager();
            styleManager.Owner = this;
            this.StyleManager = styleManager;
            styleManager.Theme = Main.Instance.ManageStyle.Theme;
            styleManager.Style = Main.Instance.ManageStyle.Style;
        }

        private void btnMainUpdateDll_Click(object sender, EventArgs e)
        {
            UDllUpdate uDll = new UDllUpdate();
            uDll.Dock = DockStyle.Fill;
            Main.Instance.MetroContainer.Controls.Clear();
            Main.Instance.MetroContainer.Controls.Add(uDll);
        }
    }
}
