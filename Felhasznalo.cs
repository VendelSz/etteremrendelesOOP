using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etteremrendelesOOP
{
	public class Felhasznalo
	{
		public string Nev { get; set; }
		public List<Etel> Kosar { get; set; }

		public Felhasznalo(string nev)
		{
			Nev = nev;
			Kosar = new List<Etel>();
		}

		public void KosarbaTesz(Etel etel)
		{
			Kosar.Add(etel);
		}

		public void KosarMegtekint()
		{
			foreach (var etel in Kosar)
			{
				Console.WriteLine($"{etel.Nev} - {etel.Kategoria} - {etel.Ar} Ft");
			}
		}

		public Rendeles Rendel()
		{
			if (Kosar.Count == 0)
			{
				Console.WriteLine("A kosár üres!");
				return null;
			}

			Rendeles rendeles = new Rendeles(this, new List<Etel>(Kosar));
			Kosar.Clear();
			return rendeles;
		}
	}
}
