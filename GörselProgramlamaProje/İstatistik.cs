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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GörselProgramlamaProje
{
    public partial class İstatistik : Form
    {
        public İstatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source = EKIN\\SQLEXPRESS; Initial Catalog = ProjeLoginScreen; Integrated Security = True");

        private void İstatistik_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("SELECT DISTINCT(marka) FROM Car;", baglantı);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                comboBox1.Items.Add(oku1["marka"].ToString());
            }
            baglantı.Close();

            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("SELECT DISTINCT(yıl) FROM Car;", baglantı);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                comboBox2.Items.Add(oku2["yıl"].ToString());
            }
            baglantı.Close();

            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("SELECT DISTINCT(sanzıman) FROM Car;", baglantı);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                comboBox3.Items.Add(oku3["sanzıman"].ToString());
            }
            baglantı.Close();

            baglantı.Open();
            SqlCommand komut4 = new SqlCommand("SELECT DISTINCT(yakıt) FROM Car;", baglantı);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                comboBox4.Items.Add(oku4["yakıt"].ToString());
            }
            baglantı.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select Sum(stokMiktar) from Car ", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                int stok = Convert.ToInt32(read[0]);
                label2.Text = stok.ToString();
            }
            baglantı.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select count(Distinct marka) from Car ", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                int marka = Convert.ToInt32(read[0]);
                label3.Text = marka.ToString();
            }
            baglantı.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select count(*) from Car Where marka = '" + comboBox1.SelectedItem + "'", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                int marka = Convert.ToInt32(read[0]);
                label6.Text = marka.ToString();
            }
            baglantı.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select count(*) from Car Where yıl = '" + comboBox2.SelectedItem + "'", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                int yıl = Convert.ToInt32(read[0]);
                label8.Text = yıl.ToString();
            }
            baglantı.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select count(*) from Car Where sanzıman = '" + comboBox3.SelectedItem + "'", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                int sanzıman = Convert.ToInt32(read[0]);
                label10.Text = sanzıman.ToString();
            }
            baglantı.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select count(*) from Car Where yakıt = '" + comboBox4.SelectedItem + "'", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                int yakıt = Convert.ToInt32(read[0]);
                label12.Text = yakıt.ToString();
            }
            baglantı.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullaniciForm kullanici = new KullaniciForm();
            this.Close();
        }
    }
}
