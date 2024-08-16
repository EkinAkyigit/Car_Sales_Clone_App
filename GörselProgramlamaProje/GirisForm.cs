using System.Data.SqlClient;

namespace GörselProgramlamaProje
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source = EKIN\\SQLEXPRESS; Initial Catalog = ProjeLoginScreen; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            string kadi, ksifre, kKisi;
            kadi = textBox1.Text;
            ksifre = textBox2.Text;

            baglantı.Open();
            SqlCommand sorgu = new SqlCommand("select KullaniciKisi from Kullanici where KullaniciAdi='" + kadi + "' " +
                                                "and KullaniciSifre='" + ksifre + "'", baglantı);
            SqlDataReader read = sorgu.ExecuteReader();

            if (read.Read())
            {
                kKisi = read[0].ToString();


                if (kKisi.ToString().Trim() == "admin")
                {
                    AdminFormm admin = new AdminFormm();
                    admin.Show();
                    this.Hide();
                }
                else if (kKisi.ToString().Trim() == "kullanici")
                {
                    KullaniciForm kullanici = new KullaniciForm();
                    kullanici.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("Hatalı Giriş Yaptınız");
            baglantı.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Transparent, Color.Transparent);
        }
        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);
                // Clear text and border
                g.Clear(this.BackColor);
                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);
                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }
    }
}
