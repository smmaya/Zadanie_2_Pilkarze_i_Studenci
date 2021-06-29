using System;
namespace Zadanie_2
{
    class Piłkarz : Osoba
    {
        protected string pozycja;
        protected string klub;
        protected int liczbaGoli = 0;

        public Piłkarz()
        {
        }

        public Piłkarz(Osoba osoba)
        {
            imie = osoba.Imie;
            nazwisko = osoba.Nazwisko;
            dataUrodzenia = osoba.DataUrodzenia;
        }

        public Piłkarz(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
            this.pozycja = pozycja;
            this.klub = klub;
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Pozycja: " + pozycja + " Klub: " + klub + " Ilość goli: " + liczbaGoli);
        }
        public virtual void StrzelGola()
        {
            liczbaGoli += 1;
        }
    }
}

