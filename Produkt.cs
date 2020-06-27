using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MojaLodówka
{
    class Produkt
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string nazwa;

		public string Nazwa
		{
			get { return nazwa; }
			set { nazwa = value; }
		}

		private string dataPrzedatnosci;

		public string DataParzedatnosci
		{
			get { return dataPrzedatnosci; }
			set { dataPrzedatnosci = value; }
		}

		public Produkt(string nazwa, int id,string dataPrzedatnosci)
		{
			this.nazwa = nazwa;
			this.id = id;
			this.dataPrzedatnosci = dataPrzedatnosci;
		}
		public static void WyswieltDatePrzedatnosci(Produkt item)
		{
			DateTime aktualnie = DateTime.Now.Date;
			var dataProduktu = DateTime.Parse(item.dataPrzedatnosci);
			var wynik = DateTime.Compare(dataProduktu,aktualnie);
			
			Console.WriteLine($"Aktualna Data: {aktualnie.ToString("dd/MM/yyyy")} data Przeterminowania Produktu {dataProduktu.ToString("dd/MM/yyyy")} ");

			if (wynik > 0 || wynik ==0)
				Console.WriteLine("!!Produkt zdatny do zjedzenia/wypicia");
			else
				Console.WriteLine("!!Produkt nie zdatny do zjedzenia/wypicia");
		}
		public virtual void WypiszInfo()
		{
			Console.WriteLine($"Nazwa Produktu: {nazwa}, id-Produktu: {id}, data Przedatnosci: {dataPrzedatnosci}");
		}


		
	
}
}
