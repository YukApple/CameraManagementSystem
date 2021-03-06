﻿using System;
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
using System.Net.Http;
using Newtonsoft.Json;

namespace CameraSystem.Views
{
    public partial class ULogin : MetroUserControl
    {
        WaitWndFun waitForm = new WaitWndFun();
        Main main_parent = Main.Instance;
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
            txtUsername.Focus();
            if (Helpers.isExistsSetting("remembercheck"))
            {
                var ischeck = Helpers.GetSetting("remembercheck");
                if(ischeck == "1")
                {
                    txtUsername.Text = Helpers.GetSetting("username");
                    chkmemo.Checked = true;
                }
                    
            }
        }

        private async void onLogin_Click(object sender, EventArgs e)
        {
            waitForm.Show(main_parent);
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please input password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please input Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            WebRequest request = new WebRequest();
            HttpResponseMessage acc = request.getaccount().Result;
            string account = await acc.Content.ReadAsStringAsync();
            var accounts = JsonConvert.DeserializeObject<List<CM_Account>>(account);
            
            var passmd5 = Helpers.ToMD5(txtPassword.Text.Trim());
            var user_valid = accounts.Exists(a => a.GEN.Trim() == txtUsername.Text.Trim() && a.password.Trim() == passmd5);
            if (user_valid)
            {
                if(chkmemo.Checked)
                {
                    if(Helpers.isExistsSetting("remembercheck"))
                    {
                        Helpers.SetSetting("remembercheck", "1");
                        Helpers.SetSetting("username", txtUsername.Text.Trim());
                    }
                    else
                    {
                        Helpers.AddSetting("remembercheck", "1");
                        Helpers.AddSetting("username", txtUsername.Text.Trim());
                    }
                }
                else
                {
                    if (Helpers.isExistsSetting("remembercheck"))
                    {
                        Helpers.SetSetting("remembercheck", "0");
                        Helpers.SetSetting("username", txtUsername.Text.Trim());
                    }
                    else
                    {
                        Helpers.AddSetting("remembercheck", "0");
                        Helpers.AddSetting("username", txtUsername.Text.Trim());
                    }
                }
                UDllUpdate dashboard = new UDllUpdate();
                dashboard.Dock = DockStyle.Fill;
                Main.Instance.MetroContainer.Controls.Clear();
                Main.Instance.MetroContainer.Controls.Add(dashboard);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check user or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear_Input();
            }
            waitForm.Close();

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
