using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyKolekcji
{
    public enum Rodzaj { osobowy, ciezarowy };
    class Samochod
    {
        
        public double cena { get; set; }
        public string model { get; set; }
        public Rodzaj rodzajAuta { get; set; }
        public string kolor;
        public Samochod(string marka, Rodzaj rodzaj, double cena, string kolor)
        {
            this.kolor = kolor;
            this.model = marka;
            this.rodzajAuta= rodzaj;
            this.cena = cena;
        }
    }
}
