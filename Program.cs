using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace b4ux1t3_Chat
{
    class Program
    {
        private static Socket _connection = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static string ip = String.Empty;
        private static int port = 50000;
        private static string name = "";

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to B4ux1t3's Simple Chat Client");
            Console.WriteLine("Entering setup. . .");
            Setup();

            Thread receiveMessages = new Thread(new ThreadStart(ReceiveMessages));
            Thread sendMessages = new
        }

        /// <summary>
        /// Recursive function which allows user to setup the client. Runs whenever the program starts up.
        /// </summary>
        private static void Setup()
        {
            Console.Clear();
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.Write("IP Adress (Ask Chris): ");
            ip = Console.ReadLine();
            Console.Write("Port (Enter to leave default): ");
            string portString = Console.ReadLine();
            if (portString != "")
            {
                port = Convert.ToInt32(portString);
            }
            string response = string.Empty;
            do
            {
                Console.WriteLine("Is this correct (Yes or no?\nName: {0}\nIP: {1}\nPort: {2}", name, ip, portString);
                response = Console.ReadLine();
            } while (response.ToLower() != "yes" && response.ToLower() != "no");
            if (response.ToLower() == "no")
            {
                Setup();
            } 
        }

        /// <summary>
        /// Will run as a thread, checking for new messages every half second.
        /// </summary>
        private static void ReceiveMessages()
        {

        }

        /// <summary>
        /// Will run as thread, prompting user for input.
        /// </summary>
        private static void InputMessages()
        {

        }
    }
}
