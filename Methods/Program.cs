using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = 4;
            Console.WriteLine("Methods!");
            methodOne();
            methodTwo(a);
            methodThree(5,6);
            Console.ReadKey();
            


        }


        static void methodOne()
        {
            Console.WriteLine("This is methodOne");
        }

        static int methodTwo(int c)
        {
            int a = 5;
            Console.WriteLine(a);
            return a;

        }

        static int methodThree(int a, int b) {

            Console.WriteLine("This is methodThree");
            return a * b;
        }


        static int methodFour(int a=20, int b = 30)
        {
            return a * b;

        }

        

        


    }
}
