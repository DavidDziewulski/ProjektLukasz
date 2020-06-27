using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MojaLodówka
{
    class Lodowka
    {
		private string marka;

		public string Marka
		{
			get { return Marka; }
			set { Marka = value; }
		}

		public List<Produkt> produkty = new List<Produkt>();

		public Lodowka(string marka)
		{
			this.marka = marka;
		}

		public void DodajProdukt(Produkt item)
		{
			produkty.Add(item);
		}
		
		public void WypiszWszystkieProdukty()
		{
			foreach (var item in produkty)
			{
				item.WypiszInfo();
			}
		}
		public void WypiszWszystkieProduktyDanegoTypu(string typ)
		{


			foreach (var item in produkty)
			{

				switch (typ)
				{
					case "Owoce":
						if (item is Owoc)
						{
							item.WypiszInfo();
						}
						break;
					case "Warzywa":
						if (item is Warzywo)
						{
							item.WypiszInfo();
						}
						break;
					case "Mięso":
						if (item is Mieso)
						{
							item.WypiszInfo();
						}
						break;
					case "Gazowane":
						if (item is Gazowany)
						{
							item.WypiszInfo();
						}
						break;
					case "Niegazowane":
						if (item is Niegazowany)
						{
							item.WypiszInfo();
						}
						break;
					

					default:
						Console.WriteLine("Nie ma takiego Typu");
						break;

				}

				
			}
		}
		
		public void WypiszWitaminy()
		{
			
			foreach (var item in produkty)
			{
				Owoc owoce = item as Owoc;
				Warzywo warzywa = item as Warzywo;

				if (owoce != null)
				{
					 owoce.WypiszWitaminy();

				}
				else if(warzywa != null)
				{
					warzywa.WypiszWitaminy();
				}

			}
			
		}


		public void UsunProduktPoId(int id)
		{

			var wynik = produkty.RemoveAll(item =>  item.Id == id);
			if (wynik > 0)
			{
				Console.WriteLine("Produkt został usuniety");
			}
			else
			{
				Console.WriteLine($"Nie ma produktu o Podanym id :{id} ");
			}


		}
	}


}
