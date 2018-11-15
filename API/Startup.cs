using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using API.Hubs;
using API.Repository;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.BuilderProperties;
using Owin;

[assembly: OwinStartup(typeof(API.Startup))]

namespace API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            //NSqlDependency notification = new NSqlDependency(EventAction, @"select[ip],[status] from[dbo].[CM_Machine]");
            //notification.loadData();
            //var properties = new AppProperties(app.Properties);
            //CancellationToken token = properties.OnAppDisposing;
            //if (token != CancellationToken.None)
            //{
            //    token.Register(() =>
            //    {
            //        notification.Dispose();
            //    });
            //}
        }

        private void EventAction()
        {
            //NotificationHub.Show();
        }
    }
}
