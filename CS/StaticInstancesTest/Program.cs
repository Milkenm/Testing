using System;

namespace StaticInstancesTest
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Instance i = Instance.GetInstance();
			i.SetValue(3);

			new AnotherOne();
		}
	}
}
