using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ludo_server.dto;

namespace ludo_server
{
    class LudoLogicHandler
    {
        //public byte[,] handleLudoLogic(Room room)
        //{
            
        //}

        public int[,] initGame(Room room)
        {
            int[,] fields = new int[11, 11];

            for (int x = 0; x <= 10; x++)
            {
                for (int y = 0; y <= 10; y++)
                {
                    fields[x, y] = -1;
                }
            }

            if (room.Game.UserInGameIDs.Count() == 2)
            {
                fields = initPlayerOneStartFields(fields, room);
                fields = initPLayerTwoStartFields(fields, room);
            }
            else if (room.Game.UserInGameIDs.Count() == 3)
            {
                fields = initPlayerOneStartFields(fields, room);
                fields = initPLayerTwoStartFields(fields, room);
                fields = initPLayerThreeStartFields(fields, room);
            }
            else if (room.Game.UserInGameIDs.Count() == 4)
            {
                fields = initPlayerOneStartFields(fields, room);
                fields = initPLayerTwoStartFields(fields, room);
                fields = initPLayerThreeStartFields(fields, room);
                fields = initPLayerFourStartFields(fields, room);
            }
            return fields;
        }

        private int[,] initPlayerOneStartFields(int[,] fields, Room room)
        {
            int playerOneID = room.Game.UserInGameIDs[0];
            fields[0, 0] = playerOneID;
            fields[0, 1] = playerOneID;
            fields[1, 0] = playerOneID;
            fields[1, 1] = playerOneID;
            return fields;
        }

        private int[,] initPLayerTwoStartFields(int[,] fields, Room room)
        {
            int playerTwoID = room.Game.UserInGameIDs[1];
            fields[9, 0] = playerTwoID;
            fields[9, 1] = playerTwoID;
            fields[10, 0] = playerTwoID;
            fields[10, 1] = playerTwoID;
            return fields;
        }

        private int[,] initPLayerThreeStartFields(int[,] fields, Room room)
        {
            int playerThreeID = room.Game.UserInGameIDs[2];
            fields[0, 9] = playerThreeID;
            fields[1, 9] = playerThreeID;
            fields[0, 10] = playerThreeID;
            fields[1, 10] = playerThreeID;
            return fields;
        }

        private int[,] initPLayerFourStartFields(int[,] fields, Room room)
        {
            int playerFourID = room.Game.UserInGameIDs[3];
            fields[9, 9] = playerFourID;
            fields[9, 10] = playerFourID;
            fields[10, 9] = playerFourID;
            fields[10, 10] = playerFourID;
            return fields;
        }
    }
}
