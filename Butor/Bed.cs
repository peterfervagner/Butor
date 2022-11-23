using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butor
{
    internal class Bed : Furniture
    {
        const int basePrice = 25000;
        const int id = 1;
        int hossz = 200;
        int szelesseg = 160;
        double ar;
        public double Ar
        {
            get { return ar; }
            set { ar = basePrice * 2.4; }
        }
        public override void Print()
        {
            Ar = ar;
            Console.WriteLine("Az ágy ára: " + ar);
            Console.WriteLine("Az ágy azonositója: " + id);
            Console.WriteLine("Az ágy hossza: " + hossz);
            Console.WriteLine("Az ágy szélessége: " + szelesseg);
        }
    }
}
