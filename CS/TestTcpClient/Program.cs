using System;
using System.Net;

using ScriptsLibV2;
using ScriptsLibV2.Extensions;

namespace Client
{
	internal class Program
	{
		private static TcpClient client;

		static void Main(string[] args)
		{
			string hostname = "rtx.milkenm.net";
			IPAddress ip = Dns.GetHostAddresses(hostname)[0];
			int port = 666;

			Console.WriteLine("Starting client...");
			client = new TcpClient();
			client.OnDataReceived += Client_OnDataReceived;
			Console.WriteLine($"Connecting to {hostname}:{port} ({ip}:{port})...");
			client.Connect(ip, port);

			Console.ReadKey();
		}

		private static void Client_OnDataReceived(EndPoint source, byte[] data)
		{
			try
			{
				string received = data.ToObject<string>();
				if (received == "Yup")
				{
					Console.WriteLine("Connected successfully!");
					client.Disconnect();
					return;
				}
			}
			catch { }
			Console.WriteLine("Error connecting to server.");
		}
	}
}
