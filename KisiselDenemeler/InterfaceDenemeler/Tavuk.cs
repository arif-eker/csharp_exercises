using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDenemeler
{
    class Tavuk:IMemeliler
    {
        public void Tur()
        {
            Console.WriteLine("Ben tavuğum !");
        }

        public void Seslenis()
        {
            Console.WriteLine("Gıt gıt gıdaaak");
        }

        public void AyakSayisi()
        {
            Console.WriteLine("2 ayağım var!");
        }

        public void Otla()
        {
            Console.WriteLine("Otlamam!");
        }
    }
}
