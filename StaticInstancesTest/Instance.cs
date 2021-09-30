namespace StaticInstancesTest
{
	internal class Instance
	{
		private static Instance instance;

		public static Instance GetInstance()
		{
			return instance ?? new Instance();
		}

		public Instance()
		{
			instance = this;
		}

		private int value;

		public void SetValue(int value)
		{
			this.value = value;
		}

		public int GetValue()
		{
			return value;
		}
	}
}
