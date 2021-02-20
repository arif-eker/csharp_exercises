using System;

namespace BasitDenemeler1
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = 10;
            float b = (float)a / 3;
            //float b= a/3f;

            Console.WriteLine(b);

            int c = 2;
            int d = 4;

            Console.WriteLine("c++ : " + c++);
            Console.WriteLine("++d : " + ++d);

            Console.WriteLine("*************************\n");

            bool a1 = 50 > 60;
            bool b1 = 50 < 60;
            bool c1 = 20.4f>30.2f;
            bool d1 = 20.4f <30.2f;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}",a1,b1,c1,d1);


            Console.WriteLine("\n");


            //object aa = "50";
            //string s = aa as string;

            //Console.WriteLine(s);

            int [] dizi = new int[2];
            dizi[0] = 1;
            dizi[1] = 2;
            dizi[1]++;

            Console.Clear();

            for (int i = 0; i < 20; i++)
            {
                Console.Write("#");
                if (i == 0 || i == 20 - 1)
                {
                    for (int j = 1; j < 80 - 1; j++)
                    {
                        Console.Write("#");
                        if (j == 80 - 2) Console.WriteLine();
                    }
                }
                else
                {
                    for (int j = 0; j < 80 - 3; j++)
                        Console.Write(" ");
                    Console.Write("#\n");
                }
            }

            Console.ReadKey();
        }
    }
}
