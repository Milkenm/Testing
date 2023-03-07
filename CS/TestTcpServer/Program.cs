using System;
using System.Net.Sockets;
using System.Threading.Tasks;

using ScriptsLibV2;
using ScriptsLibV2.Extensions;

namespace TestTcp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			TcpServer server = new TcpServer(666);
			server.OnClientConnect += Server_OnClientConnect;
			server.OnClientDisconnect += Server_OnClientDisconnect;
			server.UseAsynchronousEvents = true;
			server.Start();

			Task.Delay(-1).Wait();
		}

		private static void Server_OnClientDisconnect(Socket client)
		{
			Console.WriteLine("Client disconnected.");
		}

		private static void Server_OnClientConnect(Socket client)
		{
			Console.WriteLine("Client connected.");
			client.Send("Yup".ToByteArray());
		}
	}
}
