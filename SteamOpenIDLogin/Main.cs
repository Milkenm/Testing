using System;
using System.Windows.Forms;

namespace SteamOpenIDLogin
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void button_goToSteam_Click(object sender, EventArgs e)
		{
			string steamUrl = @"https://steamcommunity.com/openid/login?
					openid.claimed_id = http://specs.openid.net/auth/2.0/identifier_select&
					openid.identity = http://specs.openid.net/auth/2.0/identifier_select&
					openid.mode = checkid_setup &
					openid.ns = http://specs.openid.net/auth/2.0&
					openid.realm = https://REALM_PARAM&
					openid.return_to = https://REALM_PARAM/signin/";

			string steamUrl2 = "https://steamcommunity.com/openid/login?" +
				"openid.mode=checkid_setup&" +
				"openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&" +
				"openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&" +
				"openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&" +
				"openid.return_to=https%3A%2F%2Fswapauth.com%2Fauth%2Fverify&" +
				"openid.realm=https%3A%2F%2Fswapauth.com";

			webBrowser.Navigate(steamUrl2);
		}

		private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			MessageBox.Show(e.Url.ToString());
		}
	}
}
