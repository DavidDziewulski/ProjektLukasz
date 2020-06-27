using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaLodówka
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region ZestawTestowy1
            
            //[<=>]Lodowka:
            Lodowka beko = new Lodowka("Beko");
            //[<=>]Produkty:
                //Owoce
            Owoc mango = new Owoc("Mango", 1, "Jun 22, 2020", "A,B,C");
            Owoc kiwi = new Owoc("Kiwi", 4, "Jun 26, 2020", "K,D,F");
                //Warzywa
            Warzywo marchew = new Warzywo("Marchew", 3, "Jun 24, 2020", "A,B,G");
            Warzywo pora = new Warzywo("Pora", 2, "Jun 23, 2020", "P");
                //Mięso
            Mieso skrzydelka = new Mieso("Skrzydełka", 5, "Jun 29, 2020", "Drób");
            Mieso lopatka = new Mieso("Łopatka", 9, "Jun 25, 2020", "Dziczyzna");
                //Napoje
            Gazowany oranżada = new Gazowany("Helena", 8, "Jun 28, 2020", 50, "truskawka", 0);
            Gazowany cola = new Gazowany("Coca-Cola", 7, "Jun 30, 2020", 60, "cola", 0);
            Niegazowany wodka = new Niegazowany("Absolwent", 6, "August 30, 2020", 20, "cola", 45);

            //[<=>]Dodajemy Produkty do Lodówki:
            beko.DodajProdukt(mango);
            beko.DodajProdukt(kiwi);
            beko.DodajProdukt(marchew);
            beko.DodajProdukt(pora);
            beko.DodajProdukt(skrzydelka);
            beko.DodajProdukt(lopatka);
            beko.DodajProdukt(oranżada);
            beko.DodajProdukt(cola);
            beko.DodajProdukt(wodka);

            //[<=>]Wypisujemy Informacje o Produktach: 
            Console.WriteLine("\n  ---Wypisywanie Informacji O Produkcie---");
            mango.WypiszInfo();
            wodka.WypiszInfo();

            Console.WriteLine("\n  ---Produkty zawarte w Lodówce---");
            //[<=>]Wypisujemy Informacje o Produktach zawartych w lodówce: 
            beko.WypiszWszystkieProdukty();

            Console.WriteLine("\n  ---Produkty Danego typu ( Owoce) ---");
            //[<=>]Wypisujemy Informacje o Produktach zawartych w lodówce: 
            beko.WypiszWszystkieProduktyDanegoTypu("Owoce");

            Console.WriteLine("\n  ---Produkty Danego typu ( Gazowane) ---");
            //[<=>]Wypisujemy Informacje o Produktach zawartych w lodówce: 
            beko.WypiszWszystkieProduktyDanegoTypu("Gazowane");

            Console.WriteLine("\n  ---Wypisuje Wszystkie Witaminy W lodówce(Metoda która zostaje wykonana tylko na implementacjach interfejsu ---");
            //[<=>]Wypisuje Wszystkie Witaminy W lodówce: 
            beko.WypiszWitaminy();

            Console.WriteLine("\n  ---Usuwamy Produkt Po-Id ---");
            //[<=>]Wypisuje Wszystkie Witaminy W lodówce: 
            beko.UsunProduktPoId(12);
            beko.UsunProduktPoId(7);
            beko.WypiszWszystkieProdukty();

            Console.WriteLine("\n  ---Sprawdzamy Czy produkt jest zdantny do Zjedzenie/Wypicia ---");
            //[<=>]Wypisuje Wszystkie Witaminy W lodówce: 
            Produkt.WyswieltDatePrzedatnosci(mango);
            Produkt.WyswieltDatePrzedatnosci(kiwi);
            Console.WriteLine("\n  ---Dziękuję za Sprawdzenie Kodu Miłego Dnia :)  ---");
            
                #endregion

            }
        }
}

