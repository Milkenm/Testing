using Microsoft.Extensions.DependencyInjection;

using System;

namespace ServiceProviderTesting2
{
	class Program
	{
		static void Main(string[] args)
		{
			ServiceCollection sc = new ServiceCollection();
			sc.AddSingleton(new service("lmao"));
			ServiceProvider sp = sc.BuildServiceProvider();


			var a = new a(sp.GetRequiredService<service>());
			a.print();

			Console.WriteLine(sp.GetService<service>().kek());
		}

		class a
		{
			private service _service;

			public a(service sv)
			{
				_service = sv;
			}

			public void print()
			{
				Console.WriteLine(_service.kek());
			}
		}

		interface iservice
		{
			public string kek();
		}

		class service : iservice
		{
			string msg;

			public service(string msg)
			{
				this.msg = msg;
			}

			public string kek()
			{
				return this.msg;
			}
		}
	}
}
