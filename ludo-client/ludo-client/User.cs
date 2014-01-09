using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ludo_client.dto
{
    class User
    {
        private String userName;
        private int currentRoomID = -1;
        private Guid socketID;
        private int userListIndex;
        private bool handshaked;
        private bool isUserNameAvailable;
        private bool statusInRoom;

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public int CurrentRoomID
        {
            get { return currentRoomID; }
            set { currentRoomID = value; }
        }

        public Guid SocketID
        {
            get { return socketID; }
            set { socketID = value; }
        }

        public int UserListIndex
        {
            get { return userListIndex; }
            set { userListIndex = value; }
        }

        public bool Handshaked
        {
            get { return handshaked; }
            set { handshaked = value; }
        }

        public bool IsUserNameAvailable
        {
            get { return isUserNameAvailable; }
            set { isUserNameAvailable = value; }
        }

        public bool StatusInRoom
        {
            get { return statusInRoom; }
            set { statusInRoom = value; }
        }

    }
}
