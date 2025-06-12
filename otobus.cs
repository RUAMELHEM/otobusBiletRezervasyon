using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBiletRezervasyonu
{
    class otobus
    {
       
        public Koltuk[] Koltuklar { get; set; }

        public otobus(Koltuk[] koltuklar)
        {
            
            Koltuklar = koltuklar;
        }
    }
}
