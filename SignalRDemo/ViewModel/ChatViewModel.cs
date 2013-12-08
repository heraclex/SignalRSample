using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalRDemo.Models;

namespace SignalRDemo.ViewModel
{
    public class ChatViewModel
    {
        public ChatViewModel()
        {
            this.ChatingLogs = new List<ChatContentModel>();
        }

        public string UserName { get; set; }

        public string Message { get; set; }

        public List<ChatContentModel> ChatingLogs { get; set; }
    }
}