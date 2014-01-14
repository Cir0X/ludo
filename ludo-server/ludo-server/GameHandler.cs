using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ludo_server.dto;
using Fleck;
using Newtonsoft.Json;

namespace ludo_server
{
    class GameHandler
    {
        private List<IWebSocketConnection> gameSocketList;
        private LudoLogicHandler ludoLogicHandler;
        public GameHandler()
        {
            gameSocketList = new List<IWebSocketConnection>();
            this.ludoLogicHandler = new LudoLogicHandler();
            var server = new WebSocketServer("ws://localhost:5004/game");

            server.Start(socket => 
            {
                socket.OnOpen = () =>
                {
                    gameSocketList.Add(socket);
                    //Room room = new Room();
                    //getUsersTurnID(room);
                    syncGame();
                };

                socket.OnClose = () => gameSocketList.Remove(socket);

                socket.OnMessage = message => handleGame(socket, message);
            });
        }

        private void handleGame(IWebSocketConnection socket, String message)
        {
            Room newRoom = JsonConvert.DeserializeObject<Room>(message);
            Room room = Main.ludo.Rooms[newRoom.RoomID];
            room.RoomAction = newRoom.RoomAction;

            if (room.Game.MoveCount == 0)
            {
                room.Game.Fields = ludoLogicHandler.initGame(room);
                Console.WriteLine(" Init Map: " + room.Game.Fields[0, 0]);
            }

            if (room.RoomAction.Equals("rollTheDice"))
            {
                room.Game.DiceValue = rollTheDice();
                room.RoomAction = "diceRolled";
                Console.WriteLine("Rolled Value: " + room.Game.DiceValue);
                room = getUsersTurnID(room);
            }

            Console.WriteLine("It's " + Main.ludo.Users[room.Game.UsersTurnID].UserName + "'s turn!");

            room.Game.MoveCount += 1;
            Main.ludo.Rooms[room.RoomID].Game = room.Game;

            Console.WriteLine("Field: 0 0" + room.Game.Fields[0, 0]);
            Console.WriteLine("Field: 9 0" + room.Game.Fields[9, 0]);
             
            syncGame();
            //sendGame(room);
        }

        private byte rollTheDice()
        {
            Random random = new Random();
            return (byte)random.Next(1, 7);
        }

        private Room getUsersTurnID(Room room)
        {
            if (room.Game.UsersTurnID > -1 && getUsersTurnIndex(room) < room.Game.UserInGameIDs.Count() -1)
            {
                room.Game.UsersTurnID = room.Game.UserInGameIDs[getUsersTurnIndex(room) + 1];
            }
            else
            {
                room.Game.UsersTurnID = room.Game.UserInGameIDs[0];
            }
            Main.ludo.Rooms[room.RoomID].Game.UsersTurnID = room.Game.UsersTurnID;
            return room;
        }

        private int getUsersTurnIndex(Room room)
        {
            foreach (var userID in room.Game.UserInGameIDs)
            {
                if (userID == room.Game.UsersTurnID)
                {
                    return room.Game.UserInGameIDs.IndexOf(userID);
                }
            }
            return -1;
        }
       

        private void sendGame(Room room)
        {
            foreach (var s in gameSocketList.ToList())
            {
                s.Send(JsonConvert.SerializeObject(room));

            }
        }

        private void syncGame()
        {
            foreach (var s in gameSocketList.ToList())
            {
                s.Send(JsonConvert.SerializeObject(Main.ludo));
            }
        }

    }
}
