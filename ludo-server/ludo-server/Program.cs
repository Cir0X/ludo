using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fleck;
using ludo_server.dto;

namespace ludo_server
{
    class Program
    {
        static void Main(string[] args)
        {
            Ludo ludo = new Ludo();
            Authenticate authenticate = new Authenticate(ludo);
            Chat chat = new Chat();
        }
    }
}
