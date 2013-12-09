using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ludo_server.dto
{
    class Room
    {
        private String roomName;
        private List<User> usersInRoom;
        private byte currentPlayerCount;
        private String roomStatus;
        private String roomAction;

        public String RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }

        public List<User> UsersInRoom
        {
            get { return usersInRoom; }
            set { usersInRoom = value; }
        }

        public byte CurrentPlayerCount
        {
            get { return currentPlayerCount; }
            set { currentPlayerCount = value; }
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

        public Room()
        {
            this.usersInRoom = new List<User>();
        }

    }
}
