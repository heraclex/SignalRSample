
using System;

namespace SignalRDemo.Models
{
    /// <summary>
    /// This class will contain data to transfer between server and client
    /// </summary>
    public class ChatContentModel
    {
        public string UserName { get; set; }

        public string Content { get; set; }

        public string LogTime { get; set; }
    }
}