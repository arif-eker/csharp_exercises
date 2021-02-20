using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Koyun koyun = new Koyun();
            koyun.Seslen();

            //List<Memeliler> memeli = new List<Koyun>();   hata verir.
            List<Memeliler> memeli = new List<Memeliler>();

            memeli.Add(new Memeliler());
            memeli.Add(koyun);

            foreach (var memeliler in memeli)
            {
                memeliler.Seslen();
            }

            Console.ReadKey();
        }
    }
}
