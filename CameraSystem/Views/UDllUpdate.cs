using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using CameraSystem.Data.Models;
using MetroFramework.Controls;
using System.IO;
using CameraSystem.Models;
using System.Diagnostics;
using System.Net;
using SimpleTCP;
using System.Net.Sockets;
using System.Threading;

namespace CameraSystem.Views
{
    public partial class UDllUpdate : MetroFramework.Controls.MetroUserControl
    {
        private List<Proc_Machines_Result> machines = new List<Proc_Machines_Result>();
        private List<Proc_FindAll_CM_Line_Result> lines = new List<Proc_FindAll_CM_Line_Result>();
        private List<Proc_FindAll_CM_Model_Result> models = new List<Proc_FindAll_CM_Model_Result>();
        private List<Proc_FindAll_CM_Process_Result> process = new List<Proc_FindAll_CM_Process_Result>();
        private List<Proc_FindAll_CM_Zone_Result> zones = new List<Proc_FindAll_CM_Zone_Result>();
        private bool loaded = false;
        WaitWndFun waitForm = new WaitWndFun();
        Main main_parent = Main.Instance;
        SimpleTcpClient client = null;

        public UDllUpdate()
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

        private void btnLoadAllMachine_Click(object sender, EventArgs e)
        {
            waitForm.Show(main_parent);
            if (chbdatabase.Checked)
            {
                try
                {
                    using (SCMSEntities db = new SCMSEntities())
                    {
                        machines = db.Proc_Machines().ToList();
                        zones = db.Proc_FindAll_CM_Zone().ToList();
                        lines = db.Proc_FindAll_CM_Line().ToList();
                        models = db.Proc_FindAll_CM_Model().ToList();
                        process = db.Proc_FindAll_CM_Process().ToList();
                        procMachinesResultBindingSource.DataSource = machines;
                        cMZoneBindingSource.DataSource = zones;
                        cMLineBindingSource.DataSource = lines;
                        cMModelBindingSource.DataSource = models;
                        cMProcessBindingSource.DataSource = process;
                        lblquantitymc.Text = machines.Count.ToString();
                    }
                }
                catch (Exception)
                {

                    MetroFramework.MetroMessageBox.Show(this, "You have an error", "Information");
                }
            }
            waitForm.Close();
        }

        private void cbbZone_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (var db = new SCMSEntities())
            {
                cMLineBindingSource.DataSource = db.Proc_Find_LineZone(cbbZone.Text);
            }
        }

