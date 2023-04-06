using System;
using System.DirectoryServices.AccountManagement;
using System.Management;
using System.Security.Principal;
using System.Threading;

using Microsoft.Win32;

namespace WMIEventsTest
{
	internal class Program
	{
		/// <summary>
		/// </summary>
		/// <param name="sender">
		/// The sender.
		/// </param>
		/// <param name="e">
		/// The e.
		/// </param>
		private static void HandleEvent(object sender, EventArrivedEventArgs e)
		{
			Console.WriteLine("Received an event.");
			// RegistryKeyChangeEvent occurs here; do something.

			RegistryKey myKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Search", true);
			if (myKey != null)
			{
				myKey.SetValue("SearchboxTaskbarMode", "1", RegistryValueKind.DWord);
				myKey.Close();
			}
		}

		/// <summary>
		/// </summary>
		public static void Main()
		{
			// Just calls the class above to check for events...
			WmiChangeEventTester receiveEvent = new WmiChangeEventTester();
		}

		/// <summary>
		/// </summary>
		public class WmiChangeEventTester
		{
			/// <summary>
			/// Initializes a new instance of the <see cref="WmiChangeEventTester"/> class.
			/// </summary>
			public WmiChangeEventTester()
			{
				try
				{
					var user = WindowsIdentity.GetCurrent().User;
					string sid = UserPrincipal.Current.Sid.ToString();

					// Your query goes below; "KeyPath" is the key in the registry that you
					// want to monitor for changes. Make sure you escape the \ character.
					WqlEventQuery query = new WqlEventQuery($@"SELECT * FROM RegistryValueChangeEvent WHERE Hive='HKEY_USERS' AND KeyPath='{sid}\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Search' AND ValueName='SearchboxTaskbarMode'");

					ManagementEventWatcher watcher = new ManagementEventWatcher(query);
					Console.WriteLine("Waiting for an event...");

					// Set up the delegate that will handle the change event.
					watcher.EventArrived += new EventArrivedEventHandler(HandleEvent);

					// Start listening for events.
					watcher.Start();

					// Do something while waiting for events. In your application,
					// this would just be continuing business as usual.
					Thread.Sleep(Timeout.Infinite);

					// Stop listening for events.
					watcher.Stop();
				}
				catch (ManagementException managementException)
				{
					Console.WriteLine("An error occurred: " + managementException.Message);
				}
			}
		}
	}
}
