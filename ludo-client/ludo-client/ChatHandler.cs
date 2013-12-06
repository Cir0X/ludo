using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocket4Net;
using ludo_client.dto;
using Newtonsoft.Json;
using System.Windows.Forms;
using ludo_client.extensions;
using System.Drawing;

namespace ludo_client
{
    class ChatHandler
    {
        private String PORT_ROUTE = ":5002/chat";
        private WebSocket websocket;
        private RichTextBox messageList;

        public ChatHandler(RichTextBox messageList)
        {
            this.messageList = messageList;
            websocket = new WebSocket("ws://" + ClientBase.serverAdress + PORT_ROUTE);
            websocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(receiveChat);
            websocket.Open();
        }

        ~ChatHandler()
        {
            this.websocket.Close();
        }

        public void sendMessage(ludo_client.dto.Message message)
        {
            websocket.Send(JsonConvert.SerializeObject(message));
        }

        public void receiveChat(object sender, MessageReceivedEventArgs args)
        {
            ludo_client.dto.Message newIncomingMessage = JsonConvert.DeserializeObject<ludo_client.dto.Message>(args.Message);
            updateOnlineUserList(this.messageList, newIncomingMessage);
        }

        public void updateOnlineUserList(RichTextBox messageList, ludo_client.dto.Message newIncomingMessage)
        {
            if (messageList.InvokeRequired)
            {
                // We're on a thread other than the GUI thread
                messageList.Invoke(new MethodInvoker(() => updateOnlineUserList(messageList, newIncomingMessage)));
                return;
            }
            //int lastMessage = Main.ludo.Chat.Count() - 1;
            String timeStampSecond = newIncomingMessage.TimeStamp.Second.ToString();
            if (timeStampSecond.Length == 1)
            {
                timeStampSecond = "0" + timeStampSecond;
            }
            String timeStamp = "[" + newIncomingMessage.TimeStamp.ToShortTimeString() +
                ":" + timeStampSecond  + "]";
            String sender = newIncomingMessage.Sender.UserName;
            String message = newIncomingMessage.Msg;
            messageList.AppendText(timeStamp + " ", Color.Gray);
            messageList.AppendText(sender + ": " , Color.Blue);
            messageList.AppendText(message + "\n");
            messageList.ScrollToCaret();
        }
    }
}
