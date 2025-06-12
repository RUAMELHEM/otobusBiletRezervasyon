using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OtobusBiletRezervasyonu.Koltuk;

namespace OtobusBiletRezervasyonu
{

    public partial class SeferOlustur : Form
    {
        private Koltuk[] koltuklar;
        private List<string> secilenKoltuklar = new List<string>();
        private HashSet<string> rezerveKoltuklar = new HashSet<string> { };

        string seciliNereden = "";
        string seciliNereye = "";
        string seciliTarih = "";
        string seciliKoltuk = "";
        string seciliYolcuAdi = "";

        private int satir = 3;
        private int sutun = 5;
        string[] sehirler = new string[]
    {
        "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın",
        "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı",
        "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir",
        "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul",
        "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya",
        "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir",
        "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat",
        "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray",
        "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova",
        "Karabük", "Kilis", "Osmaniye", "Düzce"
    };
        public SeferOlustur()
        {

            InitializeComponent();
            KoltuklariOlustur();
            this.Load += comboBox2_SelectedIndexChanged;
            this.Load += comboBox1_SelectedIndexChanged;
            
        }

        private void KoltuklariOlustur()
        {
            int toplam = satir * sutun;
            koltuklar = new Koltuk[toplam];
            int index = 0;

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    string koltukNo = $"{(char)('A' + j)}{i + 1}";
                    int x = 60 * j + 20;
                    int y = 60 * i + 20;
                    bool rezerve = rezerveKoltuklar.Contains(koltukNo);

                    Koltuk koltuk = new Koltuk(koltukNo, rezerve, x, y);
                    koltuk.Secildi += KoltukSecildi;

                    koltuklar[index] = koltuk;
                    this.Controls.Add(koltuk.Buton);
                    index++;
                }
            }
        }
        private void KoltukSecildi(object sender, EventArgs e)
        {
            Koltuk secilen = (Koltuk)sender;
            string seciliNo = secilen.KoltukNo;
            foreach (var k in koltuklar)
            {
                if (!k.RezerveMi)
                    k.Vazgec();
            }

            secilenKoltuklar.Clear();
            secilenKoltuklar.Add(seciliNo);
            secilen.Sec();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // Ana sayfaya dönüş 
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 AnaSayfa = new Form1();
            AnaSayfa.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox1.Items.AddRange(sehirler);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox2.Items.AddRange(sehirler);
        }

        private void SeferOlustur_Load(object sender, EventArgs e)
        {

        }

        
        private void button3_Click(object sender, EventArgs e)
        {
       
            string bilgi = "";
            bilgi += " OTOBÜS BİLETİ\n";
            bilgi += "--------------------------\n";
            bilgi += $"Yolcu       : {seciliYolcuAdi}\n";
            bilgi += $"Koltuk No   : {seciliKoltuk}\n";
            bilgi += $"Nereden     : {seciliNereden}\n";
            bilgi += $"Nereye      : {seciliNereye}\n";
            bilgi += $"Tarih       : {seciliTarih}\n";
            bilgi += $"Yazdırma    : {DateTime.Now}\n";

            richTextBox1.Text = bilgi; // TextBox'a yaz

        }
        

        private void button10_Click(object sender, EventArgs e)
        {

            string nereden = comboBox1.SelectedItem.ToString();
            string nereye = comboBox2.SelectedItem.ToString();
            string tarih = dateTimePicker1.Value.ToShortDateString();
            string koltukNo = secilenKoltuklar[0];
            seciliYolcuAdi = textBox1.Text.Trim();

            string KoltukNo = secilenKoltuklar[0];

            foreach (var koltuk in koltuklar)
            {
                if (koltuk.KoltukNo == koltukNo)
                {
                    koltuk.RezerveEt();
                    rezerveKoltuklar.Add(koltukNo);
                    break;
                }
            }

            secilenKoltuklar.Clear();
            MessageBox.Show($"Bilet alındı!\n\n{nereden} → {nereye}\nTarih: {tarih}\nKoltuk: {koltukNo}  ");
            seciliNereden = nereden;
            seciliNereye = nereye;
            seciliTarih = tarih;
            seciliKoltuk = koltukNo;
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
