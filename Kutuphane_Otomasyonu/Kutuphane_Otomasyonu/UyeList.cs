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
    public partial class UyeList : Form
    {
        public UyeList()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-63I3V7U;Initial Catalog=Kutuphane_Otomasyonu;Integrated Security=True");
        DataSet dtset = new DataSet();

        private void UyeList_Load(object sender, EventArgs e)
        {
            UyeListele();
        }

        private void UyeListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from uye",baglanti);
            adtr.Fill(dtset,"uye");
            dataGridView1.DataSource = dtset.Tables["uye"];
            baglanti.Close();
        }
        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from uye where tc like '"+txtTc.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtYas.Text = read["yas"].ToString();
                comboCins.Text = read["cinsiyet"].ToString();
                txtTel.Text = read["telefon"].ToString();
                txtAdres.Text = read["adres"].ToString();
                txtPosta.Text = read["eposta"].ToString();
                txtOkuKitapSay.Text = read["okukitapsayisi"].ToString();
            }
            baglanti.Close();
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            dtset.Tables["uye"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from uye where tc like '%"+txtTcAra.Text+"%'",baglanti);
            adtr.Fill(dtset,"uye");
            dataGridView1.DataSource = dtset.Tables["uye"];
            baglanti.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu işlem geri alınamaz kayıt silinsin mi ?","Silme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from uye where tc=@tc", baglanti);
                komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Tamamlandı.");
                dtset.Tables["uye"].Clear();
                UyeListele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update uye set adsoyad=@adsoyad,yas=@yas,cinsiyet=@cinsiyet,telefon=@telefon,adres=@adres,eposta=@eposta,okukitapsayisi=@okukitapsayisi where tc=@tc",baglanti);
            komut.Parameters.AddWithValue("@tc",txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@yas", txtYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comboCins.Text);
            komut.Parameters.AddWithValue("@telefon", txtTel.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@eposta", txtPosta.Text);
            komut.Parameters.AddWithValue("@okukitapsayisi", int.Parse(txtOkuKitapSay.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veriler Güncellendi.");
            dtset.Tables["uye"].Clear();
            UyeListele();
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
