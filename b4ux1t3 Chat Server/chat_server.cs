using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

// b4ux1t3's Chat Server
// Created by: Chris Pilcher (a.k.a. b4ux1t3)
// Allows simple ASCII-encoded messages to be received and stored, and allows users' clients to request stored messages
// MIT License (See LICENSE.md)


namespace b4ux1t3_Chat_Server
{
    class chat_server
    {
        // 1 megabyte buffer size. first 8 bytes will be used to determine user, remaining 1016 bytes for message text. 
        private static byte[] _buffer = new byte[1024];
        private static List<Socket> _clientSockets = new List<Socket>();
        private static Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        static void Main(string[] args)
        {

        }
    }
}
