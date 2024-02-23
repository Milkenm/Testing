using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

public class SecureServer
{
	private RSA rsa;

	public SecureServer()
	{
		// Create an RSA key pair
		rsa = RSA.Create(4096);
	}

	public void Start()
	{
		TcpListener? listener = new TcpListener(IPAddress.Loopback, 5000);
		listener.Start();
		Console.WriteLine("Server listening...");

		using (TcpClient? client = listener.AcceptTcpClient())
		using (NetworkStream? stream = client.GetStream())
		{
			// Send public key to client
			SendPublicKey(stream);

			// Wait for client to send encrypted AES key and IV
			byte[] encryptedKeyIv = ReceiveAESKeyAndIV(stream);

			// Decrypt AES key and IV
			DecryptAES(encryptedKeyIv);

			Console.WriteLine("Secure channel established");
			// Proceed with AES-encrypted communication...
		}
	}

	private void DecryptAES(byte[] encryptedKeyIv)
	{
		byte[]? decryptedKeyIv = rsa.Decrypt(encryptedKeyIv, RSAEncryptionPadding.OaepSHA256);
		// Assuming first 32 bytes are key, next 16 bytes are IV
		byte[]? aesKey = new byte[32];
		byte[]? aesIv = new byte[16];
		Array.Copy(decryptedKeyIv, 0, aesKey, 0, 32);
		Array.Copy(decryptedKeyIv, 32, aesIv, 0, 16);
	}

	private static byte[] ReceiveAESKeyAndIV(NetworkStream stream)
	{
		byte[]? buffer = new byte[2048];
		int bytesRead = stream.Read(buffer, 0, buffer.Length);
		byte[]? encryptedKeyIv = new byte[bytesRead];
		Array.Copy(buffer, encryptedKeyIv, bytesRead);
		Console.WriteLine("Received encrypted AES key and IV from client");
		return encryptedKeyIv;
	}

	private void SendPublicKey(NetworkStream stream)
	{
		RSAParameters publicKey = rsa.ExportParameters(false);
		string? publicKeyString = Convert.ToBase64String(rsa.ExportRSAPublicKey());
		byte[]? publicKeyBytes = Encoding.UTF8.GetBytes(publicKeyString);
		stream.Write(publicKeyBytes, 0, publicKeyBytes.Length);
		Console.WriteLine("Sent public key to client");
	}
}
