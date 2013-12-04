using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fleck;
using ludo_server.dto;
using Newtonsoft.Json;

namespace ludo_server
{
    class Authenticate
    {
        private Ludo ludo;
        private User user;
        public Authenticate(Ludo ludo)
        {
            this.ludo = ludo;
            var server = new WebSocketServer("ws://localhost:5000/authenticate");
            server.Start(socket =>
            {
                socket.OnOpen = () => Console.WriteLine("[Authenticate] " + socket.ConnectionInfo.ClientIpAddress + " connected with Guid: " + socket.ConnectionInfo.Id);
                socket.OnClose = () => removeUserNameFromList(socket);
                socket.OnMessage = jsonMessage => startAuthentication(jsonMessage, socket);
            });
        }
        
        private void startAuthentication(String jsonMessage, IWebSocketConnection socket)
        {
            Guid socketID = socket.ConnectionInfo.Id;
            Console.WriteLine("JSON: " + jsonMessage);
            this.user = JsonConvert.DeserializeObject<User>(jsonMessage);
            if (!isUserNameAlreadyInUse())
            {
                ludo.Users.Add(this.user);
                Console.WriteLine("Online Users:");
                for (int i = 0; i < ludo.Users.Count; i++)
                {
                    Console.WriteLine("\t-" + ludo.Users[i].UserName);
                }
            }
            else
            {
                socket.Send("Username is already in use");
            }
        }

        private void removeUserNameFromList(IWebSocketConnection socket)
        {
            ludo.Users.Remove(this.user);
        }

        private bool isUserNameAlreadyInUse()
        {
            for (int i = 0; i < ludo.Users.Count; i++) 
            {
                if (ludo.Users[i].UserName == this.user.UserName)  {
                    return true;
                } 
            }
            return false;
        }
    }
}
