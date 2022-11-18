using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ServerTesting
{
	internal class Client
	{
		private readonly TcpClient TcpClient = new TcpClient();

		private readonly IPEndPoint ServerEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1000);

		public void ConnectToServer()
		{
			TcpClient.Connect(ServerEP);
			NetworkStream stream = TcpClient.GetStream();
			byte[] b = new byte[1024];
			stream.Read(b, 0, b.Length);
			string d = Utils.ConvertByteArrayToObject<string>(b);
			MessageBox.Show(d);
		}
	}
}
