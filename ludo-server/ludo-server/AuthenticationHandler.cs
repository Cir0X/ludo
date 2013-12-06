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
    class AuthenticationHandler
    {
        private User user;

        public AuthenticationHandler()
        {
            var server = new WebSocketServer("ws://localhost:5000/authenticate");
            server.Start(socket =>
            {
                socket.OnOpen = () => Console.WriteLine("[Authenticate] " + socket.ConnectionInfo.ClientIpAddress + " connected with Guid: " + socket.ConnectionInfo.Id);
                socket.OnClose = () => removeUserFromList(socket);
                socket.OnMessage = jsonMessage => startAuthentication(jsonMessage, socket);
            });
        }
        
        private void startAuthentication(String jsonMessage, IWebSocketConnection socket)
        {
            Console.WriteLine("JSON: " + jsonMessage);
            this.user = JsonConvert.DeserializeObject<User>(jsonMessage); // Serialize from Json to Object
            this.user.SocketID = socket.ConnectionInfo.Id;
            this.user.Handshaked = true;

            if (isUserNameAvailable())
            {
                this.user.IsUserNameAvailable = true;

                Main.ludo.Users.Add(this.user); // Add this User for the online user list
                setUserListID();

                socket.Send(JsonConvert.SerializeObject(this.user)); // Desiralize from Object to Json | Sending 1 user object
            }
            else
            {
                // Username isn't available
                this.user.IsUserNameAvailable = false;
                //this.user.UserListIndex = -1;
                socket.Send(JsonConvert.SerializeObject(this.user));
            }
        }

        private void setUserListID()
        {
            int i = 0;
            foreach (var user in Main.ludo.Users)
            {
                if (user.UserName.Equals(this.user.UserName))
                {
                    Main.ludo.Users.Remove(this.user);
                    this.user.UserListIndex = i;
                    Main.ludo.Users.Add(this.user);
                    break;
                }
                i++;
            }
        }

        private bool isUserNameAvailable()
        {
            foreach (var user in Main.ludo.Users)
            {
                if (user.UserName.Equals(this.user.UserName))
                {
                    return false;
                }
            }
            return true;
        }

        private void removeUserFromList(IWebSocketConnection socket)
        {
            foreach (var user in Main.ludo.Users)
            {
                if (user.SocketID.Equals(socket.ConnectionInfo.Id))
                {
                    Main.ludo.Users.Remove(user);
                    break;
                }
            }
        }
    }
}
