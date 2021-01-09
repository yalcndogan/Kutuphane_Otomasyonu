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
    public partial class EmanetList : Form
    {
        public EmanetList()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-63I3V7U;Initial Catalog=Kutuphane_Otomasyonu;Integrated Security=True");
        DataSet dtset = new DataSet();

        private void EmanetList_Load(object sender, EventArgs e)
        {
            EmanetListele();
            comboBox1.SelectedIndex = 0;
        }

        private void EmanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar", baglanti);
            adtr.Fill(dtset, "EmanetKitaplar");
            dataGridView1.DataSource = dtset.Tables["EmanetKitaplar"];
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtset.Tables["EmanetKitaplar"].Clear();
            if (comboBox1.SelectedIndex==0)
            {
                EmanetListele();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where '"+DateTime.Now.ToShortDateString()+"'> iadetarihi", baglanti);
                adtr.Fill(dtset, "EmanetKitaplar");
                dataGridView1.DataSource = dtset.Tables["EmanetKitaplar"];
                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where '" + DateTime.Now.ToShortDateString() + "'<= iadetarihi", baglanti);
                adtr.Fill(dtset, "EmanetKitaplar");
                dataGridView1.DataSource = dtset.Tables["EmanetKitaplar"];
                baglanti.Close();
            }
        }
    }
}
