using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyKolekcji
{
    class Program
    {
        static void nazwa()
        {

        }
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary[1] = "cos";


            Console.WriteLine(myDictionary[1]);
            int[] kolekcjaLiczb = new[] { 1, 4, 6, 5, 3, 2, 8, 9, 0 };
            var queery = kolekcjaLiczb.Select(x => x).ToList();
            foreach (var item in kolekcjaLiczb)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            var querry2 = kolekcjaLiczb.Select(cos => cos).ToArray().TakeWhile(cos => cos <= 6);
            foreach (var item in querry2)
            {
                Console.Write(item + " ");
            }
            var querry3 = kolekcjaLiczb.Select(n => n).ToList().OrderBy(n => n);
            Console.WriteLine();
            foreach (var item in querry3)
            {
                Console.Write(item + " ");
            }
            string[] czasNaString = new[] { "ala", "mama", "Nad nami jasne niebo", ",a ja się jednak boje", "cos" };
            var querry4 = czasNaString.Select(n => n).ToList().Where(a => a.Length == 3);
            foreach (var item in querry4)
            {
                Console.Write(item + " ");
            }
            List<Samochod> NaszePojazdy = new List<Samochod>()
            {
            new Samochod("Audi A6 Quatro", Rodzaj.osobowy, 360.000, "Czarny"),
            new Samochod("Mercedes Benz", Rodzaj.osobowy, 390.000, "Bialy"),
            new Samochod("Volvo Truck", Rodzaj.ciezarowy, 160.000, "Niebieski"),
            new Samochod("Iveco Horse", Rodzaj.ciezarowy, 120.000, "Czarny"),
            new Samochod("Ford Mondeo", Rodzaj.osobowy, 70.000, "Czarny"),
            };
            var querry5 = NaszePojazdy.Select(n => n).ToList().Where(n => n.cena < 150.000);
            foreach (var i in querry5)
            {
                Console.WriteLine("Marka: {0} | Rodzaj: {1} | Cena: {2} tys. zł| Kolor: {3} |", i.model, i.rodzajAuta, i.cena, i.kolor);
            }
            var querry6 = NaszePojazdy.Select(x => x).Where(x=>x.model=="Ford Mondeo").Select(x=>x.cena);
            Console.WriteLine("\n\n");
            foreach(var i in querry6)
            {
                Console.WriteLine("\n\n{0}",i);
            }


            var querry7 = NaszePojazdy.Select(x => x.model).ToList();
            foreach(var i in querry7)
            {
                Console.WriteLine(i);
            }
        }
    }
}
