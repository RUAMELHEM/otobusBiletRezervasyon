using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBiletRezervasyonu
{
    public interface IRezervasyon
    {
        void RezerveEt();
        void RezervasyonIptal();
        bool RezerveMi { get; }
    }
}
