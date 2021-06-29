using System;
namespace Zadanie_2
{
    class Ręczny : Piłkarz
    {
        public Ręczny() : base()
        {
        }
        public override void StrzelGola()
        {
            liczbaGoli += 1;
        }
    }
}
