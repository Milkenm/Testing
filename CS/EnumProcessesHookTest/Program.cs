using System;

namespace EnumProcessesHookTest
{
	public class Program
	{
		private static EnumProcessesHook _hook;

		public static void Main( string[] args )
		{
			while ( true )
			{
				var input = Console.ReadLine();

				if ( input == "install" && _hook == null )
				{
					_hook = new EnumProcessesHook();
					_hook.Install();
					Console.WriteLine( "Hook enabled." );
				}
				else if ( input == "dispose" && _hook != null )
				{
					_hook.Dispose();
					Console.WriteLine( "Hook disabled." );
				}
				else if ( input == "quit" )
				{
					_hook?.Dispose();

					break;
				}
			}
		}
	}
}
