using System.Net.Sockets;
using System.Text;

internal class AesClient
{
	public static void Main(string[] args)
	{
		SecureClient sc = new SecureClient();
		sc.Start();

		return;
		Console.WriteLine("Enter message: ");
		string message = Console.ReadLine();
		StartClient(message);
	}

	public static void StartClient(string message)
	{
		try
		{
			var client = new TcpClient("127.0.0.1", 5000);
			NetworkStream stream = client.GetStream();

			string encryptedMessage = AesEncryption.Encrypt(message);
			byte[] data = Encoding.UTF8.GetBytes(encryptedMessage);

			stream.Write(data, 0, data.Length);
			Console.WriteLine("Sent: {0}", message);

			data = new byte[256];
			int bytes = stream.Read(data, 0, data.Length);
			string responseData = AesEncryption.Decrypt(Encoding.UTF8.GetString(data, 0, bytes));
			Console.WriteLine("Received: {0}", responseData);

			stream.Close();
			client.Close();
		}
		catch (Exception e)
		{
			Console.WriteLine("Exception: {0}", e.Message);
		}
	}
}