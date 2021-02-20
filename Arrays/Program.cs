using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //choice 1
            string[] students = new string[3];

            students[0] = "Arif";
            students[1] = "Fatma";
            students[2] = "Rabia";


            //choice 2
            string [] students2 = new [] { "Ahmet", "Ayşe", "Betül" };


            //choice 3
            string[] students3 = { "Ahmet", "Ayşe", "Betül" };


            //choice 4
            string[] students4 = new string[3] { "Ahmet", "Ayşe", "Betül" };

            //multi array
            // 4 satır 3 sütun demektir.
            string[,] regions = new string[4, 3];
            regions[1, 1] = "Karadeniz";
            Console.WriteLine(regions[1,1]);

            string [,] regions2 = new string[7,3]
            {

                {"Karadeniz","Rize","Giresun"},
                {"Doğu Anadolu","Van","Iğdır"},
                {"İç Anadolu","Ankara","Kayseri"},
                {"Güneydoğu Anadolu","Mardin","Şırnak"},
                {"Marmara","Bursa","İstanbul"},
                {"Akdeniz","Antalya","Mersin"},
                {"Ege","İzmir","Muğla"},

            };

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j==0)
                    {
                        Console.WriteLine("Bölgemiz : " + regions2[i,j]);
                    }
                    else
                        Console.WriteLine("İlimiz :"+ regions2[i,j]);
                    
                }

                Console.WriteLine();
            }


            /*
             *Başka bir örnek olarak, satır ve sütun sayısını bilmiyorsak kullanacağımız bir fonksiyon var : GetUpperBound()
             *Bu fonksiyon örnek olarak 2 boyutlu dizi için [7,3] maks satır ve sütun sayısını verir. Şöyleki:
             * GetUpperBound(0) der isek bize dönecek sonuç 6 olacaktır.
             * GetUpperBound(1) dersek bize sonu. 2 olarak dönecektir. 3 boyutlu dize olsa idi eğer örnek olarak [4,3,6] şeklinde
             * GetUpperBond(0) = 3  =======>[4, , ]
             * GetUpperBond(1)=2    =======>[ ,3, ]
             * GetUpperBond(2)=5    =======>[ , ,6]          değerini döndürecekti 
             */

            //for (int i = 0; i <= regions2.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= regions2.GetUpperBound(1); j++)
            //    {
            //        Console.WriteLine(regions2[i, j]);
            //    }
            //}


            Console.ReadKey();

        }
    }
}
