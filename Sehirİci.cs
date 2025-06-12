using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBiletRezervasyonu
{
    public partial class Sehirİci : Form
    {

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

        string[] mahalle = new string[]
        {
            "Çarşı", "Üniversite", "Hastane", "Sanayi"
        };





        public Sehirİci()
        {
            InitializeComponent();
            this.Load += comboBox1_SelectedIndexChanged;
            this.Load += comboBox2_SelectedIndexChanged;
            this.Load += comboBox3_SelectedIndexChanged;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(sehirler);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sehir = comboBox1.Text;
            string nereden = comboBox2.Text;
            string nereye = comboBox3.Text;
            string tarih = dateTimePicker1.Text;

            if (nereden == nereye)
            {
                MessageBox.Show("Nereden ve Nereye aynı olamaz!", "Uyarı");
                return;
            }

            string bilgi = $"Şehir: {sehir}\r\n" +
                           $"Nereden: {nereden}\r\n" +
                           $"Nereye: {nereye}\r\n" +
                           $"Tarih: {tarih}\r\n" +
                           $"--------------------------\r\n";

            richTextBox1.AppendText(bilgi);
            MessageBox.Show("Bilet başarıyla satın alındı!", "Başarılı");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.AddRange(mahalle);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.AddRange(mahalle);
        }

        private void Sehirİci_Load(object sender, EventArgs e)
        {

        }
    }
}
