using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            

            int number1 = 10;

            float number2 = 10.3f;

            double number3 = 10.4;

            char character = 'A';

            byte number4 = 24;

            decimal number5 = 1.010m;

            bool one = true;

            short number6 = 125;

            long number7 = 3232;


            Console.WriteLine(number1+" "+number2+" "+number3+" "+number4+" "+number5+" "+number6+" "+number7+" "+character+" "+one);

            Console.WriteLine(" İnt size :"+sizeof(int) +" \n Float size : "+ sizeof(float) +" \n Double size : "+
                sizeof(double) + " \n Char size : " + sizeof(char) + " \n Bool size : " + sizeof(bool) + " \n Short size :" + sizeof(short) + "\n Decimal Size : " + sizeof(decimal));

            Console.ReadKey();


        }
        
    }
}
