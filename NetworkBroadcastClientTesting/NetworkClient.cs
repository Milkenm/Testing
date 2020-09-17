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

            IPAddress broadcast = IPAddress.Parse("216.58.201.163"); // google.pt

            string sendString = "";
            for (int i = 0; i < 10000; i++)
            {
                sendString = sendString + "z";
            }

            byte[] sendbuf = Encoding.ASCII.GetBytes(sendString);
            IPEndPoint ep = new IPEndPoint(broadcast, 11000);

            while (true)
            {
                s.SendTo(sendbuf, ep);
            }

            Console.WriteLine("Message sent to the broadcast address");
        }
    }
}
