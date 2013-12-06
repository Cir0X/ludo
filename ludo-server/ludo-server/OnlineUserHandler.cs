using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ludo_server.dto;
using Newtonsoft.Json;
using Fleck;

namespace ludo_server
{
    class OnlineUserHandler
    {
        private List<IWebSocketConnection> onlineUserSocketList;

        public OnlineUserHandler()
        {
            onlineUserSocketList = new List<IWebSocketConnection>();
            var server = new WebSocketServer("ws://localhost:5001/onlineusers");
            server.Start(socket =>
            {
                socket.OnOpen = () =>
                {
                    addUserSocketToOnlinUserSocketList(socket);
                    sendOnlineUsers(socket);
                };
                socket.OnClose = () =>
                {
                    removeUserSocketFromOnlineUserList(socket);
                    sendOnlineUsers(socket);

                };
                //socket.OnMessage = message => sendOnlineUsers(socket);
            });
        }

        private void addUserSocketToOnlinUserSocketList(IWebSocketConnection socket)
        {
            this.onlineUserSocketList.Add(socket);
        }

        private void removeUserSocketFromOnlineUserList(IWebSocketConnection socket)
        {
            this.onlineUserSocketList.Remove(socket);
        }

        private void sendOnlineUsers(IWebSocketConnection socket)
        {            
            foreach (var s in onlineUserSocketList.ToList())
            {
                s.Send(JsonConvert.SerializeObject(Main.ludo));
            }
        }
    }
}