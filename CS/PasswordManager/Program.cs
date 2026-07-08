using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PasswordManager
{
	internal class Program
	{
		private static Passwords _passwords = new Passwords();
		private static string _charSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		private static string _pathFicheiro = "Passwords.txt";
		private static readonly Random _random = new Random();

		public static void Main(string[] args)
		{
			Console.Title = "Password Manager";

			_passwords.Deserialize(LerFicheiro());
			MainMenu();
			EscreverFicheiro(_passwords.Serialize());
		}

		public static int PrintMenu(string title, params string[] options)
		{
			Console.Clear();
			Console.WriteLine($"== {title} ==");

			for (var i = 0; i < options.Length; i++)
			{
				Console.WriteLine($"{i + 1}. {options[i]}");
			}

			if (options.Length == 0)
			{
				return 0;
			}

			Console.WriteLine("");
			Console.WriteLine("Escolha » ");
			var escolha = Console.ReadLine();
			var opcao = Convert.ToInt32(escolha);

			if (opcao < 1 || opcao > options.Length)
			{
				Console.WriteLine("A opção não é valida.");
				Console.ReadLine();
				return PrintMenu(title, options);
			}

			return opcao;
		}

		public static void MainMenu()
		{
			var option = PrintMenu("Gestor de Passwords", "Ver Passwords", "Adicionar Password", "Apagar Password", "Sair");

			switch (option)
			{
				case 1:
					VerPasswords();
					break;
				case 2:
					AdicionarPassword();
					break;
				case 3:
					ApagarPassword();
					break;
				case 4:
					return;
			}

			MainMenu();
		}

		public static void VerPasswords()
		{
			PrintMenu("Ver Passwords");

			var passwords = _passwords.GetPasswords();

			if (!HaPasswordsGuardadas(passwords.Count))
			{
				return;
			}

			for (var i = 0; i < passwords.Count; i++)
			{
				var username = passwords.Keys.ElementAt(i);
				Console.WriteLine($"#{i + 1}. {_passwords.GetPassword(username)}");
			}

			Console.WriteLine();
			Console.WriteLine("Clica [Enter] para voltar.");
			Console.ReadLine();
		}

		public static void AdicionarPassword(string username = "", string password = "")
		{
			PrintMenu("Adicionar Password");

			Console.WriteLine("Utilizador » ");
			if (!string.IsNullOrEmpty(username))
			{
				Console.WriteLine(username);
			}
			else
			{
				username = Console.ReadLine();
				if (!ValidarInput(username) || !_passwords.ValidateUsername(username))
				{
					Console.WriteLine("Username inválido.");
					Console.ReadLine();

					AdicionarPassword();
					return;
				}
			}

			Console.WriteLine("Password (vazia para gerar aleatória) » ");
			if (!string.IsNullOrEmpty(password))
			{
				Console.WriteLine(password);
			}
			else
			{
				password = Console.ReadLine();
				if (!string.IsNullOrEmpty(password))
				{
					if (!ValidarInput(password))
					{
						Console.WriteLine("Password inválida.");
						Console.ReadLine();

						AdicionarPassword(username);
						return;
					}
				}
				else
				{
					password = GerarPassword(_charSet, 12);
					AdicionarPassword(username, password);
					return;
				}
			}

			_passwords.AddPassword(username, password);

			EscreverFicheiro(_passwords.Serialize());
			Console.WriteLine("Password adicionada!");
			Console.ReadLine();
		}

		public static void ApagarPassword()
		{
			var passwords = _passwords.ToList();

			var option = PrintMenu("Apagar Password", passwords.ToArray());

			if (!HaPasswordsGuardadas(passwords.Count))
			{
				return;
			}

			var username = _passwords.GetPasswords().Keys.ElementAt(option - 1);
			_passwords.DeletePassword(username);

			EscreverFicheiro(_passwords.Serialize());
			Console.WriteLine("Password apagada!");
			Console.ReadLine();
		}

		public static bool HaPasswordsGuardadas(int passwordCount)
		{
			if (passwordCount == 0)
			{
				Console.WriteLine("Não há passwords guardadas.");
				Console.ReadLine();
				return false;
			}

			return true;
		}

		public static bool ValidarInput(string input)
		{
			return !(input.Contains(",") || input.Contains(";"));
		}

		public static string GerarPassword(string charSet, int length)
		{
			var sb = new StringBuilder();
			for (var i = 0; i < length; i++)
			{
				var rnd = _random.Next(charSet.Length);
				sb.Append(charSet[rnd]);
			}

			return sb.ToString();
		}

		public static string LerFicheiro()
		{
			if (!File.Exists(_pathFicheiro))
			{
				return "";
			}

			return File.ReadAllText(_pathFicheiro);
		}

		public static void EscreverFicheiro(string passwords)
		{
			File.WriteAllText(_pathFicheiro, passwords);
		}

		public class Passwords
		{
			private Dictionary<string, string> _passwordsList = new Dictionary<string, string>();

			public Dictionary<string, string> GetPasswords()
			{
				return new Dictionary<string, string>(_passwordsList);
			}

			public void AddPassword(string username, string password)
			{
				_passwordsList.Add(username, password);
			}

			public string GetPassword(string username)
			{
				var password = _passwordsList[username];
				return $"{username} - {password}";
			}

			public void DeletePassword(string username)
			{
				_passwordsList.Remove(username);
			}

			public bool ValidateUsername(string username)
			{
				return !_passwordsList.ContainsKey(username);
			}

			public void Deserialize(string data)
			{
				if (string.IsNullOrEmpty(data))
				{
					return;
				}

				foreach (var keyset in data.Split(';'))
				{
					if (string.IsNullOrEmpty(keyset))
					{
						continue;
					}

					var split = keyset.Split(',');
					_passwordsList.Add(split[0], split[1]);
				}
			}

			public string Serialize()
			{
				var sb = new StringBuilder();
				foreach (var keySet in _passwordsList)
				{
					sb.Append(keySet.Key).Append(",").Append(keySet.Value).Append(";");
				}

				return sb.ToString();
			}

			public List<String> ToList()
			{
				var passwordsList = new List<string>();

				foreach (var keySet in _passwordsList)
				{
					passwordsList.Add(keySet.ToString());
				}

				return passwordsList;
			}
		}
	}
}
