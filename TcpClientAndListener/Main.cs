using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TcpClientAndListener
{
	public partial class Main : Form
	{
		private static readonly short port = 6903;
		private static readonly IPEndPoint serverEp = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);

		private TcpClient client = new TcpClient();


		public Main()
		{
			InitializeComponent();

			button_sendPacket.Enabled = false;
		}

		private void Main_Load(object sender, EventArgs e)
		{
			Server server = new Server(port);
			server.OnClientConnected += S_OnClientConnected;
			server.OnClientDisconnected += S_OnClientDisconnected;
			server.OnDataReceived += S_OnDataReceived;
			server.Start();
		}

		private void S_OnDataReceived(EndPoint source, byte[] data)
		{
			string dataString = Encoding.ASCII.GetString(data);
			listBox_listener.Items.Add($"Received data from '{source}': {dataString}");
		}

		private void S_OnClientDisconnected()
		{
			listBox_listener.Items.Add("[-] Client disconnected.");
		}

		private void S_OnClientConnected()
		{
			listBox_listener.Items.Add("[+] Client connected.");
		}

		private void button_connect_Click(object sender, EventArgs e)
		{
			if (button_connect.Text == "Connect")
			{
				button_connect.Text = "Disconnect";
				button_sendPacket.Enabled = true;

				client.Connect(serverEp);
			}
			else
			{
				button_connect.Text = "Connect";
				button_sendPacket.Enabled = false;

				client = new TcpClient();
			}
		}

		private void button_sendPacket_Click(object sender, EventArgs e)
		{
			byte[] result = Encoding.ASCII.GetBytes("kek");

			client.GetStream().Write(result, 0, result.Length);
		}
	}
}
