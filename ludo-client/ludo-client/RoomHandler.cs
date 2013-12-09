using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebSocket4Net;
using ludo_client.dto;

namespace ludo_client
{
    class RoomHandler
    {
        private String PORT_ROUTE = ":5003/room";
        private WebSocket websocket;

        public RoomHandler()
        {
            websocket = new WebSocket("ws://" + ClientBase.serverAdress + PORT_ROUTE);
            websocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(handleRooms);
            websocket.Open();
        }

        ~RoomHandler()
        {
            this.websocket.Close();
        }

        public void createRoom(Room room)
        {
            websocket.Send(JsonConvert.SerializeObject(room));
        }

        public void joinRoom(Room room)
        {

        }

        private void handleRooms(object sender, MessageReceivedEventArgs args)
        {

        }


    }
}
