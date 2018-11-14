using CameraSystem.Data.Models;
using CameraSystem.Views;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Newtonsoft.Json;
using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraSystem
{
    public partial class Main : MetroForm
    {
        private static Main _instance;
        string serverIP = "107.113.59.143";
        int serverPort = 8080;
        Thread checkconnect = null;
        bool running = false;

        public string ServerIP
        {
            get { return serverIP; }
        }
        public int ServerPort
        {
            get { return serverPort; }
        }
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
            metroStyleManager1.Theme = Properties.Settings.Default.Theme;
            metroStyleManager1.Style = Properties.Settings.Default.Style;
            
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            



            mpnlSetting.Visible = false;
            _instance = this;
            ULogin login = new ULogin();
            login.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(login);
            serverIP = Properties.Settings.Default.serverIP;
            serverPort = Properties.Settings.Default.serverPort;
            txtIpServer.Text = serverIP;
            txtPortServer.Text = serverPort.ToString();
            checkconnect = new Thread(new ThreadStart(ConnectCheckStatus));
            running = true;
            checkconnect.Start();
            for (int i = 3; i < 13; i++)
            {
                MetroTile _tile = new MetroTile();
                _tile.Size = new Size(30, 30);
                _tile.Tag = i;
                _tile.Style = (MetroColorStyle)i;
                _tile.Click += _tile_Click;
                flColor.Controls.Add(_tile);
            }
        }

        private void ConnectCheckStatus()
        {
            int time_count = 0;
            while (running)
            {
                if (time_count > 1000)
                {
                    time_count = 0;
                    try
                    {
                        if (running)
                        {
                            //using (var client = new SimpleTcpClient())
                            //{
                            //    client.Connect(serverIP, serverPort);
                            //    Invoke((ThreadStart)delegate
                            //    {
                            //        pconnect.Image = (Image)Properties.Resources.GLOBES_GREEN;
                            //        lblconnectstatus.Text = "Connected";
                            //    });
                            //    client.Disconnect();
                            //    client.Dispose();
                            //}
                        }
                        else
                            break;
                    }
                    catch (Exception ex)
                    {
                        if (running)
                        {
                            //Invoke((ThreadStart)delegate
                            //{
                            //    pconnect.Image = (Image)Properties.Resources.GLOBES_RED;
                            //    lblconnectstatus.Text = "DisConnected";
                            //});
                        }
                        else
                            break;
                    }
                }
                Thread.Sleep(1);
                time_count++;
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
            ULogin login = new ULogin();
            login.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Clear();
            pnlMainContent.Controls.Add(login);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroMessageBox.Show(this, "Do you want to exit?", "Warning Close App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                running = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        int setting_trigger = 0;
        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (setting_trigger == 0)
            {
                mpnlSetting.Visible = true;
                setting_trigger = 1;
            }
            else
            {
                mpnlSetting.Visible = false;
                setting_trigger = 0;
            }
            
        }

        private void _tile_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroColorStyle)((MetroTile)sender).Tag;
        }

        private void mrbLight_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbLight.Checked)
            {
                metroStyleManager1.Theme = MetroThemeStyle.Light;
            }
            if (mrbDark.Checked)
            {
                metroStyleManager1.Theme = MetroThemeStyle.Dark;
            }
        }

        private void btnCloseSetting(object sender, EventArgs e)
        {
            mpnlSetting.Visible = false;
            Properties.Settings.Default.Theme = metroStyleManager1.Theme;
            Properties.Settings.Default.Style = metroStyleManager1.Style;
            Properties.Settings.Default.Save();
        }

        private void btnCheckServerConnect_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new SimpleTcpClient())
                {
                    client.Connect(txtIpServer.Text.Trim(), Convert.ToInt32(txtPortServer.Text.Trim()));
                    MetroMessageBox.Show(this, "Connect successful","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    serverPort = Convert.ToInt32(txtPortServer.Text.Trim());
                    serverIP = txtIpServer.Text.Trim();
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Connect fail", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveIpServer_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.serverIP = serverIP;
            Properties.Settings.Default.serverPort = serverPort;
            Properties.Settings.Default.Save();
            mpnlSetting.Visible = false;
        }
    }
}
