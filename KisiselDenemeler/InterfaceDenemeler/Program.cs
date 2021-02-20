using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDenemeler
{
    class Program
    {
        static void Main(string[] args)
        {


            //IMemeliler[] memelilers = new IMemeliler[2]
            //{
            //    new Inek(),
            //    new Tavuk()

            //};


            //foreach (var memeli in memelilers)
            //{
            //    memeli.Tur();
            //    memeli.AyakSayisi();
            //    memeli.Seslenis();
            //}

            MemeliManager memeliManager = new MemeliManager();

            memeliManager.AyakSayisi(new Inek());
            memeliManager.AyakSayisi(new Tavuk());
            



            Console.ReadKey();


        }
    }
}
