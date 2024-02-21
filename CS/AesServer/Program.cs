using System.Net.Sockets;
using System.Net;
using System.Text;

internal class Program
{
	public static void Main(string[] args)
	{
		StartServer();
	}

	public static void StartServer()
	{
		var ipAddress = IPAddress.Parse("127.0.0.1");
		var listener = new TcpListener(ipAddress, 5000);
		listener.Start();
		Console.WriteLine("Server is running");
		Console.WriteLine("Waiting for a connection...");

		TcpClient client = listener.AcceptTcpClient();
		Console.WriteLine("Connected!");
		NetworkStream stream = client.GetStream();

		while (true)
		{
			byte[] bytes = new byte[256];
			int i = stream.Read(bytes, 0, bytes.Length);
			if (i != 0)
			{
				string decryptedData = AesEncryption.Decrypt(Encoding.UTF8.GetString(bytes, 0, i));
				Console.WriteLine("Received: {0}", decryptedData);

				string encryptedResponse = AesEncryption.Encrypt(decryptedData);
				byte[] msg = Encoding.UTF8.GetBytes(encryptedResponse);
				stream.Write(msg, 0, msg.Length);
				Console.WriteLine("Sent: {0}", decryptedData);
			}
		}
	}
}