using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etteremrendelesOOP
{
	public class Etterem
	{
		public List<Etel> Etelek { get; set; }
		public List<Rendeles> Rendelesek { get; set; }

		public Etterem()
		{
			Etelek = new List<Etel>();
			Rendelesek = new List<Rendeles>();
		}

		public void BeolvasEtelek(string fajlNev)
		{
			if (!File.Exists(fajlNev))
			{
				Console.WriteLine("A fájl nem található!");
				return;
			}

			var sorok = File.ReadAllLines(fajlNev);
			foreach (var sor in sorok)
			{
				var adatok = sor.Split(',');
				if (adatok.Length == 3)
				{
					string nev = adatok[0];
					string kategoria = adatok[1];
					int ar = int.Parse(adatok[2]);
					Etelek.Add(new Etel(nev, kategoria, ar));
				}
			}
		}

		public void UjRendeles(Rendeles ujRendeles)
		{
			Rendelesek.Add(ujRendeles);
		}
	}

}

