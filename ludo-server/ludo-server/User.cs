using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ludo_server.dto
{
    class User
    {
        private String userName;
        private String currentView;
        private Guid socketID;
        private int userListIndex;
        private bool handshaked;
        private bool isUserNameAvailable;

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public Guid SocketID
        {
            get { return socketID; }
            set { socketID = value; }
        }

        public String CurrentView
        {
            get { return currentView; }
            set { currentView = value; }
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
    }
}