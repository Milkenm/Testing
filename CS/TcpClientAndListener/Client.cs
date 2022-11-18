using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TcpClientAndListener
{
	internal class Client
	{
		private TcpClient client = new TcpClient();

		public void Connect(IPEndPoint ep)
		{
			client.Connect(ep);
		}

		public void Disconnect()
		{
			client.Close();
			client = new TcpClient();
		}

		public void SendString(string text)
		{
			client.SendString(text);
		}
	}

	internal static class lel
	{
		public static void SendString(this TcpClient client, string text)
		{
			byte[] result = Encoding.ASCII.GetBytes(text);
			SendBytes(client, result);
		}

		public static void SendBytes(this TcpClient client, byte[] bytes)
		{
			client.GetStream().Write(bytes, 0, bytes.Length);
		}
	}
}
