using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageToBase64
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private readonly string imagePath;

		private void button_encode_Click(object sender, EventArgs e)
		{
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				string selectedFile = fileDialog.FileName;
				if (string.IsNullOrEmpty(selectedFile))
				{
					return;
				}
				pictureBox_encode.Image = Image.FromFile(selectedFile);

				string imageBase64 = ImageToBase64(pictureBox_encode.Image);
				Console.WriteLine("Image Base64:\n\n" + imageBase64);
				pictureBox_decode.Image = Base64ToImage(imageBase64);
			}
		}

		public static string ImageToBase64(Image image)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				image.Save(ms, image.RawFormat);
				return Convert.ToBase64String(ms.ToArray());
			}
		}

		public static Image Base64ToImage(string base64)
		{
			byte[] imageBytes = Convert.FromBase64String(base64);
			return new Bitmap(new MemoryStream(imageBytes));
		}
	}
}
