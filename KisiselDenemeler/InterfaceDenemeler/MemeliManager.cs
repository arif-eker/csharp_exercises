using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDenemeler
{
    class MemeliManager
    {
        public void Tur(IMemeliler memeli)
        {
            memeli.Tur();
        }

        public void Seslenis(IMemeliler memeli)
        {
            memeli.Seslenis();
        }

        public void AyakSayisi(IMemeliler memeli)
        {
            memeli.AyakSayisi();
        }
    }
}
