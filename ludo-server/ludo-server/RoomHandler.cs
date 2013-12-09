using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ludo_server.dto;
using Newtonsoft.Json;
using Fleck;

namespace ludo_server
{
    class RoomHandler
    {
        private List<IWebSocketConnection> roomSocketList;
        public RoomHandler()
        {
            roomSocketList = new List<IWebSocketConnection>();
            var server = new WebSocketServer("ws://localhost:5003/rooms");
            server.Start(socket =>
            {
                socket.OnOpen = () =>
                {
                    roomSocketList.Add(socket);
                    socket.Send(JsonConvert.SerializeObject(Main.ludo.Rooms));
                };

                socket.OnClose = () =>
                {
                    roomSocketList.Remove(socket);
                };

                socket.OnMessage = message => handleRooms(socket, message);

            });
        }

        private void handleRooms(IWebSocketConnection socket, String message)
        {
            Room room = JsonConvert.DeserializeObject<Room>(message);
            if (room.RoomAction.Equals("createRoom"))
            {
                createRoom(room);
            }
        }

        private void createRoom(Room room)
        {
            Main.ludo.Rooms.Add(room);
            foreach (var s in roomSocketList.ToList())
            {
                s.Send(JsonConvert.SerializeObject(room));
            }
        }
    }
}
