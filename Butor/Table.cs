using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butor
{
    internal class Table : Furniture
    {
        const int basePrice = 25000;
        const int id = 2;
        int magassag = 75;
        double ar;
        public double Ar
        {
            get { return ar; }
            set { ar = basePrice * 0.3; }
        }
        public override void Print()
        {
            Ar = ar;
            Console.WriteLine("Az asztal ára: " + ar);
            Console.WriteLine("Az asztal azonositója: " + id);
            Console.WriteLine("Az asztal magassága: " + magassag);
        }
    }
}
