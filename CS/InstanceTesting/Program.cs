using System;

namespace InstanceTesting
{
	internal class Program
	{
		private static readonly TestClass TEST_CLASS = TestClass.GetInstance();

		private static void Main(string[] args)
		{
			int value = TEST_CLASS.GetValue();
			Console.WriteLine($"Class value: {value}.");
		}
	}
}
