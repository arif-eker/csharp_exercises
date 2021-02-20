using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDenemeler
{
    class Inek:IMemeliler
    {
        public void Tur()
        {
            Console.WriteLine("Ben ineğim!");
        }

        public void Seslenis()
        {
            Console.WriteLine("Mööööö!");
        }

        public void AyakSayisi()
        {
            Console.WriteLine("4 Ayağım var!");
        }
    }
}
