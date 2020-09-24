using System;
using System.Net.Sockets;

namespace Cliuente
{
    public class Program
    {
        static void Main(string[] args)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Tcp);
            s.Connect("127.0.0.1", 8);
            s.Close();
            s.Dispose();

        }
    }
}
