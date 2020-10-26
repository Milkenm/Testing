using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace ServerTesting
{
	internal class Server
	{
		public delegate void ServerCallback(string log);
		public event ServerCallback Log;

		private readonly Socket ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		private List<Socket> ConnectedSockets = new List<Socket>();

		public async Task Start()
		{
			ServerSocket.Bind(new IPEndPoint(IPAddress.Any, 1000));
			ServerSocket.Listen(10);
			while (true)
			{
				try
				{
					Log?.Invoke("lmao");
					Socket socket = await ServerSocket.AcceptAsync().ConfigureAwait(false);
					ConnectedSockets.Add(socket);
					socket.Send(Utils.ConvertObjectToByteArray("lel"));
					Log?.Invoke(socket.Connected.ToString());
					Log?.Invoke(ServerSocket.Connected.ToString());
					Log?.Invoke(socket.RemoteEndPoint.ToString());
				}
				catch (Exception ex)
				{
					Log?.Invoke($"ERROR: {ex.Message}");
				}
			}
		}
	}
}
