using System;
using System.Collections.Generic;
using System.Text;

namespace MojaLodówka
{
	class Mieso : Produkt
	{
		private string kategoria;

		public string Kategoria
		{
			get { return kategoria; }
			set { kategoria = value; }
		}

		static bool jadalne = true;

		public Mieso(string nazwa, int id, string dataPrzedatnosci, string kategoria) : base(nazwa, id, dataPrzedatnosci)
		{
			this.kategoria = kategoria;
		}
		
		public override void WypiszInfo()
		{
			base.WypiszInfo();
			Console.WriteLine($",Kategoria Mięsa: {kategoria}");

		}
	}
}
