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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
        private void temizle()
        {
            foreach (Control nesne in this.Controls)
            {
                if (nesne is TextBox)
                {
                    TextBox textbox = (TextBox)nesne;
                    textbox.Clear();
                }
            }
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-63I3V7U;Initial Catalog=Kutuphane_Otomasyonu;Integrated Security=True");
        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sorgula = new SqlCommand("select * from kullanici where usr= '" + txtUsr.Text + "' and pass='" + txtPass.Text + "'", baglanti);
            SqlDataReader dr = sorgula.ExecuteReader();
            if (dr.Read())
            {
                Anasayfa frm = new Anasayfa();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "Kullanıcı Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            baglanti.Close();
        }
    }
}

