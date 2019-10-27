#region Usings
using System;
using System.Windows.Forms;
using Testing.LineGraph;
#endregion Usings



namespace Testing
{
	public partial class Launcher : Form
	{
		public Launcher() => InitializeComponent();

		private void button_lineGraph_concept_Click(object sender, EventArgs e) => new LineGraphConcept().Show();
		private void button_lineGraph_testing_Click(object sender, EventArgs e) => new LineGraphTesting().Show();
	}
}
