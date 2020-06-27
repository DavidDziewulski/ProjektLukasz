using System;
using System.Collections.Generic;
using System.Text;

namespace MojaLodówka
{
    class Gazowany: Napoj
    {
		public static double nabuzowany = 2.5;
		private double zawartoscAlkocholu;

		public double ZawartoscAlkocholu
		{
			get { return zawartoscAlkocholu; }
			set { zawartoscAlkocholu = value; }
		}



		public Gazowany(string nazwa, int id, string dataPrzedatnosci, double objetosc,string smak, double zawartoscAlkocholu) : base(nazwa, id, dataPrzedatnosci, objetosc, smak)
		{
			this.zawartoscAlkocholu = zawartoscAlkocholu;
		}

		public override void ObjetoscNapoju()
		{

			Console.WriteLine($"Objętość Napoju wynosi {nabuzowany * objetosc }");
			
		}
		public override void WypiszInfo()
		{
			base.WypiszInfo();
			Console.WriteLine($"Zawartosc alkocholu: {zawartoscAlkocholu}%, smak: {smak}");

		}
	}


}
