using System;
using OtobusBiletRezervasyonu;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBiletRezervasyonu
{
    public class Sefer
    {
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public DateTime Tarih { get; set; }

        public Sefer(string nereden, string nereye, DateTime tarih)
        {
            Nereden = nereden;
            Nereye = nereye;
            Tarih = tarih;
        }

        public virtual string Bilgi()
        {
            return $"Sefer: {Nereden} → {Nereye} ({Tarih.ToShortDateString()})";
        }
    }


    public class SehirlerArasi : Sefer
    {
       
        public SehirlerArasi(string nereden, string nereye, DateTime tarih, double mesafe)
            : base(nereden, nereye, tarih)
        {
            
        }

        public override string Bilgi()
        {
            return base.Bilgi() ;
        }
    }

    public class SehirIci : Sefer
    {

        public int mahalle { get; set; }

        public SehirIci(string nereden, string nereye, DateTime tarih, int Mahalle)
            : base(nereden, nereye, tarih)
        {
            mahalle = Mahalle;
        }

        public override string Bilgi()
        {
            return $"Hat No: {mahalle} | {Nereden} → {Nereye} | Tarih: {Tarih.ToShortDateString()}";
        }
    }


}
