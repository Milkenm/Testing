using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace TcpClientAndListener
{
	internal class Server
	{
		public Server(short port)
		{
			IPEndPoint ep = new IPEndPoint(IPAddress.Any, port);

			server = new TcpListener(ep);
			server.Start();
		}

		private readonly TcpListener server;

		public delegate void ConnectionEvent();
		public event ConnectionEvent OnClientConnected;
		public event ConnectionEvent OnClientDisconnected;

		public delegate void DataReceived(EndPoint source, byte[] data);
		public event DataReceived OnDataReceived;

		public void Start()
		{
			AcceptClientsAsync();
		}

		private async Task AcceptClientsAsync()
		{
			await Task.Run(() =>
			{
				while (true)
				{
					ClientProcess();
				}
			}).ConfigureAwait(false);
		}

		// https://stackoverflow.com/a/11664073
		private async Task ClientProcess()
		{
			Socket socket;
			try
			{
				socket = await server.AcceptSocketAsync().ConfigureAwait(false);
				OnClientConnected?.Invoke();
				socket.ReceiveTimeout = 20000;
			}
			catch
			{
				return;
			}

			while (true)
			{
				byte[] buffer = new byte[socket.ReceiveBufferSize];
				int read;

				try
				{
					read = socket.Receive(buffer);
				}
				catch
				{
					break;
				}

				if (read > 0) // HANDLE RECEIVED DATA
				{
					OnDataReceived?.Invoke(socket.RemoteEndPoint, buffer);
				}
				else
				{
					break;
				}
			}

			socket?.Close(5000);
			OnClientDisconnected?.Invoke();
		}
	}
}
