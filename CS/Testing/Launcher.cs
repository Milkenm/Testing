#region Usings
using System;
using System.Windows.Forms;
using Testing.LineGraph;
using Testing.RiotAPI;
using Testing.TokenDB;
#endregion Usings



namespace Testing
{
	public partial class Launcher : Form
	{
		public Launcher()
		{
			InitializeComponent();
		}




		#region Line Graph
		private void button_lineGraph_concept_Click(object sender, EventArgs e)
		{
			new LineGraphConcept().Show();
		}

		private void button_lineGraph_testing_Click(object sender, EventArgs e)
		{
			new LineGraphTesting().Show();
		}
		#endregion Line Graph

		#region Riot API
		private void button_riotApi_testing_Click(object sender, EventArgs e)
		{
			new RiotAPITesting().Show();
		}
		#endregion Riot API

		#region Token DB
		private void button_tokenDb_concept_Click(object sender, EventArgs e)
		{
			new TokenDBTesting().Show();
		}
		#endregion Token DB
	}
}
