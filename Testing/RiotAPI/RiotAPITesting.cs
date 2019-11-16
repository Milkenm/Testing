using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Testing.RiotAPI.Resources;

namespace Testing.RiotAPI
{
	public partial class RiotAPITesting : Form
	{
		Settings set = new Settings();
		string sumInfo = "https://euw1.api.riotgames.com/lol/summoner/v4/summoners/by-name/{0}?api_key={1}";
		string masteryInfo = "https://euw1.api.riotgames.com/lol/champion-mastery/v4/champion-masteries/by-summoner/{0}?api_key={1}";





		public RiotAPITesting() => InitializeComponent();

		private void RiotAPI_Load(object sender, EventArgs e)
		{
			textBox_summoner.Text = set.SummonerName;
			textBox_apiKey.Text = set.ApiKey;
		}

		private void RiotAPITesting_FormClosing(object sender, FormClosingEventArgs e) => set.Save();













		public class Summoner
		{
			public string id { get; set; }
			public string accountId { get; set; }
			public string puuid { get; set; }
			public string name { get; set; }
			public string profileIconId { get; set; }
			public string revisionDate { get; set; }
			public string summonerLevel { get; set; }
		}
		
		public class Mastery
		{
			public string championLevel { get; set; }
			public string chestGranted { get; set; }
			public string championPoints { get; set; }
			public string championPointsSinceLastLevel { get; set; }
			public string championPointsUntilNextLevel { get; set; }
			public string summonerId { get; set; }
			public string tokensEarned { get; set; }
			public string championId { get; set; }
			public string lastPlayTime { get; set; }
		}



		private void button_saveApiKey_Click(object sender, EventArgs e) => set.ApiKey = textBox_apiKey.Text;

		private void button_get_Click(object sender, EventArgs e)
		{
				set.SummonerName = textBox_summoner.Text;

				string json = GET(FormatString());

				if (!string.IsNullOrEmpty(json))
				{
					Summoner sum = JsonConvert.DeserializeObject<Summoner>(GET(FormatString()));

					textBox_id.Text = sum.id;
					textBox_accountId.Text = sum.accountId;
					textBox_puuid.Text = sum.puuid;
					textBox_name.Text = sum.name;
					textBox_profileIconid.Text = sum.profileIconId;
					textBox_revisionDate.Text = sum.revisionDate;
					textBox_summonerLevel.Text = sum.summonerLevel;

					try
					{
						pictureBox_icon.Load(string.Format("https://milkenm.github.io/Diamond/Static/LoL/Icons/{0}.png", textBox_profileIconid.Text));
					}
					catch
					{
						MessageBox.Show("Icon not found.");
					}


					string json2 = GET(string.Format(masteryInfo, textBox_id.Text, textBox_apiKey.Text));
					List<Mastery> mastery = JsonConvert.DeserializeObject<List<Mastery>>(json2);
					MessageBox.Show(mastery[0].championId, "Most Points");
				}
				else MessageBox.Show("Esse Summoner não foi encontrado.");
		}

		string FormatString()
		{
			return string.Format(sumInfo, textBox_summoner.Text.Replace(" ", "%20"), textBox_apiKey.Text);
		}

		/// <summary>Executes a GET Resquest.</summary>
		/// <param name="url">The request URL.</param>
		public string GET(string url)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

			WebResponse response = request.GetResponse();
			using (Stream stream = response.GetResponseStream())
			{
				StreamReader reader = new StreamReader(stream, Encoding.UTF8);
				return reader.ReadToEnd();
			}
		}
	}
}