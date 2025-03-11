using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etteremrendelesOOP
{
	public class Rendeles
	{
		public Felhasznalo Megrendelo { get; set; }
		public List<Etel> Termekek { get; set; }
		public string Allapot { get; set; }

		public Rendeles(Felhasznalo megrendelo, List<Etel> termekek)
		{
			Megrendelo = megrendelo;
			Termekek = termekek;
			Allapot = "Feldolgozás alatt";
		}

		public void AllapotFrissit(string ujAllapot)
		{
			Allapot = ujAllapot;
		}
	}
}
