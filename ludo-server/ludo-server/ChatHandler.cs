using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fleck;
using Newtonsoft.Json;
using ludo_server.dto;

namespace ludo_server
{
    class ChatHandler
    {
        private List<IWebSocketConnection> chatSocketList;
        public ChatHandler()
        {
            chatSocketList = new List<IWebSocketConnection>();
            var server = new WebSocketServer("ws://localhost:5002/chat");
            server.Start(socket =>
            {
                socket.OnOpen = () => {
                    chatSocketList.Add(socket);
                    socket.Send(JsonConvert.SerializeObject(Main.ludo.Chat));
                };

                socket.OnClose = () => {
                    chatSocketList.Remove(socket); 
                };

                socket.OnMessage = message =>
                {
                    Message msg = JsonConvert.DeserializeObject<Message>(message);
                    msg.TimeStamp = DateTime.Now;
                    Main.ludo.Chat.Add(msg);
                    foreach (var s in chatSocketList.ToList())
                    {
                        s.Send(JsonConvert.SerializeObject(Main.ludo.Chat.Count -1));
                    }
                };
            });
        }
    }
}
