using System;
using System.Collections.Generic;
namespace Zadanie_2
{
    class Student : Osoba
    {
        protected int rok = 0;
        protected int grupa = 0;
        protected int nrIndeksu = 0;
        private List<Ocena> oceny = new List<Ocena>(); //pole Oceny typu lista

        public Student()
        {
        }

        public Student(Osoba osoba)
        {
            imie = osoba.Imie;
            nazwisko = osoba.Nazwisko;
            dataUrodzenia = osoba.DataUrodzenia;
        }

        public Student(string imie, string nazwisko, string dataUrodzenia, int rok, int grupa, int nrIndeksu)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
            this.rok = rok;
            this.grupa = grupa;
            this.nrIndeksu = nrIndeksu;
        }
        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Rok: " + rok + " Grupa: " + grupa + " Numer indeksu: " + nrIndeksu);
        }
        public void DodajOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            Ocena ocena = new Ocena(nazwaPrzedmiotu, data, wartosc);
            oceny.Add(ocena);
        }
        public void WypiszOceny()
        {
            foreach (var ocena in oceny)
            {
                ocena.WypiszInfo();
            }
        }
        public void UsunOceny()
        {
            oceny.Clear();
        }
        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            for (int i = 0; i < oceny.Count;)
            {
                Ocena o = oceny[i];
                if (o.NazwaPrzedmiotu == nazwaPrzedmiotu && o.Data == data && o.Wartosc == wartosc)
                {
                    oceny.RemoveAt(i);
                }
                else
                {
                    ++i;
                }
            }
        }
    }
}
