using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

public class SecureClient
{
	public void Start()
	{
		using (var client = new TcpClient("localhost", 5000))
		using (var stream = client.GetStream())
		{
			// Receive public key from server
			var buffer = new byte[2048];
			var bytesRead = stream.Read(buffer, 0, buffer.Length);
			var publicKeyString = Encoding.UTF8.GetString(buffer, 0, bytesRead);
			var publicKeyBytes = Convert.FromBase64String(publicKeyString);

			using (RSA rsa = RSA.Create())
			{
				rsa.ImportRSAPublicKey(publicKeyBytes, out _);

				// Generate AES key and IV
				using (Aes aes = Aes.Create())
				{
					aes.GenerateKey();
					aes.GenerateIV();

					// Encrypt AES key and IV with server's public RSA key
					var keyIv = new byte[aes.Key.Length + aes.IV.Length];
					Array.Copy(aes.Key, 0, keyIv, 0, aes.Key.Length);
					Array.Copy(aes.IV, 0, keyIv, aes.Key.Length, aes.IV.Length);

					var encryptedKeyIv = rsa.Encrypt(keyIv, RSAEncryptionPadding.OaepSHA256);

					// Send encrypted AES key and IV to server
					stream.Write(encryptedKeyIv, 0, encryptedKeyIv.Length);

					Console.WriteLine("Sent encrypted AES key and IV to server");
					// Proceed with AES-encrypted communication...
				}
			}
		}
	}
}