using RestSharp;

using System;
using System.Threading;

namespace XMRigRPCTesting
{
	public class Program
	{
		private static void Main()
		{
			while (true)
			{
				Console.WriteLine("Pausing miner...");
				PauseMiner();
				Thread.Sleep(3000);

				Console.WriteLine("Resuming miner...");
				ResumeMiner();
				Thread.Sleep(3000);
			}
		}

		private static void PauseMiner()
		{
			MakeRequest("pause");
		}

		private static void ResumeMiner()
		{
			MakeRequest("resume");
		}

		private static void MakeRequest(string param)
		{
			var client = new RestClient();

			var request = new RestRequest("http://localhost:38486/json_rpc");
			request.AddHeader("Authorization", "Bearer kek");
			request.AddHeader("Content-Type", "application/json");
			request.AddJsonBody("{\"method\":\"" + param + "\",\"id\":1}");

			client.Post(request);
		}
	}
}
