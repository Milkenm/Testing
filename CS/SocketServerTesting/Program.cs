
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SocketServerTesting
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Server server = new Server();
			server.StartListeningToClientAsync();
		}

		public class Server
		{
			public Server() { }

			public delegate void JDGOServerCallBack(string log);
			public event JDGOServerCallBack Log;

			private readonly Socket ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

			public async Task StartListeningToClientAsync()
			{
				ServerSocket.Bind(new IPEndPoint(IPAddress.Any, 7979));
				ServerSocket.Listen(10);
				while (true)
				{
					try
					{
						Console.WriteLine("lmao");
						Socket socket = await ServerSocket.AcceptAsync().ConfigureAwait(false);
						Console.WriteLine(socket.RemoteEndPoint);
					}
					catch (Exception ex)
					{
						Console.WriteLine($"ERROR: {ex.Message}");
					}
				}
			}

			public void lmao(IAsyncResult cb)
			{

			}
		}
	}
}
