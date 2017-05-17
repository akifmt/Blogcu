using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170516_odev.Entity
{
    class Yorumlar
    {
        public string AdiSoyadi { get; set; }

        public string Yorumicerik { get; set; }
        public string Email { get; set; }
        public string WebSitesi { get; set; }
        public bool OnayDurumu { get; set; }
        public DateTime YorumTarihi { get; set; }
    }
}
