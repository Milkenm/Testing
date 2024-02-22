using System.Net.Sockets;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;
using System;

public static class AesEncryption
{
	public static void Main(string[] args)
	{

	}

	static AesEncryption()
	{
		// Example of using the above method
		/*var (key, iv) = AesKeyIvGenerator.GenerateKeyAndIv();
		Console.WriteLine($"Key: {Convert.ToBase64String(key)}");
		Console.WriteLine($"IV: {Convert.ToBase64String(iv)}");

		Key = key;
		IV = iv;*/
	}

	private static byte[] Key = Convert.FromBase64String("xf53Umj9pofV9fyHXj/yZcuC7I5BCXlYkHwmMTjuvMw=");
	private static byte[] IV = Convert.FromBase64String("fAeSVg3uvPJvNBH+Vm1GSA==");

	public static string Encrypt(string plainText)
	{
		using (Aes aesAlg = Aes.Create())
		{
			aesAlg.Key = Key;
			aesAlg.IV = IV;

			ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
			using (MemoryStream msEncrypt = new MemoryStream())
			{
				using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
				{
					using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
					{
						swEncrypt.Write(plainText);
					}
				}
				return Convert.ToBase64String(msEncrypt.ToArray());
			}
		}
	}

	public static string Decrypt(string cipherText)
	{
		using (Aes aesAlg = Aes.Create())
		{
			aesAlg.Key = Key;
			aesAlg.IV = IV;

			ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
			using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
			{
				using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
				{
					using (StreamReader srDecrypt = new StreamReader(csDecrypt))
					{
						return srDecrypt.ReadToEnd();
					}
				}
			}
		}
	}
}

public static class AesKeyIvGenerator
{
	public static (byte[], byte[]) GenerateKeyAndIv()
	{
		using (var rng = new RNGCryptoServiceProvider())
		{
			byte[] key = new byte[32]; // 256 bits for AES-256
			byte[] iv = new byte[16]; // 128 bits for AES IV
			rng.GetBytes(key);
			rng.GetBytes(iv);
			return (key, iv);
		}
	}
}