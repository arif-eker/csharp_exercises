using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {


            int number1 = 101;
            int number2 = 20;
            if (number1 < number2)
            {
                Console.WriteLine("Number 1 lower then Number 2");

            }
            else if (number1 == number2)
            {
                Console.WriteLine("Number 1 equal Number 2");

            }
            else
                Console.WriteLine("Number 1 bigger then Number 2");

            Console.ReadKey();
        }
    }
}
