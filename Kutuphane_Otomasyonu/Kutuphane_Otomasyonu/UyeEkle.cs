using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kutuphane_Otomasyonu
{
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-63I3V7U;Initial Catalog=Kutuphane_Otomasyonu;Integrated Security=True");
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into uye(tc,adsoyad,yas,cinsiyet,telefon,adres,eposta,okukitapsayisi) values(@tc,@adsoyad,@yas,@cinsiyet,@telefon,@adres,@eposta,@okukitapsayisi)", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@yas", txtYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comboCins.Text);
            komut.Parameters.AddWithValue("@telefon", txtTel.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@eposta", txtPosta.Text);
            komut.Parameters.AddWithValue("@okukitapsayisi", txtOkuKitapSay.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt İşlemi Tamamlandı.");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item!=txtOkuKitapSay)
                    {
                        item.Text = "";
                    }
                }
            }
        }
    }
}
