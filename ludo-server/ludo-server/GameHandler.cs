using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ludo_server.dto;
using Fleck;
using Newtonsoft.Json;

namespace ludo_server
{
    class GameHandler
    {
        private List<IWebSocketConnection> gameSocketList;
        public GameHandler()
        {
            gameSocketList = new List<IWebSocketConnection>();
            var server = new WebSocketServer("ws://localhost:5004/game");
            server.Start(socket => 
            {
                socket.OnOpen = () => gameSocketList.Add(socket);

                socket.OnClose = () => gameSocketList.Remove(socket);

                socket.OnMessage = message => handleGame(socket, message);
            });
        }

        private void handleGame(IWebSocketConnection socket, String message)
        {

        }

    }
}
