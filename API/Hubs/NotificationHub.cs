using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using API.Models;
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;

namespace API.Hubs
{
    public class NotificationHub : Hub
    {
        public static bool isRunning = false;
        public NotificationHub()
        {
            if (!isRunning)
            {
                Task.Factory.StartNew(async () =>
                {
                    while (true)
                    {
                        using (SCMSEntities db = new SCMSEntities())
                        {
                            try
                            {
                                var data = db.Proc_Machines().ToList();
                                Clients.All.Machines(data);
                            }
                            catch (Exception e)
                            {
                                Clients.All.Error("Error:\r\n" + e.Message);
                            }
                        }
                        await Task.Delay(5000);
                    }
                }, TaskCreationOptions.RunContinuationsAsynchronously);
                

                isRunning = true;
            }
        }
        public void Show()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
            context.Clients.All.DisplayMessage("Nguyen Van Nguyen");
        }

        public void TimeServer()
        {
            Clients.Caller.setTime(DateTime.Now.ToString("hh:mm:ss tt"));
        }

        public void getTime(string countryZone)
        {
            TimeZone currentZone = TimeZone.CurrentTimeZone;
            DateTime currentDate = DateTime.Now;
            DateTime currentUTC = currentZone.ToUniversalTime(currentDate);
            TimeZoneInfo selectedTimeZone = TimeZoneInfo.FindSystemTimeZoneById(countryZone);
            DateTime currentDateTime = TimeZoneInfo.ConvertTimeFromUtc(currentUTC, selectedTimeZone);
            Clients.Caller.setTime(currentDateTime.ToString("h:mm:ss tt"));
        }
    }
}