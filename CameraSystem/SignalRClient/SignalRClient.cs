using System;
using Microsoft.AspNet.SignalR.Client;

namespace CameraSystem.SignalRClient
{


	public class SignalRClient
	{
		protected readonly string SignalRUrl;
		protected readonly string SignalRHub;

		protected bool IsConnected;
		protected HubConnection Connection;

		public SignalRClient(string url, string hub)
		{
			this.SignalRUrl = url;
			this.SignalRHub = hub;
		}

		public async void Connect(Action<dynamic> receiveAction, string onMethod)
		{
			this.Connection = new HubConnection(this.SignalRUrl);
			var hubProxy = this.Connection.CreateHubProxy(this.SignalRHub);
			hubProxy.On(onMethod, receiveAction);
			await this.Connection.Start();
		}

    //    var hub = new SignalRClient(signalRUrl.Text, signalRHub.Text);
    //    hub.Connect((data) => this.Invoke((MethodInvoker)delegate
				//{
				//	this.messagesReceived++;
				//	var currentBytes = data.ToString().Length;
				//	this.bytesRecieved += currentBytes;
				//	this.results.Text = string.Format(
				//		"Messages Received: {0}\r\nTotal Bytes Received: {1}\r\nLast Bytes Received: {4}\r\nLast received on connection: {2}\r\n\r\nLast Message:\n\r{3}",
    //                    messagesReceived,
    //                    bytesRecieved,
    //                    hubNumber,
    //                    data,
    //                    currentBytes);
				//	this.results.Update();
				//}), onMethodName.Text);
	}
}
