using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ludo_server.dto;

namespace ludo_server.dto
{
    class Ludo
    {
        private List<User> users;
        private List<Message> chat;

        public List<User> Users
        {
            get { return users; }
            set { users = value; }
        }

        public List<Message> Chat
        {
            get { return chat; }
            set { chat = value; }
        }

        public Ludo()
        {
            this.users = new List<User>();
            this.chat = new List<Message>();
        }
    }
}
