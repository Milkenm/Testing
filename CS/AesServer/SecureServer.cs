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
		rsa = RSA.Create(2048); // Create an RSA key pair
	}

	public void Start()
	{
		var listener = new TcpListener(IPAddress.Loopback, 5000);
		listener.Start();
		Console.WriteLine("Server listening...");

		using (var client = listener.AcceptTcpClient())
		using (var stream = client.GetStream())
		{
			// Send public key to client
			var publicKey = rsa.ExportParameters(false);
			var publicKeyString = Convert.ToBase64String(rsa.ExportRSAPublicKey());
			var publicKeyBytes = Encoding.UTF8.GetBytes(publicKeyString);
			stream.Write(publicKeyBytes, 0, publicKeyBytes.Length);
			Console.WriteLine("Sent public key to client");

			// Wait for client to send encrypted AES key and IV
			var buffer = new byte[2048];
			var bytesRead = stream.Read(buffer, 0, buffer.Length);
			var encryptedKeyIv = new byte[bytesRead];
			Array.Copy(buffer, encryptedKeyIv, bytesRead);
			Console.WriteLine("Received encrypted AES key and IV from client");

			// Decrypt AES key and IV
			var decryptedKeyIv = rsa.Decrypt(encryptedKeyIv, RSAEncryptionPadding.OaepSHA256);
			// Assuming first 32 bytes are key, next 16 bytes are IV
			var aesKey = new byte[32];
			var aesIv = new byte[16];
			Array.Copy(decryptedKeyIv, 0, aesKey, 0, 32);
			Array.Copy(decryptedKeyIv, 32, aesIv, 0, 16);

			Console.WriteLine("Secure channel established");
			// Proceed with AES-encrypted communication...
		}
	}
}
