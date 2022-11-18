#region Usings
using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
#endregion Usings



namespace Testing.TokenDB
{
	public partial class TokenDBTesting : Form
	{
		private Rijndael rij = Rijndael.Create();

		public TokenDBTesting()
		{
			InitializeComponent();
		}

		private void button_createToken_Click(object sender, EventArgs e)
		{
			byte[] encrypted = EncryptToken("Data", rij.Key, rij.IV);

			textBox_token.Text = System.Text.Encoding.Default.GetString(encrypted);
		}

		private void button_decodeToken_Click(object sender, EventArgs e)
		{
			byte[] stream;

			using (MemoryStream ms = new MemoryStream())
			{
				using (StreamWriter sw = new StreamWriter(ms))
				{
					sw.Write(textBox_token.Text);
				}
				stream = ms.ToArray();
			}


			textBox_tokenData.Text = DecryptToken(stream, rij.Key, rij.IV);
		}






		private static byte[] EncryptToken(string plainText, byte[] Key, byte[] IV)
		{
			if (plainText == null || plainText.Length <= 0)
			{
				throw new ArgumentNullException("plainText");
			}

			if (Key == null || Key.Length <= 0)
			{
				throw new ArgumentNullException("Key");
			}

			if (IV == null || IV.Length <= 0)
			{
				throw new ArgumentNullException("IV");
			}

			byte[] encrypted;

			using (Rijndael rijAlg = Rijndael.Create())
			{
				rijAlg.Key = Key;
				rijAlg.IV = IV;

				ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

				using (MemoryStream msEncrypt = new MemoryStream())
				{
					using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
					{
						using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
						{
							swEncrypt.Write(plainText);
						}
						encrypted = msEncrypt.ToArray();
					}
				}
			}
			return encrypted;
		}

		private static string DecryptToken(byte[] cipherText, byte[] Key, byte[] IV)
		{
			if (cipherText == null || cipherText.Length <= 0)
			{
				throw new ArgumentNullException("cipherText");
			}

			if (Key == null || Key.Length <= 0)
			{
				throw new ArgumentNullException("Key");
			}

			if (IV == null || IV.Length <= 0)
			{
				throw new ArgumentNullException("IV");
			}

			string plaintext = null;

			using (Rijndael rijAlg = Rijndael.Create())
			{
				rijAlg.Key = Key;
				rijAlg.IV = IV;

				ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

				using (MemoryStream msDecrypt = new MemoryStream(cipherText))
				{
					using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
					{
						using (StreamReader srDecrypt = new StreamReader(csDecrypt))
						{
							plaintext = srDecrypt.ReadToEnd();
						}
					}
				}
			}
			return plaintext;
		}
	}
}
