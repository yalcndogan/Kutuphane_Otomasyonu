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
    public partial class EmanetVer : Form
    {
        public EmanetVer()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-63I3V7U;Initial Catalog=Kutuphane_Otomasyonu;Integrated Security=True");
        DataSet dtset = new DataSet();
        private void EmanetVer_Load(object sender, EventArgs e)
        {
            SepetListele();
        }
        private void KitapSayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(kitapsayisi) from Sepet", baglanti);
            lblKitapSay.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }
        private void SepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Sepet", baglanti);
            adtr.Fill(dtset, "Sepet");
            dataGridView1.DataSource = dtset.Tables["Sepet"];
            baglanti.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Sepet (barkod,kitapadi,yazar,yayinevi,sayfa,kitapsayisi,teslimtarihi,iadetarihi) values (@barkod,@kitapadi,@yazar,@yayinevi,@sayfa,@kitapsayisi,@teslimtarihi,@iadetarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkod", txtBarkod.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
            komut.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
            komut.Parameters.AddWithValue("@sayfa", txtSayfa.Text);
            komut.Parameters.AddWithValue("@kitapsayisi", int.Parse(txtKitapSayisi.Text));
            komut.Parameters.AddWithValue("@teslimtarihi", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@iadetarihi", dateTimePicker2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitaplar Sepete Eklendi.");
            dtset.Tables["Sepet"].Clear();
            SepetListele();
            lblKitapSay.Text = "";
            KitapSayisi();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtKitapSayisi)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Uye where tc like'" + txtTc.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTel.Text = read["telefon"].ToString();
                txtAdres.Text = read["adres"].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(kitapsayisi) from EmanetKitaplar where tc='" + txtTc.Text + "'", baglanti);
            lblKayitliKitapSay.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();
            if (txtTc.Text == "")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }

                }
                lblKayitliKitapSay.Text = "";
            }
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Kitap where barkod like'" + txtBarkod.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKitapAdi.Text = read["kitapadi"].ToString();
                txtYazar.Text = read["yazar"].ToString();
                txtYayinevi.Text = read["yayinevi"].ToString();
                txtSayfa.Text = read["sayfa"].ToString();
            }
            baglanti.Close();
            if (txtBarkod.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtKitapSayisi)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu işlem Geri alınamaz. Kayıt Silinsin Mi ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Sepet where barkod ='" + dataGridView1.CurrentRow.Cells["barkod"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Tamamlandı!");
                dtset.Tables["Sepet"].Clear();
                SepetListele();
                lblKitapSay.Text = "";
                KitapSayisi();
            }
        }

        private void btnTeslim_Click(object sender, EventArgs e)
        {
            if (lblKitapSay.Text != "")
            {
                if (lblKayitliKitapSay.Text == "" && int.Parse(lblKitapSay.Text) <= 3 || lblKayitliKitapSay.Text != "" && int.Parse(lblKayitliKitapSay.Text) + int.Parse(lblKitapSay.Text) <= 3)
                {
                    if (txtTc.Text != "" && txtAdSoyad.Text != "" && txtTel.Text != "" && txtAdres.Text != "")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("insert into EmanetKitaplar(tc,adsoyad,telefon,adres,barkod,kitapadi,yazar,yayinevi,sayfa,kitapsayisi,teslimtarihi,iadetarihi) values(@tc,@adsoyad,@telefon,@adres,@barkod,@kitapadi,@yazar,@yayinevi,@sayfa,@kitapsayisi,@teslimtarihi,@iadetarihi)", baglanti);
                            komut.Parameters.AddWithValue("@tc", txtTc.Text);
                            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                            komut.Parameters.AddWithValue("@telefon", txtTel.Text);
                            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                            komut.Parameters.AddWithValue("barkod", dataGridView1.Rows[i].Cells["barkod"].Value.ToString());
                            komut.Parameters.AddWithValue("kitapadi", dataGridView1.Rows[i].Cells["kitapadi"].Value.ToString());
                            komut.Parameters.AddWithValue("yazar", dataGridView1.Rows[i].Cells["yazar"].Value.ToString());
                            komut.Parameters.AddWithValue("yayinevi", dataGridView1.Rows[i].Cells["yayinevi"].Value.ToString());
                            komut.Parameters.AddWithValue("sayfa", dataGridView1.Rows[i].Cells["sayfa"].Value.ToString());
                            komut.Parameters.AddWithValue("kitapsayisi", int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()));
                            komut.Parameters.AddWithValue("teslimtarihi", dataGridView1.Rows[i].Cells["teslimtarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("iadetarihi", dataGridView1.Rows[i].Cells["iadetarihi"].Value.ToString());
                            komut.ExecuteNonQuery();
                            SqlCommand komut2 = new SqlCommand("update uye set okukitapsayisi=okukitapsayisi+'"+int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString())+"' where tc='"+txtTc.Text+"' ",baglanti);
                            komut2.ExecuteNonQuery();
                            SqlCommand komut3 = new SqlCommand("update kitap set stoksayisi=stoksayisi-'" + int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()) + "' where barkod='" + dataGridView1.Rows[i].Cells["barkod"].Value.ToString() + "' ", baglanti);
                            komut3.ExecuteNonQuery();
                            baglanti.Close();
                        }
                        baglanti.Open();
                        SqlCommand komut4 = new SqlCommand("delete from Sepet", baglanti);
                        komut4.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kitaplar Emanet Edildi!");
                        dtset.Tables["Sepet"].Clear();
                        SepetListele();
                        txtTc.Text = "";
                        lblKitapSay.Text = "";
                        KitapSayisi();
                        lblKayitliKitapSay.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Üye Bilgileri Eksik!");
                    }
                }
                else
                {
                    MessageBox.Show("Maximum 3 Kitap Emanet Edilebilir!");
                }
            }
            else
            {
                MessageBox.Show("Sepet Boş!");
            }
        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            dtset.Tables["sepet"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet where barkod like '%" + txtBarkodAra.Text + "%'", baglanti);
            adtr.Fill(dtset, "sepet");
            dataGridView1.DataSource = dtset.Tables["sepet"];
            baglanti.Close();
        }
    }
}



       