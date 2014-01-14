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
            Console.WriteLine("JSON: " + message);
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

            if (room.RoomAction.Equals("setReady"))
            {
                setReady(room);
            }

            if (room.RoomAction.Equals("setStart"))
            {
                setStart(room);
            }
        }

        // Sets the Room Moderator to the first User in Room List
        private Room getRoomModerator(Room room) {
            room.ReadyUsersInRoomIDs.Clear(); // when the moderator changes clear the ready user list
            room.RoomModeratorUserID = room.UserInRoomIDs[0];
            return room;
        }

        private bool deleteRoomWhenEmpty(Room room)
        {
            if (room.UserInRoomIDs.Count == 0)
            {
                Main.ludo.Rooms.RemoveAt(room.RoomID);
                sendUpdatedRoomList();
                return true;
            }
            else
            {
                return false;
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

        private void setLeavingUserCurrentRoomID(Room room)
        {
            List<int> leavingUserID = Main.ludo.Rooms[room.RoomID].UserInRoomIDs.Except(room.UserInRoomIDs).ToList();
            Console.WriteLine("Leaving User ID: " + leavingUserID[0]);
            if (leavingUserID.Count > 0 && Main.ludo.Users.Contains(Main.ludo.Users[leavingUserID[0]]))
            {
                Main.ludo.Users[leavingUserID[0]].CurrentRoomID = -1;
            }
        }

        private void createRoom(Room room)
        {
            room.RoomStatus = "Waiting";
            room.RoomID = Main.ludo.Rooms.Count; // get the room count and set it as as roomID
            room.RoomAction = "roomCreated";
            Main.ludo.Rooms.Add(room);
            sendUpdatedRoomList();
        }

        private void joinRoom(Room room)
        {
            setUserCurrentRoomIDs(room);
            room.RoomAction = "roomJoined";
            room = getRoomModerator(room);
            // sometimes nullPointerException out of no where...
            Main.ludo.Rooms[room.RoomID] = room;
            sendUpdatedRoomList();
        }

        private void leaveRoom(Room room)
        {
            room.RoomAction = "roomLeft";
            setLeavingUserCurrentRoomID(room);
            if (!deleteRoomWhenEmpty(room)) // When the room still exists
            {
                room = getRoomModerator(room); // set the new room moderator when room isn't empty
                Main.ludo.Rooms[room.RoomID] = room;
            }
            sendUpdatedRoomList();
        }

        private void setReady(Room room)
        {
            foreach (var userID in room.UserInRoomIDs)
            {
                // set the status to default false
                Main.ludo.Users[userID].StatusInRoom = false;
                foreach (var readyUserID in room.ReadyUsersInRoomIDs)
                {
                    Console.WriteLine("Ready User in List: " + Main.ludo.Users[readyUserID].UserName);
                    if (userID == readyUserID)
                    {
                        // when the user is in readyUsersInRoomIDs List set status true
                        Console.WriteLine("User " + Main.ludo.Users[userID].UserName + " is ready");
                        Main.ludo.Users[userID].StatusInRoom = true;
                    }
                }
            }
            Main.ludo.Rooms[room.RoomID].ReadyUsersInRoomIDs = room.ReadyUsersInRoomIDs;
            Console.WriteLine("Ready Users: " + Main.ludo.Rooms[room.RoomID].ReadyUsersInRoomIDs.Count);
            sendUpdatedRoomList();
        }

        private void setStart(Room room)
        {
            room.RoomStatus = "Starting";
            Main.ludo.Rooms[room.RoomID] = room;

            for (int i = 5; i > 0; i--)
            {
                room.RoomAction = "Starting in " + i;
                Console.WriteLine(room.RoomAction + i);
                sendUpdatedRoomList();
                System.Threading.Thread.Sleep(1000);
            }

            // Adding all ready Users and the room moderator to the userInGame List
            Main.ludo.Rooms[room.RoomID].Game.UserInGameIDs.Add(room.RoomModeratorUserID);
            foreach (var userID in Main.ludo.Rooms[room.RoomID].ReadyUsersInRoomIDs) 
            {
                Main.ludo.Rooms[room.RoomID].Game.UserInGameIDs.Add(userID);
            }

            room.RoomAction = "Starting now ...";
            sendUpdatedRoomList();
            room.RoomStatus = "Playing";
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