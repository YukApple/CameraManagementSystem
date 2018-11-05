using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using SimpleTCP;
using System.IO;
using Newtonsoft.Json;
using CameraSystem.Models;

namespace SoftwareService
{
    public partial class Service1 : ServiceBase
    {
        SimpleTcpServer server = null;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Utilities.WriteLog("Start Timer");
            // Ghi vào log file khi services dc start lần đầu tiên
            Utilities.WriteLog("Start theo dõi phần mềm");
            server = new SimpleTcpServer();
            try
            {
                server.Start(8080);
                server.DataReceived += Server_DataReceived;
                Utilities.WriteLog("Start listen port 8080");
            }
            catch (Exception)
            {
                Utilities.WriteLog("Cannot start listen port 8080");
            }
        }

        private void Server_DataReceived(object sender, Message e)
        {
            var jmessage = e.MessageString;
            Utilities.WriteLog(jmessage);
            var message = JsonConvert.DeserializeObject<CommandModel>(jmessage);
            switch (message.Command)
            {
                case "GET":
                    e.ReplyLine(message.Data);
                    break;
                case "SET":
                    SetDataExecute();
                    break;
                default:
                    break;
            }
        }

        private void SetDataExecute()
        {
            throw new NotImplementedException();
        }

        private List<T> GetDataExecute<T>(string data,string model)
        {
            List<T> result = null;
            switch (model)
            {
                case "MachineOnlineModel":
                    result = JsonConvert.DeserializeObject<List<T>>(data);
                    break;
                default:
                    break;
            }
            return result;
        }

        private async Task<List<MachineOnlineModel>> GetMachineStatus(List<MachineOnlineModel> listMC)
        {
            List<MachineOnlineModel> list = new List<MachineOnlineModel>();
            return await Task.Factory.StartNew(() =>
            {
                foreach (var mc in listMC)
                {
                    MachineOnlineModel _mc = new MachineOnlineModel();
                    try
                    {
                        using (SimpleTcpClient client = new SimpleTcpClient())
                        {
                            client.Connect(mc.IP, 1000);
                            _mc.IP = mc.IP;
                            _mc.isOnline = true;
                        }
                    }
                    catch (Exception)
                    {
                        _mc.IP = mc.IP;
                        _mc.isOnline = false;
                    }
                    list.Add(_mc);
                }
                return list;
            });
        }

        protected override void OnStop()
        {
            Utilities.WriteLog("WindowsService has been stop");
        }

        public bool IsProcessOpen(string name)
        {
            Process[] processlist = Process.GetProcesses();
            var check = processlist.Where(a => a.ProcessName == name).FirstOrDefault();
            if(check != null)
            {
                return true;
            }
            return false;
        }

        public void StartApp(string path, string name)
        {
            if(!IsProcessOpen(name))
                Process.Start(Path.Combine(path, name));
        }

    }
}
