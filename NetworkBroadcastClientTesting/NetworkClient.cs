using System;
using System.Net;

using static ScriptsLib.Network.Packets;

namespace NetworkBroadcastClientTesting
{
    internal static class NetworkClient
    {
        private static void Main()
        {
            SendUdpPacket(IPAddress.Broadcast.ToString(), 11000, "lel");
            Console.WriteLine("Message sent to the broadcast address");
        }
    }
}
