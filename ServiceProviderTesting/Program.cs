using Microsoft.Extensions.DependencyInjection;

using System;

namespace ServiceProviderTesting
{
	internal static class Program
	{
		public static void Main()
		{
			ServiceProvider p = ConfigureServices();
			_ = p.GetRequiredService<BotService>();
		}

		/* Configure our Services for Dependency Injection. */
		private static ServiceProvider ConfigureServices()
		{
			return new ServiceCollection()
				.AddSingleton<DiscordSocketClient>()
				.AddSingleton<BotService>()
				.BuildServiceProvider();
		}

		private class DiscordSocketClient
		{
			public string a = "b";
		}

		private class BotService
		{
			public BotService(DiscordSocketClient client)
			{
				Console.WriteLine(client.a);
			}
		}

		private class Kek
		{
			public string a = "d";
		}
	}
}
