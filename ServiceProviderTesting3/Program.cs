using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;

namespace ServiceProviderTesting3
{
	class Program
	{
		static void Main(string[] args)
		{
			ServiceCollection sc = new ServiceCollection();
			sc.AddSingleton<Dictionary<string, string>>();

			ServiceProvider sp = sc.BuildServiceProvider();
			Dictionary<string,string> dc = sp.GetService<Dictionary<string, string>>();
			dc.Add("1", "sdfsd2");

			Dictionary<string, string> dc2 = sp.GetService<Dictionary<string, string>>();
			Console.WriteLine(dc2["1"]);
		}
	}
}
