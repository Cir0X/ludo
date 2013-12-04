using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ludo_client.dto;

namespace ludo_client.dto
{
    class Ludo
    {
        private List<User> users;
        private String serverAdress;

        public List<User> Users
        {
            get { return users; }
            set { users = value; }
        }

        public String ServerAdress
        {
            get { return serverAdress; }
            set { serverAdress = value; }
        }

        public Ludo()
        {
            this.users = new List<User>();
            //this.user = new User();
        }
    }
}
