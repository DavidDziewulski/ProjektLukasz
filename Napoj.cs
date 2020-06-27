using System;
using System.Collections.Generic;
using System.Text;

namespace MojaLodówka
{
    abstract class Napoj: Produkt
    {
		protected double objetosc;

		public double Objetosc
		{
			get { return objetosc; }
			set { objetosc = value; }
		}

		protected string  smak;

		public string Smak
		{
			get { return smak; }
			set { smak = value; }
		}

		public Napoj(string nazwa,int id,string dataPrzedatnosci,double objetosc,string smak) : base(nazwa, id, dataPrzedatnosci)
		{
			this.objetosc = objetosc;
			this.smak = smak;
		}

		public abstract void ObjetoscNapoju();
	}
}
