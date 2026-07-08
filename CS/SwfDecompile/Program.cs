using System.Xml.Linq;

using SwfDotNet.IO;
using SwfDotNet.IO.Tags;

internal class Program
{
	static void Main( string[] args )
	{
		string swfFile = @"C:\Users\milke\Desktop\Nova pasta\x_meli_costumes.swf";
		ParseSwf( swfFile );
	}

	public static void ParseSwf( string filePath )
	{
		// Open the SWF file
		SwfReader reader = new SwfReader(filePath );
		Swf swf = reader.ReadSwf();

		// Access SWF properties
		Console.WriteLine( $"SWF Version: {swf.Header.Version}" );
		Console.WriteLine( $"Frame Rate: {swf.Header.Frames}" );

		foreach ( var tag in swf.Tags )
		{
			Console.WriteLine( "tag: " + tag.GetType());
			if ( tag is DefineSpriteTag sprite )
			{
				foreach ( var controlTag in sprite.Tags )
				{
					// Handle different types of control tags
					if ( controlTag is PlaceObjectTag placeObject )
					{
						Console.WriteLine( $"Placed Character ID: {placeObject.TargetCharacterId}" );
						// Further processing as needed
					}
					// Handle other control tag types similarly
				}
			}
			// Handle other graphical tag types similarly
		}
	}

	static void SaveImage( byte[] imageData, string outputPath )
	{
		File.WriteAllBytes( outputPath, imageData );
	}
}