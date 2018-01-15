using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your age as an integer.");
            int age = Int32.Parse(Console.ReadLine());
            if (age < 18)
                Console.WriteLine("You're underage.");
            else if (age >= 18 && age <= 65)
                Console.WriteLine("You're an adult.");
            else
                Console.WriteLine("You're a senior.");
            Console.ReadKey(true);
        }
    }
}
