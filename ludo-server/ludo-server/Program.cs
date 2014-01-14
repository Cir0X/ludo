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
            Main main = new Main();
            AuthenticationHandler authenticationHandler = new AuthenticationHandler();
            OnlineUserHandler onlineUserHandler = new OnlineUserHandler();
            ChatHandler chatHandler = new ChatHandler();
            RoomHandler roomHandler = new RoomHandler();
            GameHandler gameHandler = new GameHandler();
            Console.Read();
        }
    }
}
