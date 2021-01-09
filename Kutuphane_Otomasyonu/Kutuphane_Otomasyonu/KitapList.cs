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
    public partial class KitapList : Form
    {
        public KitapList()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-63I3V7U;Initial Catalog=Kutuphane_Otomasyonu;Integrated Security=True");
        DataSet dtset = new DataSet();
        private void KitapList_Load(object sender, EventArgs e)
        {
            KitapListele();
        }
        private void KitapListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from kitap", baglanti);
            adtr.Fill(dtset, "kitap");
            dataGridView1.DataSource = dtset.Tables["kitap"];
            baglanti.Close();
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kitap where barkod like '" + txtBarkod.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKitapAdi.Text = read["kitapadi"].ToString();
                txtYazar.Text = read["yazar"].ToString();
                txtYayinevi.Text = read["yayinevi"].ToString();
                txtSayfa.Text = read["sayfa"].ToString();
                comboTur.Text = read["tur"].ToString();
                txtRafNo.Text = read["rafno"].ToString();
                txtStok.Text = read["stoksayisi"].ToString();
            }
            baglanti.Close();
        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            dtset.Tables["kitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from kitap where barkod like '%" + txtBarkodAra.Text + "%'", baglanti);
            adtr.Fill(dtset, "kitap");
            dataGridView1.DataSource = dtset.Tables["kitap"];
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu işlem geri alınamaz kayıt silinsin mi ?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from kitap where barkod=@barkod", baglanti);
                komut.Parameters.AddWithValue("@barkod", dataGridView1.CurrentRow.Cells["barkod"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Tamamlandı.");
                dtset.Tables["kitap"].Clear();
                KitapListele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kitap set kitapadi=@kitapadi,yazar=@yazar,yayinevi=@yayinevi,sayfa=@sayfa,tur=@tur,rafno=@rafno,stoksayisi=@stoksayisi where barkod=@barkod", baglanti);
            komut.Parameters.AddWithValue("@barkod", txtBarkod.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
            komut.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
            komut.Parameters.AddWithValue("@sayfa", txtSayfa.Text);
            komut.Parameters.AddWithValue("@tur", comboTur.Text);
            komut.Parameters.AddWithValue("@rafno", txtRafNo.Text);
            komut.Parameters.AddWithValue("@stoksayisi", txtStok.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veriler Güncellendi.");
            dtset.Tables["kitap"].Clear();
            KitapListele();
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

