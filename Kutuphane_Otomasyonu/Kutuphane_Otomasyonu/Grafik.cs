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
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-63I3V7U;Initial Catalog=Kutuphane_Otomasyonu;Integrated Security=True");
        private void Grafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select adsoyad,okukitapsayisi from uye",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                chart1.Series["Okunan Kitap Sayısı"].Points.AddXY(read["adsoyad"].ToString(),read["okukitapsayisi"]);
            }
            baglanti.Close();
            chart1.Series["Okunan Kitap Sayısı"].Color = Color.Blue;
        }

    }
}
