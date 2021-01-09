using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeEkle uyeek = new UyeEkle();
            uyeek.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeList uyels = new UyeList();
            uyels.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KitapEkle kitapek = new KitapEkle();
            kitapek.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KitapList kitapls = new KitapList();
            kitapls.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmanetVer emanetvr = new EmanetVer();
            emanetvr.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EmanetList emanetls = new EmanetList();
            emanetls.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IadeIslem iadeis = new IadeIslem();
            iadeis.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Siralama sirala = new Siralama();
            sirala.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Grafik grfk = new Grafik();
            grfk.ShowDialog();
        }
    }
}
