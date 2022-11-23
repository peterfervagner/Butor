using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chair chair = new Chair();
            Bed bed = new Bed();
            Table table = new Table();
            Furniture[] furnitures = { chair, bed, table };

            foreach (Furniture furniture in furnitures)
            {
                furniture.Print();
                Console.WriteLine();
            }
        }
    }
}
