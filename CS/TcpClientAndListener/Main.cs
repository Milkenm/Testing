using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TcpClientAndListener
{
	public partial class Main : Form
	{
		private static readonly Client client = new Client();

		private static readonly short port = 6903;
		private static readonly IPEndPoint serverEp = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);

		public Main()
		{
			InitializeComponent();

			button_sendPacket.Enabled = false;
		}

		private void Main_Load(object sender, EventArgs e)
		{
			TcpServer server = new TcpServer(port);
			server.OnClientConnected += TcpServer_OnClientConnected;
			server.OnClientDisconnected += TcpServer_OnClientDisconnected;
			server.OnDataReceived += S_OnDataReceived;
			server.Start();
		}

		private void S_OnDataReceived(EndPoint source, byte[] data)
		{
			string dataString = Encoding.ASCII.GetString(data);
			listBox_listener.Items.Add($"Received data from '{source}': {dataString}");
		}

		private void TcpServer_OnClientConnected(Socket client)
		{
			listBox_listener.Items.Add("[+] Client connected.");
		}

		private void TcpServer_OnClientDisconnected(Socket client)
		{
			listBox_listener.Items.Add("[-] Client disconnected.");
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

				client.Disconnect();
			}
		}

		private void button_sendPacket_Click(object sender, EventArgs e)
		{
			client.SendString("kek");
		}
	}
}
