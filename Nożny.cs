using System;
namespace Zadanie_2
{
    class Nożny : Piłkarz
    {
        public Nożny() : base()
        {
        }

        public override void StrzelGola()
        {
            liczbaGoli += 1;
        }
    }
}
