using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;

namespace API.Hubs
{
    public class NotificationHub : Hub
    {
        public NotificationHub()
        {
            Task.Factory.StartNew(()=> {
                while (true)
                {
                    TimeServer();
                    Thread.Sleep(2000);

                }
            });
        }
        public static void Show()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
            context.Clients.All.displayStatus();
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