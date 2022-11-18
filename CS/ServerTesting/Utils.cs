using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ServerTesting
{
	internal class Utils
	{
		// https://stackoverflow.com/a/4865123
		public static byte[] ConvertObjectToByteArray(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			BinaryFormatter bf = new BinaryFormatter();
			using (MemoryStream ms = new MemoryStream())
			{
				bf.Serialize(ms, obj);
				return ms.ToArray();
			}
		}

		// https://stackoverflow.com/a/18205093
		public static T ConvertByteArrayToObject<T>(byte[] bytes)
		{
			MemoryStream ms = new MemoryStream();
			BinaryFormatter bf = new BinaryFormatter();
			ms.Write(bytes, 0, bytes.Length);
			ms.Seek(0, SeekOrigin.Begin);
			object obj = bf.Deserialize(ms);

			return (T)obj;
		}
	}
}
