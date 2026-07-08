namespace WhileDoBartonso
{
	internal class Program
	{
		private static void Main( string[] args )
		{
			var character = '\0';
			var i = 0;

			for ( ; character != '#'; i++ )
			{
				Console.WriteLine( "Escreve o caracter:" );

				var line = Console.ReadLine();
				if ( string.IsNullOrEmpty( line ) )
				{
					i--;
					continue;
				}

				character = line[0];
			}

			Console.WriteLine( "Foram escritos: " + ( i - 1 ) + " caracteres antes do #." );
		}
	}
}
