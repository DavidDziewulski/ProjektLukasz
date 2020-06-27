using System;
using System.Collections.Generic;
using System.Text;

namespace MojaLodówka
{
    class Warzywo:Produkt,IWitaminy
    {
		 protected string witaminy;

		public string Witaminy
		{
			get { return witaminy; }
			set { witaminy = value; }
		}

		public static bool jadalne = true;

		public Warzywo(string nazwa,int id,string dataPrzedatnosci,string witaminy) : base(nazwa, id, dataPrzedatnosci)
		{
			this.witaminy = witaminy;
		}
		public void WypiszWitaminy()
		{
			Console.WriteLine($"Witaminy : {witaminy}");
		}
		public override void WypiszInfo()
		{
			base.WypiszInfo();

		}
	}
}
