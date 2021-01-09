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
    public partial class IadeIslem : Form
    {
        public IadeIslem()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-63I3V7U;Initial Catalog=Kutuphane_Otomasyonu;Integrated Security=True");
        DataSet dtset = new DataSet();

        private void EmanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar", baglanti);
            adtr.Fill(dtset, "EmanetKitaplar");
            dataGridView1.DataSource = dtset.Tables["EmanetKitaplar"];
            baglanti.Close();
        }
        private void IadeIslem_Load(object sender, EventArgs e)
        {
            EmanetListele();
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBarkodSorgula_TextChanged(object sender, EventArgs e)
        {
            dtset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where barkod like '%"+txtBarkodSorgula.Text+"%'", baglanti);
            adtr.Fill(dtset, "EmanetKitaplar");
            baglanti.Close();
            if (txtBarkodSorgula.Text=="")
            {
                dtset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }
        }

        private void btnTesAl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from EmanetKitaplar where barkod=@barkod",baglanti);
            komut.Parameters.AddWithValue("@barkod",dataGridView1.CurrentRow.Cells["barkod"].Value.ToString());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("update kitap set stoksayisi=stoksayisi+'"+dataGridView1.CurrentRow.Cells["kitapsayisi"].Value.ToString()+"'where barkod=@barkod", baglanti);
            komut2.Parameters.AddWithValue("@barkod", dataGridView1.CurrentRow.Cells["barkod"].Value.ToString());
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İade İşlemi Tamamlandı.");
            dtset.Tables["EmanetKitaplar"].Clear();
            EmanetListele();

        }
    }
}
