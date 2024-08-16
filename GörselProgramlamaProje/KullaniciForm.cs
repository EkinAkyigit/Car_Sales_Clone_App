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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GörselProgramlamaProje
{
    public partial class KullaniciForm : Form
    {
        public KullaniciForm()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source = EKIN\\SQLEXPRESS; Initial Catalog = ProjeLoginScreen; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglantı.Open();
            string marka = textBox3.Text.ToString();
            SqlCommand command = new SqlCommand("SELECT * FROM Car WHERE " + "marka = '" + marka + "'", baglantı);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                listView1.Items.Add(read["id"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["stokKodu"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["marka"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["model"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["fiyat"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["yıl"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["kilometre"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["sanzıman"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["yakıt"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["stokMiktar"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["resim"].ToString());
            }
            baglantı.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand command = new SqlCommand("Select*from Car", baglantı);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                listView1.Items.Add(read["id"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["stokKodu"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["marka"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["model"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["fiyat"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["yıl"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["kilometre"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["sanzıman"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["yakıt"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["stokMiktar"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["resim"].ToString());
            }
            baglantı.Close();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglantı.Open();
            string minFiyat = textBox1.Text.ToString();
            string maxFiyat = textBox2.Text.ToString();
            SqlCommand komut = new SqlCommand("SELECT * FROM Car WHERE fiyat >= '" + minFiyat + "'AND " + "fiyat <= '" + maxFiyat + "'", baglantı);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                listView1.Items.Add(oku["id"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["stokKodu"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["marka"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["model"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["fiyat"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["yıl"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["kilometre"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["sanzıman"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["yakıt"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["stokMiktar"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["resim"].ToString());
            }
            baglantı.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglantı.Open();
            string model = textBox4.Text.ToString();
            SqlCommand command = new SqlCommand("SELECT * FROM Car WHERE " + "model = '" + model + "'", baglantı);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                listView1.Items.Add(read["id"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["stokKodu"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["marka"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["model"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["fiyat"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["yıl"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["kilometre"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["sanzıman"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["yakıt"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["stokMiktar"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["resim"].ToString());
            }
            baglantı.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglantı.Open();
            string yıl = comboBox1.SelectedItem.ToString();
            SqlCommand command = new SqlCommand("SELECT * FROM Car WHERE " + "yıl = '" + yıl + "'", baglantı);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                listView1.Items.Add(read["id"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["stokKodu"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["marka"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["model"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["fiyat"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["yıl"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["kilometre"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["sanzıman"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["yakıt"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["stokMiktar"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(read["resim"].ToString());
            }
            baglantı.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglantı.Open();
            string minKm = textBox8.Text.ToString();
            string maxKm = textBox5.Text.ToString();
            SqlCommand komut = new SqlCommand("SELECT * FROM Car WHERE kilometre >= '" + minKm + "'AND " + "kilometre <= '" + maxKm + "'", baglantı);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                listView1.Items.Add(oku["id"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["stokKodu"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["marka"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["model"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["fiyat"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["yıl"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["kilometre"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["sanzıman"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["yakıt"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["stokMiktar"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["resim"].ToString());
            }
            baglantı.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglantı.Open();
            string sanzıman = "";

            if (radioButton1.Checked)
            {
                SqlCommand komut = new SqlCommand("select * from Car where sanzıman" + sanzıman + "='Otomatik'", baglantı);

                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    listView1.Items.Add(oku["id"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["stokKodu"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["marka"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["model"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["fiyat"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["yıl"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["kilometre"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["sanzıman"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["yakıt"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["stokMiktar"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["resim"].ToString());
                }
                baglantı.Close();
            }

            if (radioButton2.Checked)
            {
                SqlCommand komut = new SqlCommand("select * from Car where sanzıman" + sanzıman + "='Manuel'", baglantı);

                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    listView1.Items.Add(oku["id"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["stokKodu"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["marka"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["model"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["fiyat"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["yıl"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["kilometre"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["sanzıman"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["yakıt"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["stokMiktar"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["resim"].ToString());
                }
                baglantı.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglantı.Open();
            string yakıt = "";

            if (radioButton3.Checked)
            {
                SqlCommand komut = new SqlCommand("select * from Car where yakıt" + yakıt + "='Benzin'", baglantı);

                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    listView1.Items.Add(oku["id"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["stokKodu"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["marka"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["model"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["fiyat"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["yıl"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["kilometre"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["sanzıman"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["yakıt"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["stokMiktar"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["resim"].ToString());
                }
                baglantı.Close();
            }

            if (radioButton4.Checked)
            {
                SqlCommand komut = new SqlCommand("select * from Car where yakıt" + yakıt + "='Dizel'", baglantı);

                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    listView1.Items.Add(oku["id"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["stokKodu"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["marka"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["model"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["fiyat"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["yıl"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["kilometre"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["sanzıman"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["yakıt"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["stokMiktar"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["resim"].ToString());
                }
                baglantı.Close();
            }
            if (radioButton5.Checked)
            {
                SqlCommand komut = new SqlCommand("select * from Car where yakıt" + yakıt + "='Elektrik'", baglantı);

                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    listView1.Items.Add(oku["id"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["stokKodu"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["marka"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["model"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["fiyat"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["yıl"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["kilometre"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["sanzıman"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["yakıt"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["stokMiktar"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["resim"].ToString());
                }
                baglantı.Close();
            }

            if (radioButton6.Checked)
            {
                SqlCommand komut = new SqlCommand("select * from Car where yakıt" + yakıt + "='Hibrit'", baglantı);

                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    listView1.Items.Add(oku["id"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["stokKodu"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["marka"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["model"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["fiyat"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["yıl"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["kilometre"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["sanzıman"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["yakıt"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["stokMiktar"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["resim"].ToString());
                }
                baglantı.Close();
            }
        }
        int kod = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            kod = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            textBox6.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox9.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox10.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox11.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox12.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox13.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox14.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox15.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox16.Text = listView1.SelectedItems[0].SubItems[9].Text;
            pictureBox_car.ImageLocation = listView1.SelectedItems[0].SubItems[10].Text;

        }

        private void pictureBox_car_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            İstatistik istatistik = new İstatistik();
            istatistik.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KullaniciForm_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("SELECT DISTINCT(yıl) FROM Car;", baglantı);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                comboBox1.Items.Add(oku2["yıl"].ToString());
            }
            baglantı.Close();
        }
    }
}
