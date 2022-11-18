using System.Windows.Forms;

using static ServerTesting.Server;

namespace ServerTesting
{
	public partial class Main : Form
	{
		private Client c = new Client();
		private Server s = new Server();

		public Main()
		{
			InitializeComponent();
		}

		private async void Main_Load(object sender, System.EventArgs e)
		{
			s.Log += new ServerCallback((log) => listBox_server.Items.Add(log));

			await s.Start().ConfigureAwait(false);


			//s.ClientConnected += new ServerClientEvent((client) => listBox_server.Items.Add("Client connected: " + client.ToString()));
			//s.ClientDisconnected += new ServerClientEvent((client) => listBox_server.Items.Add("Client disconnected: " + client.ToString()));
		}

		private void button_connectToServer_Click(object sender, System.EventArgs e)
		{
			c.ConnectToServer();
		}
	}
}
