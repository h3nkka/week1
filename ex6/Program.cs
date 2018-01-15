using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a car-driven distance in kilometres to calculate the gasoline consumption and cost.");
            int km = Int32.Parse(Console.ReadLine());
            float consumption = km / 100F * 7.02F;
            float cost = consumption * 1.595F; //cost per liter = 1.595€
            Console.WriteLine("The gasoline consumption is {0} liters, and its total cost is {1} euros.", consumption, cost);
            Console.ReadKey(true);
        }
    }
}