        private void cbbLine_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (var db = new SCMSEntities())
            {
                cMProcessBindingSource.DataSource = db.GetProcessLine(cbbLine.Text);
            }
        }

        private void cbbModel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (var db = new SCMSEntities())
            {
                cMLineBindingSource.DataSource = db.Proc_Find_LineModel(cbbModel.Text);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UDashboard uDashboard = new UDashboard();
            ChangeContent(uDashboard);
        }

        private void ChangeContent(MetroFramework.Controls.MetroUserControl uc)
        {
            //ULogin register = new ULogin();
            uc.Dock = DockStyle.Fill;
            Main.Instance.MetroContainer.Controls.Clear();
            Main.Instance.MetroContainer.Controls.Add(uc);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            waitForm.Show(main_parent);
            using (var db = new SCMSEntities())
            {
                var mcfilter = machines.Where(m => m.Zone_Name == cbbZone.Text && m.Model_Name == cbbModel.Text && m.Line == Convert.ToInt32(cbbLine.Text) && m.Process_Name == cbbProcess.Text).ToList();
                if (chkconnected.Checked)
                {
                    List<Proc_Machines_Result> mcs = new List<Proc_Machines_Result>();
                    List<MachineOnlineModel> mcOn = new List<MachineOnlineModel>();
                    foreach (var mc in mcfilter)
                    {
                        MachineOnlineModel mcO = new MachineOnlineModel();
                        mcO.IP = mc.IP.Trim();
                        mcOn.Add(mcO);
                        //try
                        //{
                        //    var client = new SimpleTcpClient().Connect(mc.IP.Trim(), 1000);
                        //    mcs.Add(mc);
                            
                        //}
                        //catch (Exception ex)
                        //{
                        //    //MetroFramework.MetroMessageBox.Show(this, "Please check connect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    continue;
                        //}
                        
                    }
                    procMachinesResultBindingSource.DataSource = mcs;
                    var sendcmd = Helpers.SendCommand(mcOn, Helpers.CommandMethod.GET, "MachineOnlineModel");
                    client.WriteLine(sendcmd);
                }
                else
                {
                    procMachinesResultBindingSource.DataSource = mcfilter;
                }
                
            }
            waitForm.Close();
        }

        // Ham nhan tat ca moi thu phan hoi ve
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            MessageBox.Show(e.MessageString);
            client.Disconnect();
            client.Dispose();
            
        }

        private void eIndexChanged(object sender, EventArgs e)
        {
            var ctrl = sender as MetroFramework.Controls.MetroComboBox;
            try
            {
                using (var db = new SCMSEntities())
                {
                    switch (ctrl.Name)
                    {
                        case "cbbZone":
                           
                            break;
                        case "cbbModel":
                            
                            break;
                        case "cbbLine":
                            
                            break;
                        case "cbbProcess":
                            
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cMZoneBindingSource_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void onBrowes_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtpathfile.Text = fbd.SelectedPath;
                    string[] extensions = new[] { ".exe", ".dll" };
                    List<FileModel> fileupdates = new List<FileModel>();
                    string[] files = Directory.GetFiles(fbd.SelectedPath, "*.dll", SearchOption.AllDirectories).Union(Directory.GetFiles(fbd.SelectedPath, "*.exe", SearchOption.AllDirectories)).ToArray();
                    foreach (var file in files)
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        FileModel fileDLL = new FileModel();
                        fileDLL.FileName = fileInfo.Name;
                        fileDLL.Extention = fileInfo.Extension;
                        var versionInfo = FileVersionInfo.GetVersionInfo(fileInfo.FullName);
                        fileDLL.Version = versionInfo.ProductVersion;
                        fileDLL.CreateTime = fileInfo.CreationTime;
                        fileDLL.LastModify = fileInfo.LastWriteTime;
                        fileDLL.FullPath = fileInfo.FullName;
                        fileupdates.Add(fileDLL);
                    }
                    fileModelBindingSource.DataSource = fileupdates;

                }
            }
        }

        // Add machines
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ctr = GetParentControl(sender);
            if (ctr.Name == "dgvmachines")
            {
                if (procMachinesResultBindingSource.List.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvmachines.SelectedRows)
                    {
                        var rowmodel = (Proc_Machines_Result)row.DataBoundItem;
                        machines.Remove(rowmodel);
                        procMachinesResultBindingSource1.Add(rowmodel);
                        procMachinesResultBindingSource.RemoveAt(row.Index);
                    }
                }
            }
        }

        private void procMachinesResultBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblquantitymc.Text = procMachinesResultBindingSource.List.Count.ToString();
        }

        private void procMachinesResultBindingSource1_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblquantityselected.Text = procMachinesResultBindingSource1.List.Count.ToString();
        }

        // Add all machines
        private void addAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ctr = GetParentControl(sender);
            if (ctr.Name == "dgvmachines")
            {
                if (procMachinesResultBindingSource.List.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvmachines.Rows)
                    {
                        var rowmodel = (Proc_Machines_Result)row.DataBoundItem;
                        machines.Remove(rowmodel);
                        procMachinesResultBindingSource1.Add(rowmodel);
                        procMachinesResultBindingSource.RemoveAt(row.Index);
                    }
                }
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ctr = GetParentControl(sender);
            if (ctr.Name == "dgvmachines")
            {
                if (procMachinesResultBindingSource.List.Count > 0)
                {
                    foreach (DataGridViewRow row in ctr.SelectedRows)
                    {
                        procMachinesResultBindingSource.RemoveAt(row.Index);
                    }
                }
            }
            else
            {
                if (procMachinesResultBindingSource1.List.Count > 0)
                {
                    foreach (DataGridViewRow row in ctr.SelectedRows)
                    {
                        var rowmodel = (Proc_Machines_Result)row.DataBoundItem;
                        machines.Add(rowmodel);
                        procMachinesResultBindingSource1.RemoveAt(row.Index);
                    }
                }
            }
            
        }

        private void removeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ctr = GetParentControl(sender);
            if (ctr.Name == "dgvmachines")
            {
                if (procMachinesResultBindingSource.List.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvmachines.Rows)
                    {
                        procMachinesResultBindingSource.RemoveAt(row.Index);
                    }
                }
            }
            else
            {
                if (procMachinesResultBindingSource1.List.Count > 0)
                {
                    MetroFramework.MetroMessageBox.Show(this,ctr.Rows.Count.ToString());
                    foreach (DataGridViewRow row in dgvmcselected.Rows)
                    {
                        var rowmodel = (Proc_Machines_Result)row.DataBoundItem;
                        machines.Add(rowmodel);
                        procMachinesResultBindingSource1.RemoveAt(row.Index);
                    }
                }
            }
        }

        private MetroGrid GetParentControl(object sender)
        {
            MetroGrid name = new MetroGrid();
            // Try to cast the sender to a ToolStripItem
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    Control sourceControl = owner.SourceControl;
                    name = sourceControl as MetroGrid;

                }
            }
            return name;
        }

        private void chbdatabase_CheckedChanged(object sender, EventArgs e)
        {
            loaded = false;
            if (chbdatabase.Checked)
                btnfilebrowers.Enabled = false;
            else
                btnfilebrowers.Enabled = true;
        }

        private void dgvmachines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIndexMC.Text = (dgvmachines.CurrentRow.Index+1).ToString();
        }

        private void dgvmcselected_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIndexSlMC.Text = (dgvmcselected.CurrentRow.Index+1).ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblcurrentupdate.Text = "";
            foreach (FileModel file in fileModelBindingSource.List)
            {
                if(!FtpUploadFile(file.FullPath, "ftp://107.113.59.143/" + file.FileName, "UPDATE_DLL", ""))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Cannot upload file " + file.FileName);
                }
            }
            var count = procMachinesResultBindingSource1.List.Count;
            lblcurrentupdate.Text = string.Format("{0}/{1}", 0, count);
            foreach (Proc_Machines_Result mc in procMachinesResultBindingSource1.List)
            {

                //var client = new SimpleTcpClient().Connect(mc.IP.Trim(), 1000);
                //client.StringEncoder = ASCIIEncoding.ASCII;
                //client.WriteLine("CMD_UPDATE_DLL");
                try
                {
                    //var success = machine.mc_tcpClient.ConnectAsync(machine.mc_ip, port).Wait(10);
                    TcpClient tcpClient = new TcpClient();
                    var result = tcpClient.BeginConnect(mc.IP.Trim(), 1000, null, null);
                    var success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1));
                    if (!success)
                    {
                        throw new Exception("fail to connect");

                    }
                    else
                    {
                        NetworkStream networkStream = tcpClient.GetStream();

                        if (networkStream.CanWrite && networkStream.CanRead)
                        {

                            Byte[] sendBytes = Encoding.ASCII.GetBytes("CMD_UPDATE_DLL");
                            networkStream.Write(sendBytes, 0, sendBytes.Length);

                        }
                        networkStream.Close();
                        tcpClient.Close();
                    }
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Cannot send command " + mc.IP);
                }
                count += 1;
                lblcurrentupdate.Text = string.Format("{0}/{1}", count, procMachinesResultBindingSource1.List.Count);
            }
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fileModelBindingSource.List.Count > 0)
            {
                foreach (DataGridViewRow row in dgvFiles.SelectedRows)
                {
                    fileModelBindingSource.RemoveAt(row.Index);
                }
            }
        }

        private void fileModelBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblQuantityFile.Text = fileModelBindingSource.List.Count.ToString();
        }

        private void dgvFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIndexFile.Text = (dgvFiles.CurrentRow.Index+1).ToString();
        }

        private bool FtpUploadFile(string path,string uri,string username,string password)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(username, password);
            byte[] bytes = File.ReadAllBytes(path);
            request.ContentLength = bytes.Length;
            try
            {
                using (Stream request_stream = request.GetRequestStream())
                {
                    request_stream.Write(bytes, 0, bytes.Length);
                    request_stream.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

    }
}
