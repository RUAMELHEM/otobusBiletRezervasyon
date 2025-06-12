using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBiletRezervasyonu
{
    
        public class Koltuk : IRezervasyon
        {
            public string KoltukNo { get; set; }
            public bool RezerveMi { get; private set; }
            public Button Buton { get; set; }

        public event EventHandler Secildi;
        public Koltuk(string koltukNo, bool rezerve ,int x, int y)
            {
            KoltukNo = koltukNo;
            RezerveMi = rezerve;

            Buton = new Button();
            Buton.Text = koltukNo;
            Buton.Width = 50;
            Buton.Height = 50;
            Buton.Left = x;
            Buton.Top = y;

            if (rezerve)
            {
                Buton.BackColor = Color.Red;
                Buton.Enabled = false;
            }
            else
            {
                Buton.BackColor = Color.LightGray;
                Buton.Click += (s, e) => Secildi?.Invoke(this, EventArgs.Empty);
            }
        }

            public void RezerveEt()
            {
                RezerveMi = true;
                Buton.BackColor = Color.Red;
                Buton.Enabled = false;
            }

            public void RezervasyonIptal()
            {
                RezerveMi = false;
                Buton.BackColor = Color.LightGray;
                Buton.Enabled = true;
            }

        public void Vazgec()
        {
            Buton.BackColor = Color.LightGray;
        }
        public void Sec()
        {
            Buton.BackColor = Color.Green;
        }

    }
    }
