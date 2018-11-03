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
using System.Security.Cryptography;
using CameraSystem.Data.Models;

namespace CameraSystem.Views
{
    public partial class URegister : MetroUserControl
    {
        public URegister()
        {
            InitializeComponent();
            this.Load += URegister_Load;
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

        private void URegister_Load(object sender, EventArgs e)
        {
             
        }

        private void onCancel_Click(object sender, EventArgs e)
        {
            ULogin login = new ULogin();
            login.Dock = DockStyle.Fill;
            Main.Instance.MetroContainer.Controls.Clear();
            Main.Instance.MetroContainer.Controls.Add(login);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text != txtRepassword.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(txtUsername.Text.Trim()) && !string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                try
                {
                    using (SCMSEntities db = new SCMSEntities())
                    {
                        List<Proc_Find_CM_Account_Result> user_exists = db.Proc_Find_CM_Account(txtUsername.Text.Trim()).ToList();
                        if (user_exists.Count == 0)
                        {
                            var passmd5 = Helpers.ToMD5(txtPassword.Text.Trim());
                            db.Proc_Create_CM_Account(txtUsername.Text, txtFullName.Text,passmd5, txtEmail.Text);
                            db.SaveChanges();
                            MetroFramework.MetroMessageBox.Show(this, "Register DONE!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ULogin login = new ULogin();
                            login.Dock = DockStyle.Fill;
                            Main.Instance.MetroContainer.Controls.Clear();
                            Main.Instance.MetroContainer.Controls.Add(login);
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "User is already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Clear_Input();
                        }
                    }
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please check connect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear_Input();
                }
                
            }
        }

        private void Clear_Input()
        {
            txtEmail.Clear();
            txtFullName.Clear();
            txtPassword.Clear();
            txtRepassword.Clear();
            txtUsername.Clear();
            txtUsername.Focus();
        }
    }
}
