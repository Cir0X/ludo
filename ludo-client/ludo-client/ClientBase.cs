using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ludo_client
{
    class ClientBase
    {
        public static String serverAdress;
        public static int myUserListIndex = -1;
        public static String createRoomName;
        public static bool isConnected = false;
        private short connectionCount;
        public static int roomListSelectionID;

        public void addConnetionCount()
        {
            this.connectionCount++;
        }

        public void removeConnectionCount()
        {
            this.connectionCount--;
        }
    }
}
