using System;
using System.Windows.Forms;

namespace Fatorial
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void button_calcular_Click(object sender, EventArgs e)
		{
			int resultado = 1;
			for (int i = 1; i <= Convert.ToUInt32(textBox_numero.Text); i++)
			{
				resultado *= i;
				listBox_calculo.Items.Add(resultado);
			}
			/*for (int i = Convert.ToInt32(textBox_numero.Text); i > 0; i--)
			{
				resultado *= i;
				listBox_calculo.Items.Add(resultado);
			}*/
			label_resultado.Text = "Resultado: " + resultado.ToString();
		}
	}
}
