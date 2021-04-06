using System;
using System.Threading;
using System.Collections.Generic;

namespace Module_12
{
	class Program
    {
		static void Main(string[] args)
		{
			User user = new User();
			user.library.Add("n", ("Neo", true));
			user.library.Add("m", ("Morpheus", false));
			user.library.Add("t", ("Trinity", false));
			user.library.Add("s", ("Smith", true));
			user.library.Add("o", ("Oracle", false));
			user.CheckPremium();
		}
	}
		
	class User
	{
		public Dictionary<string, (string name, bool IsPremium)> library = new Dictionary<string, (string name, bool IsPremium)>();

		public void CheckPremium()
		{
			Console.WriteLine("Введите ваш логин");

			var login = Console.ReadLine();

			if (library.ContainsKey(login))
				Console.WriteLine("Здравствуйте {0}", library[login].name);

			else
			{
				Console.WriteLine("Неверный логин! Попробуйте снова.");
				return;
			}

			if (library[login].IsPremium)
			{
				Console.WriteLine("Ваш статус - премиум");
			}
			else
			{
				ShowAds();
			}
		}

		static void ShowAds()
		{
			Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
			// Остановка на 1 с
			Thread.Sleep(1000);

			Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
			// Остановка на 2 с
			Thread.Sleep(2000);

			Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
			// Остановка на 3 с
			Thread.Sleep(3000);
		}
	}
}
