using System;

namespace StaticInstancesTest
{
	internal class AnotherOne
	{
		public AnotherOne()
		{
			Instance i = Instance.GetInstance();
			Console.WriteLine(i.GetValue());
		}
	}
}
