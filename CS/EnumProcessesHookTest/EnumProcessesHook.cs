using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using EasyHook;

namespace EnumProcessesHookTest
{
	public class EnumProcessesHook : IDisposable
	{
		[DllImport( "psapi.dll", SetLastError = true )]
		static extern bool EnumProcesses( uint[] processIds, uint arraySizeBytes, out uint bytesCopied );

		// LocalHook instance
		LocalHook _hook;

		[UnmanagedFunctionPointer( CallingConvention.StdCall, SetLastError = true )]
		delegate bool EnumProcessesDelegate( uint[] processIds, uint arraySizeBytes, out uint bytesCopied );

		public void Install()
		{
			_hook = LocalHook.Create(
				LocalHook.GetProcAddress( "psapi.dll", "EnumProcesses" ),
				new EnumProcessesDelegate( EnumProcessesDetour ),
				this );

			_hook.ThreadACL.SetExclusiveACL( new int[] { 0 } );
		}

		bool EnumProcessesDetour( uint[] processIds, uint arraySizeBytes, out uint bytesCopied )
		{
			Console.WriteLine( "function called." );

			// Call original function
			bool result = EnumProcesses( processIds, arraySizeBytes, out bytesCopied );
			/*
			if ( result && processIds != null )
			{
				uint processCount = bytesCopied / 4; // Each PID is 4 bytes

				// Filter out processes you want to hide
				for ( int i = 0; i < processCount; i++ )
				{
					if ( ShouldHideProcess( processIds[i] ) )
					{
						// Remove by shifting array
						for ( int j = i; j < processCount - 1; j++ )
						{
							processIds[j] = processIds[j + 1];
						}
						processCount--;
						bytesCopied -= 4;
						i--;
					}
				}
			}*/

			return result;
		}

		bool ShouldHideProcess( uint processId )
		{
			// Your logic to determine which processes to hide
			return false; // Example PID to hide
		}

		public void Dispose()
		{
			_hook?.Dispose();
		}
	}
}
