using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu
{
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-63I3V7U;Initial Catalog=Kutuphane_Otomasyonu;Integrated Security=True");

        private void KitapEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kitap(barkod,kitapadi,yazar,yayinevi,sayfa,tur,rafno,stoksayisi,kayittarihi) values(@barkod,@kitapadi,@yazar,@yayinevi,@sayfa,@tur,@rafno,@stoksayisi,@kayittarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkod", txtBarkod.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
            komut.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
            komut.Parameters.AddWithValue("@sayfa", txtSayfa.Text);
            komut.Parameters.AddWithValue("@tur", comboTur.Text);
            komut.Parameters.AddWithValue("@rafno", txtRafNo.Text);
            komut.Parameters.AddWithValue("@stoksayisi", txtStok.Text);
            komut.Parameters.AddWithValue("@kayittarihi", DateTime.Now.ToShortDateString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt İşlemi Tamamlandı.");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
