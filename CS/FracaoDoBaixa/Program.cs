using System;
using System.Web;

namespace FracaoDoBaixa
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			int numerador1 = 10, numerador2 = 5;
			int denominador1 = 10, denominador2 = 5;
			int sad = denominador1;

			numerador1 *= denominador2; // 8
			denominador1 *= denominador2; // 16

			numerador2 *= sad; // 4
			denominador2 *= sad; // 16

			int numeradorResultado = numerador1 - numerador2;

			Console.WriteLine($"{numerador1}/{denominador1} -- {numerador2}/{denominador2}");
			Console.WriteLine($"Resultado: {numeradorResultado}/{denominador1}");

			int res1 = numeradorResultado / numeradorResultado;
			int res2 = denominador1 / numerador1;

			string neg = "";
			if (numeradorResultado < 0)
			{
				neg = "-";
			}

			Console.WriteLine($"Resultado final: {neg}{res1}/{res2}");
		}
	}
}
