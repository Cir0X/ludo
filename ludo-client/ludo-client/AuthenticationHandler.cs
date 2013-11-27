using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ludo_client.dto;
using Newtonsoft.Json;
using WebSocket4Net;
using System.Windows.Forms;

namespace ludo_client
{
    class AuthenticationHandler
    {
        private String PORT_ROUTE = ":5000/authenticate";
        private Ludo ludo;
        private WebSocket webSocket;

        public AuthenticationHandler(Ludo ludo)
        {
            this.ludo = ludo;

            //User user = new User();
            //user.UserName = "Nummer1";
            //ludo.Users.Add(user);

            webSocket = new WebSocket(ludo.ServerAdress + PORT_ROUTE);
            webSocket.Opened += new EventHandler(authenticate);
            //webSocket.Closed += new EventHandler(websocket_Closed);
            webSocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(isUserNameInUse);
            webSocket.Open();
        }

        private void authenticate(object sender, EventArgs e)
        {
            String jsonMessage = JsonConvert.SerializeObject(ludo.Users.First());
            webSocket.Send(jsonMessage);
        }

        private void isUserNameInUse(object sender, MessageReceivedEventArgs args)
        {
            MessageBox.Show(args.Message);
        }
    }
}
