using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NetworkBroadcastClientTesting
{
    internal static class NetworkClient
    {
        private static void Main()
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPAddress broadcast = IPAddress.Parse("192.168.1.255");

            string sendString = "teste";

            byte[] sendbuf = Encoding.ASCII.GetBytes(sendString);
            IPEndPoint ep = new IPEndPoint(broadcast, 11000);

            s.SendTo(sendbuf, ep);

            Console.WriteLine("Message sent to the broadcast address");
        }
    }
}
