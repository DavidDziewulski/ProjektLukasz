using System;
using System.Collections.Generic;
using System.Text;

namespace MojaLodówka
{
	class Niegazowany : Napoj
	{
		private double zawartoscAlkocholu;

		public double ZawartoscAlkocholu
		{
			get { return zawartoscAlkocholu; }
			set { zawartoscAlkocholu = value; }
		}



		public Niegazowany(string nazwa, int id, string dataPrzedatnosci, double objetosc, string smak, double zawartoscAlkocholu) : base(nazwa, id, dataPrzedatnosci, objetosc, smak)
		{
			this.zawartoscAlkocholu = zawartoscAlkocholu;
		}

		public override void ObjetoscNapoju()
		{

			Console.WriteLine($"Objętość Napoju wynosi {objetosc }");

		}
		public override void WypiszInfo()
		{
			base.WypiszInfo();
			Console.WriteLine($"zawartosc alkocholu {zawartoscAlkocholu}% smak {smak}");

		}
	}

}
