using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170516_odev.Entity
{
    public class Makaleler
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public int OkunmaSayisi { get; set; }

        public int ToplamPuan { get; set; }

        public int OyVerenKisiSayisi { get; set; }
    }
}
