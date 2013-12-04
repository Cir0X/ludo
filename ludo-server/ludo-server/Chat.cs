using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fleck;

namespace ludo_server
{
    class Chat
    {
        public Chat()
        {
            var allSockets = new List<IWebSocketConnection>();
            var server = new WebSocketServer("ws://localhost:5001/chat");
            server.Start(socket =>
            {
                socket.OnOpen = () => allSockets.Add(socket);
                socket.OnClose = () => allSockets.Remove(socket);
                socket.OnMessage = message =>
                {
                    foreach (var s in allSockets.ToList())
                        s.Send(message);
                };
            });
            var input = Console.ReadLine();
    }
    }
}
