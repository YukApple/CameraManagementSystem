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

namespace SoftwareService
{
    public partial class Service1 : ServiceBase
    {
        private Timer timer = null;
        private string[] _applications = new string[] { "GetDataAgent"};
        private List<AppStatus> _appstatuslist = new List<AppStatus>{ new AppStatus { AppName = "GetDataAgent" } };

        private string pathorigin = @"C:\Program Files (x86)\AutomationSVCC";
        private bool isSetting = false;
        private bool isWriting = false;
        SimpleTcpServer server = null;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // Tạo 1 timer từ libary System.Timers
            timer = new Timer();
            // Execute mỗi 60s
            timer.Interval = 1000;
            // Những gì xảy ra khi timer đó dc tick
            timer.Elapsed += timer_Tick;
            // Enable timer
            timer.Enabled = true;
            timer.Start();
            Utilities.WriteLog("Start Timer");
            // Ghi vào log file khi services dc start lần đầu tiên
            Utilities.WriteLog("Start theo dõi phần mềm");
            SystemEvents.SessionEnding += SystemEvents_SessionEnding;
            server = new SimpleTcpServer();
            try
            {
                server.Start(4444);
                server.DataReceived += Server_DataReceived;
                Utilities.WriteLog("Start listen port 4444");
            }
            catch (Exception)
            {
                Utilities.WriteLog("Cannot start listen port 4444");
            }
        }


        /*
         - CHANGEPATH: Thay doi path scan tim phan mem
         - SETSETTING: Thay doi phan mem can theo doi
         - GETSTATUS: Get tat ca cac phan mem trong list
         - RUNALL: Run tat ca cac phan mem co trong list theo doi
        */
        private void Server_DataReceived(object sender, Message e)
        {
            var strdatareceive = Encoding.UTF8.GetString(e.Data);
            _applications = strdatareceive.Split('-');
            switch (_applications[0].ToUpper())
            {
                case "CHANGEPATH":
                    pathorigin = _applications[1];
                    e.ReplyLine("CHANGEPATH DONE");
                    Utilities.WriteLog("Change path scan done!");
                    break;
                case "SETSETTING":
                    Utilities.WriteLog("Setting parameter");
                    isSetting = true;
                    while (isWriting) ;
                    if (_applications.Length > 1)
                    {
                        _appstatuslist.Clear();
                        for (int i = 1; i < _applications.Length; i++)
                        {
                            AppStatus app = new AppStatus();
                            app.AppName = _applications[i];
                            app.IsRunning = false;
                            _appstatuslist.Add(app);
                        }
                    }
                    isSetting = false;
                    e.ReplyLine("SETTING DONE");
                    Utilities.WriteLog("Setting done!");
                    break;
                case "GETSTATUS":
                    e.ReplyLine(JsonConvert.SerializeObject(_appstatuslist));
                    Utilities.WriteLog("Get done!");
                    break;
                case "RUNALL":
                    string[] allfile = Directory.GetFiles(pathorigin, "*.exe", SearchOption.AllDirectories);
                    foreach (var item in allfile)
                    {
                        FileInfo file = new FileInfo(item);
                        var existsfile = _appstatuslist.Exists(a => a.AppName == file.Name);
                        if(existsfile)
                        {
                            StartApp(file.DirectoryName,file.Name);
                        }
                    }
                    e.ReplyLine("RUNALL DONE");
                    Utilities.WriteLog("Start all done!");
                    break;
                default:
                    break;
            }
            Utilities.WriteLog("Client send : " + e.TcpClient.Client.RemoteEndPoint.ToString());
            Utilities.WriteLog("Data setting receive: " + strdatareceive);
            
        }

        private void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
        {
            if (server.IsStarted)
                server.Stop();
            Utilities.WriteLog("Shutdown computer");
            e.Cancel = true;
        }

        private void timer_Tick(object sender, ElapsedEventArgs e)
        {
            // Xử lý một vài logic ở đây
            if(_applications.Length > 0)
            {
                isWriting = true;
                foreach (var item in _appstatuslist)
                {
                    if(IsProcessOpen(item.AppName))
                    {
                        item.IsRunning = true;
                    }
                    else
                    {
                        item.IsRunning = false;
                    }
                }
            }
            isWriting = false;
        }

        protected override void OnStop()
        {
            // Ghi log lại khi Services đã được stop
            if (server.IsStarted)
                server.Stop();
            timer.Stop();
            timer.Enabled = false;
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

    public class AppStatus
    {
        public string AppName { get; set; }
        public bool IsRunning { get; set; } = false;
    }
}
