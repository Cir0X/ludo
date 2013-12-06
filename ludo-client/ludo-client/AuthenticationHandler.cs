using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocket4Net;
using Newtonsoft.Json;
using System.Windows.Forms;
using ludo_client.dto;

namespace ludo_client
{
    class AuthenticationHandler
    {
        private String PORT_ROUTE = ":5000/authenticate";
        private WebSocket webSocket;
        private User user;

        public AuthenticationHandler(User user)
        {
            this.user = user;
            webSocket = new WebSocket("ws://" + ClientBase.serverAdress + PORT_ROUTE);
            webSocket.Opened += new EventHandler(authenticate);
            //webSocket.Closed += new EventHandler(websocket_Closed);
            webSocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(receiveThisUserObject);
            webSocket.Open();
        }

        ~AuthenticationHandler()
        {
            this.webSocket.Close();
        }

        private void authenticate(object sender, EventArgs e)
        {
            webSocket.Send(JsonConvert.SerializeObject(this.user));
        }

        private void receiveThisUserObject(object sender, MessageReceivedEventArgs args)
        {
            var jsonString = JsonConvert.DeserializeObject<User>(args.Message);
            int userListIndex = jsonString.UserListIndex;
            this.user = JsonConvert.DeserializeObject<User>(args.Message); // receiving my user object
            Main.ludo.Users.Add(this.user);
            if (isUserNameAvailable())
            {
                ClientBase.myUserListIndex = userListIndex;
            }
            else
            {
                MessageBox.Show("Username is already used");
            }
        }

        private bool isUserNameAvailable()
        {
            if (this.user.IsUserNameAvailable)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
