using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using SignalRDemo.Models;

namespace SignalRDemo
{
    [HubName("ChatHub")]
    public class ChatHub : Hub
    {
        public void Send(string userName, string message)
        {
            var data = new ChatContentModel
            {
                Content = message,
                UserName = userName,
                LogTime = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString()
            };

            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(data);
        }
    }
}