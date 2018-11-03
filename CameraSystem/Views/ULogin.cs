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
using CameraSystem.Data.Models;

namespace CameraSystem.Views
{
    public partial class ULogin : MetroUserControl
    {
        
        public ULogin()
        {
            InitializeComponent();
            this.Load += ULogin_Load;
            this.Resize += ULogin_Resize;
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

        private void ULogin_Resize(object sender, EventArgs e)
        {
        }

        private void ULogin_Load(object sender, EventArgs e)
        {
            
        }

        private void onLogin_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            //{
            //    MetroFramework.MetroMessageBox.Show(this, "Please input password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            //{
            //    MetroFramework.MetroMessageBox.Show(this, "Please input Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //try
            //{
            //    using (var db = new SCMSEntities())
            //    {
            //        var passmd5 = Helpers.ToMD5(txtPassword.Text.Trim());
            //        var user_valid = db.Proc_FindUser_CM_Account(txtUsername.Text.Trim(), passmd5);
            //        if(user_valid != null)
            //        {
                        UDashboard dashboard = new UDashboard();
                        dashboard.Dock = DockStyle.Fill;
                        Main.Instance.MetroContainer.Controls.Clear();
                        Main.Instance.MetroContainer.Controls.Add(dashboard);
            //        }
            //        else
            //        {
            //            MetroFramework.MetroMessageBox.Show(this, "Please check user or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            Clear_Input();
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    MetroFramework.MetroMessageBox.Show(this, "Please check connect to server", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }

        private void onRegister_Click(object sender, EventArgs e)
        {
            URegister register = new URegister();
            register.Dock = DockStyle.Fill;
            Main.Instance.MetroContainer.Controls.Clear();
            Main.Instance.MetroContainer.Controls.Add(register);
            //Main.Instance.MetroContainer.Controls["URegister"].BringToFront();
        }

        private void Clear_Input()
        {
            txtPassword.Clear();
            txtUsername.Clear();
            txtUsername.Focus();
        }
    }
}
