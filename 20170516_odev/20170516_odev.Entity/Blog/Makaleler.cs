using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170516_odev.Entity
{
    public class Makaleler
    {
        public int MakaleID { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string MakaleFotoPath { get; set; }
        public int KategoriID { get; set; }
        public Kategoriler Kategori { get; set; }
        public string YazarUserName { get; set; }
        public int OkunmaSayisi { get; set; }
        public int ToplamPuan { get; set; }
        public int OyVerenKisiSayisi { get; set; }
    }
}
