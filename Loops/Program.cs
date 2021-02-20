using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();

            //WhileLoop();

            //DoWhileLoop();

            //ForeachLoop();

            Console.ReadKey();
        }

        private static void ForeachLoop()
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        private static void DoWhileLoop()
        {
            int i = 110;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 100);
        }

        private static void WhileLoop()
        {
            int a = 0;
            while (a < 100)
            {
                Console.WriteLine(a);
                a++;
            }
        }

        private static void ForLoop()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }


        
    }
}
