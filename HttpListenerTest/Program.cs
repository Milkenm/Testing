using System;
using System.Text;

namespace HttpListenerTest
{
	internal class Program
	{
		private static void Main()
		{
			StartServer();
			Console.ReadKey();
		}

		public static void StartServer()
		{
			HttpServer server = new HttpServer(ProcessResponse);
			server.Start();
		}

		public static byte[] ProcessResponse(string test)
		{
			Console.WriteLine(test);
			return Encoding.UTF8.GetBytes("# RESPONSE #");
		}
	}
}
