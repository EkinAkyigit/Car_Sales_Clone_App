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

namespace GörselProgramlamaProje
{
    public partial class AdminFormm : Form
    {
        public AdminFormm()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source = EKIN\\SQLEXPRESS; Initial Catalog = ProjeLoginScreen; Integrated Security = True");
        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox9.Text = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Car (stokKodu, marka, model, fiyat, yıl, kilometre, sanzıman, yakıt, stokMiktar,resim)" +
                "values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)", baglantı);
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.Parameters.AddWithValue("@p3", textBox4.Text);
            komut.Parameters.AddWithValue("@p4", textBox5.Text);
            komut.Parameters.AddWithValue("@p5", textBox6.Text);
            komut.Parameters.AddWithValue("@p6", textBox7.Text);
            komut.Parameters.AddWithValue("@p7", comboBox1.SelectedItem);
            komut.Parameters.AddWithValue("@p8", comboBox2.SelectedItem);
            komut.Parameters.AddWithValue("@p9", textBox8.Text);
            komut.Parameters.AddWithValue("@p10", textBox9.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kayıt Eklendi");

        }
        //private void listView1_Click(object sender, EventArgs e)
        //{

        //}
        int kod = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) //listwiew1_click
            {
                ListViewItem selected = listView1.SelectedItems[0];
                textBox1.Text = selected.SubItems[0].Text;
                textBox2.Text = selected.SubItems[1].Text;
                textBox3.Text = selected.SubItems[2].Text;
                textBox4.Text = selected.SubItems[3].Text;
                textBox5.Text = selected.SubItems[4].Text;
                textBox6.Text = selected.SubItems[5].Text;
                textBox7.Text = selected.SubItems[6].Text;
                comboBox1.Text = selected.SubItems[7].Text;
                comboBox2.Text = selected.SubItems[8].Text;
                textBox8.Text = selected.SubItems[9].Text;
                textBox9.Text = selected.SubItems[10].Text;

                pictureBox1.ImageLocation = selected.SubItems[10].Text;
            }
            kod = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[6].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[7].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox8.Text = listView1.SelectedItems[0].SubItems[9].Text;
            textBox9.Text = listView1.SelectedItems[0].SubItems[10].Text;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Delete from Car Where id = (" + kod + ")", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            button1.PerformClick();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Update Car set stokKodu='" + textBox2.Text.ToString() + "'," +
                //"stokKodu = '" + textBox2.Text.ToString() + "'," +
                "marka ='" + textBox3.Text.ToString() + "',model = '" + textBox4.Text.ToString() + "'," +
                "fiyat ='" + textBox5.Text.ToString() + "',yıl = '" + textBox6.Text.ToString() + "'," +
                "kilometre ='" + textBox7.Text.ToString() + "',sanzıman = '" + comboBox1.Text.ToString() + "'," +
                "yakıt ='" + comboBox2.Text.ToString() + "',stokMiktar = '" + textBox8.Text.ToString() + "'," +
                "resim ='" + textBox9.Text.ToString() + "' Where id = '" + kod + "'", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Güncelleme tamam!");
            button1.PerformClick();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
