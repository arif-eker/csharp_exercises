using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {

            Product harddisk = new Product(50);

            harddisk.ProductName = "Hard Disk";
            Product telefon = new Product(50);
            telefon.ProductName = "Telefon";

            //event'e kaydoluyoruz.
            telefon.StockKontrolEvent += Telefon_StockKontrolEvent;

            for (int i = 0; i < 10; i++)
            {
                harddisk.Sell(10);
                telefon.Sell(10);
                Console.ReadKey();
            }


            Console.ReadKey();
        }

        private static void Telefon_StockKontrolEvent()
        {
            Console.WriteLine("Telefon 15'ten az kaldı, bitiyor!!!");
        }
    }
}
