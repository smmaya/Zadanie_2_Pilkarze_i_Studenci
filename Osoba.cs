using System;
namespace Zadanie_2
{
    public class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string dataUrodzenia;

        public string Imie { get => imie; }
        public string Nazwisko { get => nazwisko; }
        public string DataUrodzenia { get => dataUrodzenia; }

        public Osoba()
        {
        }

        public Osoba(string imie, string nazwisko, string dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
        }

        public virtual void WypiszInfo()
        {
            Console.Write(imie + " ");
            Console.WriteLine(nazwisko);
            Console.WriteLine(dataUrodzenia);
        }
    }
}
