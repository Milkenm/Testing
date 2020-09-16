using System;
using System.Net.Sockets;

using static ScriptsLib.Network.Packets;

namespace NetworkBroadcast.HostTesting
{
    internal static class NetworkHost
    {
        public static void Main()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Waiting for broadcast");

                    string message = WaitUdpPacket(11000);

                    Console.WriteLine($"Received: {message}");
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}