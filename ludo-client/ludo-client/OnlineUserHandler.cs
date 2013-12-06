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
    class OnlineUserHandler
    {
        private String PORT_ROUTE = ":5001/onlineuser";
        private WebSocket websocket;
        private ListView onlineUserList;
        //Object syncLock = new Object();

        public OnlineUserHandler(ListView onlineUserList)
        {
            this.onlineUserList = onlineUserList;
            websocket = new WebSocket("ws://" + ClientBase.serverAdress + PORT_ROUTE);
            websocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(handleOnlineUsers);
            websocket.Open();
        }

        ~OnlineUserHandler()
        {
            this.websocket.Close();
        }

        private void handleOnlineUsers(object sender, MessageReceivedEventArgs args)
        {
            Main.ludo = JsonConvert.DeserializeObject<Ludo>(args.Message);
            updateOnlineUserList(this.onlineUserList);
        }

        public void updateOnlineUserList(ListView onlineUserList)
        {
            if (onlineUserList.InvokeRequired)
            {
                // We're on a thread other than the GUI thread
                onlineUserList.Invoke(new MethodInvoker(() => updateOnlineUserList(onlineUserList)));
                return;
            }
            onlineUserList.Clear();
            foreach (var user in Main.ludo.Users)
            {
                onlineUserList.Items.Add(user.UserName);
            }
        }

    }
}