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
        private String currentRoom;
        private Guid socketID;

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
        
        public String CurrentRoom
        {
            get { return currentRoom; }
            set { currentRoom = value; }
        }
    }
}
