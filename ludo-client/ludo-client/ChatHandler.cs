using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocket4Net;
using ludo_client.dto;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace ludo_client
{
    class ChatHandler
    {
        private String PORT_ROUTE = ":5002/chat";
        private WebSocket websocket;
        private ListView messageList;

        public ChatHandler(ListView messageList)
        {
            this.messageList = messageList;
            websocket = new WebSocket("ws://" + ClientBase.serverAdress + PORT_ROUTE);
            websocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(handleChat);
            websocket.Open();
        }

        ~ChatHandler()
        {
            this.websocket.Close();
        }

        public void sendMessage()
        {
            websocket.Send(JsonConvert.SerializeObject(Main.ludo.Chat.Count - 1));
        }

        public void handleChat(object sender, MessageReceivedEventArgs args)
        {
            updateOnlineUserList(this.messageList);
        }

        public void updateOnlineUserList(ListView messageList)
        {
            if (messageList.InvokeRequired)
            {
                // We're on a thread other than the GUI thread
                messageList.Invoke(new MethodInvoker(() => updateOnlineUserList(messageList)));
                return;
            }
            foreach (var user in Main.ludo.Users)
            {
                int lastMessage = Main.ludo.Chat.Count() - 1;
                String timeStamp = "[" + Main.ludo.Chat[lastMessage].TimeStamp + "]";
                String sender = Main.ludo.Chat[lastMessage].Sender.UserName;
                String message = Main.ludo.Chat[lastMessage].Msg;
                messageList.Items.Add(timeStamp + " " + sender + ": " + message);
            }
        }

    }
}
