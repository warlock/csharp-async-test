using System;
using System.Threading.Tasks;

namespace CshAsyncTest
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("async testing!");
			AsynMeths a = new AsynMeths();
			a.Bu();
			System.Threading.Thread.Sleep(20000);
		}
	}

	class AsynMeths
	{
		public static Task<string> Make()
		{
			return Task.Run(() =>
			{
				Console.WriteLine("llençat " + DateTime.Now.ToString());
				System.Threading.Thread.Sleep(5000);
				return "hola " + DateTime.Now.ToString();
			});
		}

		public static void Make2()
		{
			Task.Run(() =>
			{
				Console.WriteLine("llençat " + DateTime.Now.ToString());
				System.Threading.Thread.Sleep(5000);
				Console.WriteLine("hola " + DateTime.Now.ToString());
			});
		}

		public async virtual void Boh()
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("llençant" + i);
				string text = await Make();
				Console.WriteLine(text);
			}
			Console.WriteLine("he acabat d'iterar");
		}


		public virtual void Bu()
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("llençant" + i);
				Make2();
			}
			Console.WriteLine("he acabat d'iterar");
		}
	}
}
