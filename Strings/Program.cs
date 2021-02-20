using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string city = "Bursa";

            //Stringler karakter katarlarıdır. Yani char dizileridir.
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*****************");
            for (int i = 0; i < city.Length; i++)
            {
                
                Console.WriteLine(city[i]);
                
            }

            string kelime = "Merhaba, benim adım Arif";

            //stringin uzunluğunu verir
            var result1 = kelime.Length;

            //stringin aranan harfle bitip bitmediğini kontrol eder. bool döndürür
            var result2 = kelime.EndsWith("f");

            //stringin aranan harfle bitip bitmediğini kontrol eder. bool döndürür
            var result3 = kelime.EndsWith("a");

            //kelimenin aranan harfle başlayıp başlamadığını kontrol eder.
            var result4 = kelime.StartsWith("M");

            //kelimenin aranan harfle başlayıp başlamadığını kontrol eder.
            var result5 = kelime.StartsWith("m");

            //Stringi küçük harflere çevirir
            var result6 = kelime.ToLower();

            //Stringi büyük harflere çevirir
            var result7 = kelime.ToUpper();

            //string içinde, 0. indeksten başlayarak aranan karakterin ilk nerede görüldüğünü döndürür.
            var result8 = kelime.IndexOf("A");

            //string içinde, son indeksten başlayarak aranan karakterin ilk   indise göre nerede görüldüğünü döndürür.
            var result9 = kelime.LastIndexOf("A");

            //stringe söylenen indeksten itibaren kelime veya harf ekler
            var result10 = kelime.Insert(0, "İlk cümle : ");

            //stringe söylenen indeksten itibaren kelime veya harf ekler
            var result11 = kelime.Insert(11, "11. İndeks: ");

            //stringi 7. indeksten itibaren alır. (7,4) olsa idi 7. indeksten itibaren (7. indeks dahil) 4 karakter alır
            var result12 = kelime.Substring(7);

            var result13 = kelime.Substring(1);


            Console.WriteLine("Kelime : "+kelime);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            Console.WriteLine(result13);

            Console.ReadKey();

        }
    }
}
