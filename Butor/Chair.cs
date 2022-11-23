using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butor
{
    internal class Chair : Furniture
    {
        const int basePrice = 25000;
        const int id = 0;
        double ar;
        int labszam = 4;
        public double Ar
        {
            get { return ar; }
            set { ar = basePrice * 1.2; }
        }
        public override void Print()
        {
            Ar = ar;
            Console.WriteLine("A szék ára: " + ar);
            Console.WriteLine("A szék azonositója: " + id);
            Console.WriteLine("A szék lábainak száma: " + labszam);
        }
    }
}
