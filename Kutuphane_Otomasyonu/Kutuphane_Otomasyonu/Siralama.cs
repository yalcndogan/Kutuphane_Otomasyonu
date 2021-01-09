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
    public partial class Siralama : Form
    {
        public Siralama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-63I3V7U;Initial Catalog=Kutuphane_Otomasyonu;Integrated Security=True");
        DataSet dtset = new DataSet();
        private void Sıralama_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from uye order by okukitapsayisi desc", baglanti);
            adtr.Fill(dtset, "uye");
            dataGridView1.DataSource = dtset.Tables["uye"];
            baglanti.Close();
            lblCok.Text = "";
            lblAz.Text = "";
            lblCok.Text = dtset.Tables["uye"].Rows[0]["adsoyad"].ToString() +" = ";
            lblCok.Text += dtset.Tables["uye"].Rows[0]["okukitapsayisi"].ToString();
            lblAz.Text = dtset.Tables["uye"].Rows[dataGridView1.Rows.Count-2]["adsoyad"].ToString() + " = ";
            lblAz.Text += dtset.Tables["uye"].Rows[dataGridView1.Rows.Count - 2]["okukitapsayisi"].ToString();
        }
    }
}
