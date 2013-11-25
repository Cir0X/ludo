using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fleck;

namespace ludo_server
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new WebSocketServer("ws://localhost:1337");
            server.Start(socket =>
            {
                socket.OnOpen = () => Console.WriteLine("Open!");
                socket.OnClose = () => Console.WriteLine("Close!");
                socket.OnMessage = message => socket.Send(message);
            });
            Console.WriteLine("Press any Key to stop");
            Console.ReadLine();

        }
    }
}
