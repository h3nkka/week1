using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an amount of seconds to render in hours and minutes.");
            int seconds = Int32.Parse(Console.ReadLine());
            int minutes = seconds / 60;
            int hours = minutes / 60;
            Console.WriteLine("That's {0} hour(s), {1} minute(s) and {2} second(s).", hours, minutes % 60, seconds % 60);
            Console.ReadKey(true);
        }
    }
}
