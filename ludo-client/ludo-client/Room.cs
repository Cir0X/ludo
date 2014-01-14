using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ludo_client.dto
{
    class Room
    {
        private int roomID;
        private String roomName;
        private int roomModeratorUserID;
        private List<int> userInRoomIDs;
        private List<int> readyUsersInRoomIDs;
        private String roomStatus;
        private String roomAction;
        private Game game;

        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public String RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }

        public int RoomModeratorUserID
        {
            get { return roomModeratorUserID; }
            set { roomModeratorUserID = value; }
        }

        public List<int> UserInRoomIDs
        {
            get { return userInRoomIDs; }
            set { userInRoomIDs = value; }
        }

        public List<int> ReadyUsersInRoomIDs
        {
            get { return readyUsersInRoomIDs; }
            set { readyUsersInRoomIDs = value; }
        }

        public String RoomStatus
        {
            get { return roomStatus; }
            set { roomStatus = value; }
        }

        public String RoomAction
        {
            get { return roomAction; }
            set { roomAction = value; }
        }

        public Game Game
        {
            get { return game; }
            set { game = value; }
        }

        public Room()
        {
            this.userInRoomIDs = new List<int>();
            this.readyUsersInRoomIDs = new List<int>();
            this.game = new Game();
        }

    }
}
