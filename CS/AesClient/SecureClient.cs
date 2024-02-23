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
		using (TcpClient? client = new TcpClient("localhost", 5000))
		using (NetworkStream? stream = client.GetStream())
		{
			// Receive public key from server
			byte[] publicKeyBytes = ReceivePublicKey(stream);

			using (RSA rsa = RSA.Create())
			{
				rsa.ImportRSAPublicKey(publicKeyBytes, out _);

				// Generate AES key and IV
				SendAESKeyAndIV(stream, rsa);
			}
		}
	}

	private static byte[] ReceivePublicKey(NetworkStream stream)
	{
		byte[]? buffer = new byte[2048];
		int bytesRead = stream.Read(buffer, 0, buffer.Length);
		string? publicKeyString = Encoding.UTF8.GetString(buffer, 0, bytesRead);
		byte[]? publicKeyBytes = Convert.FromBase64String(publicKeyString);
		return publicKeyBytes;
	}

	private static void SendAESKeyAndIV(NetworkStream stream, RSA rsa)
	{
		using (Aes aes = Aes.Create())
		{
			aes.GenerateKey();
			aes.GenerateIV();

			// Encrypt AES key and IV with server's public RSA key
			byte[]? keyIv = new byte[aes.Key.Length + aes.IV.Length];
			Array.Copy(aes.Key, 0, keyIv, 0, aes.Key.Length);
			Array.Copy(aes.IV, 0, keyIv, aes.Key.Length, aes.IV.Length);

			byte[]? encryptedKeyIv = rsa.Encrypt(keyIv, RSAEncryptionPadding.OaepSHA256);

			// Send encrypted AES key and IV to server
			stream.Write(encryptedKeyIv, 0, encryptedKeyIv.Length);

			Console.WriteLine("Sent encrypted AES key and IV to server");
			// Proceed with AES-encrypted communication...
		}
	}
}