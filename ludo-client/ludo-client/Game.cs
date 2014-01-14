using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ludo_client
{
    class Game
    {
        private int[,] fields;
        private byte diceValue;
        private int usersTurnID;
        private List<int> userInGameIDs;
        private List<int> playerIDs;
        private int moveCount;

        public int[,] Fields
        {
            get { return fields; }
            set { fields = value; }
        }

        public byte DiceValue
        {
            get { return diceValue; }
            set { diceValue = value; }
        }

        public int UsersTurnID
        {
            get { return usersTurnID; }
            set { usersTurnID = value; }
        }

        public List<int> UserInGameIDs
        {
            get { return userInGameIDs; }
            set { userInGameIDs = value; }
        }

        public List<int> PlayerIDs
        {
            get { return playerIDs; }
            set { playerIDs = value; }
        }

        public int MoveCount
        {
            get { return moveCount; }
            set { moveCount = value; }
        }

        public Game()
        {
            this.fields = new int[11, 11];
            this.userInGameIDs = new List<int>();
            this.playerIDs = new List<int>();
        }
    }
}