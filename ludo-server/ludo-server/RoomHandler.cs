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
                    socket.Send(JsonConvert.SerializeObject(Main.ludo));
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
                Console.WriteLine("Room " + room.RoomName + " created");
                createRoom(room);
            }

            if (room.RoomAction.Equals("joinRoom"))
            {
                joinRoom(room);
            }

            if (room.RoomAction.Equals("leaveRoom"))
            {
                leaveRoom(room);
            }
        }

        private void setUserCurrentRoomIDs(Room room)
        {
            int currentRoomID = room.RoomID;


            foreach (var userID in room.UserInRoomIDs)
            {
                Main.ludo.Users[userID].CurrentRoomID = currentRoomID;
            }
        }

        private void createRoom(Room room)
        {
            room.RoomStatus = "Waiting";
            room.RoomID = Main.ludo.Rooms.Count; // get the room count and set it as as roomID
            Main.ludo.Rooms.Add(room);
            sendUpdatedRoomList();
        }

        private void joinRoom(Room room)
        {
            setUserCurrentRoomIDs(room);
            Main.ludo.Rooms[room.RoomID] = room;
            sendUpdatedRoomList();
        }

        private void leaveRoom(Room room)
        {
            Main.ludo.Rooms[room.RoomID] = room;
            sendUpdatedRoomList();
        }

        private void sendUpdatedRoomList()
        {
            foreach (var s in roomSocketList.ToList())
            {
                s.Send(JsonConvert.SerializeObject(Main.ludo));
            }
        }
    }
}
