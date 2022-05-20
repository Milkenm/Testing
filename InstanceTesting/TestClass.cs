namespace InstanceTesting
{
	internal class TestClass
	{
		private static TestClass Instance;

		public static TestClass GetInstance()
		{
			return Instance ?? new TestClass();
		}

		public TestClass()
		{
			Instance = this;

			value = 5;
		}

		private int value;

		public int GetValue()
		{
			return value;
		}
	}
}
