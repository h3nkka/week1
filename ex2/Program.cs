using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input points as integer:");
            int input = Int32.Parse(Console.ReadLine());
            switch (input)
            {
                case 0:
                case 1:
                    Console.WriteLine("School grade is 0");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("School grade is 1");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("School grade is 2");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("School grade is 3");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("School grade is 4");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("School grade is 5");
                    break;
                //break;
            }
            Console.ReadKey(true);
        }
    }
}
