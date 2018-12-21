using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilk
{
    public partial class BiletAl : Form
    {
        public BiletAl()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source = KAMILEENER-DELL\\KAMILEENER; Initial Catalog = dbo_sinema; Integrated Security = True");
        int filmid;
        int sehirid;
        string filmad;
        private void BiletAl_Load(object sender, EventArgs e)
        {

            combo();
      
        }
        private void combo()
        {

            con.Open();
            SqlCommand komut = new SqlCommand("Select * from tbl_film", con);
            SqlDataReader reader = komut.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            DataRow dr = table.NewRow();
            dr["FilmAd"] = "Select your film";
            table.Rows.InsertAt(dr, 0);
            comboBox1.ValueMember = "FilmID";
            comboBox1.DisplayMember = "FilmAd";
            comboBox1.DataSource = table;
            filmad = comboBox1.SelectedItem.ToString();
            con.Close();


        }
        private void sehir()
        {

            con.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM tbl_film, tbl_FilmSalonSeans,tbl_Sehir WHERE tbl_film.FilmID = tbl_FilmSalonSeans.FilmID AND  tbl_FilmSalonSeans.SehirID=tbl_Sehir.SehirID AND tbl_film.FilmAd='" + filmad + "'", con);
            SqlDataReader reader = komut.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            DataRow dr = table.NewRow();
            sehirid = Convert.ToInt32(komut.ExecuteScalar());
            dr["SehirAd"] = "Select your city";
            table.Rows.InsertAt(dr, 0);
            comboBox4.ValueMember = "SehirID";
            comboBox4.DisplayMember = "SehirAd";
            comboBox4.DataSource = table;
            con.Close();

        }
        private void seans()
        {
            con.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM tbl_Sehir, tbl_FilmSalonSeans,tbl_Seans WHERE tbl_Sehir.SehirID = tbl_FilmSalonSeans.SehirID AND tbl_Seans.SeansID = tbl_FilmSalonSeans.SeansID AND tbl_Sehir.SehirID='" + sehirid + "'", con);
            SqlDataReader reader = komut.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            DataRow dr = table.NewRow();
            dr["SeansSaat"] = "Select your Seans";
            table.Rows.InsertAt(dr, 0);
            comboBox2.ValueMember = "SeansID";
            comboBox2.DisplayMember = "SeansSaat";
            comboBox2.DataSource = table;
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            KoltukSecimi frm = new KoltukSecimi();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
          //  label5.Text = "15₺";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           // label5.Text ="10 ₺";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //if (checkBox1.Checked)
            //{
            //    label5.Text = "10 ₺";
            //}
            //if (checkBox2.Checked)
            //{
            //    label5.Text = "15₺";
            //}
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

      

        int sayi;
        Random rnd = new Random();

        private void button3_Click(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            string kayit = "insert into tbl_Odeme (KullaniciAdSoyad,KullaniciEmail,KullaniciTc,KullaniciKrediKart," +
                "KullaniciSonKullanma,KullaniciGuvenlikNo,KullaniciTelefon)" +
                " values (@KullaniciAdSoyad,@KullaniciEmail,@KullaniciTc,@KullaniciKrediKart,@KullaniciSonKullanma," +
                "@KullaniciGuvenlikNo,@KullaniciTelefon)";
            SqlCommand cmd = new SqlCommand(kayit, con);

            cmd.Parameters.AddWithValue("@KullaniciAdSoyad", textBox14.Text);
            cmd.Parameters.AddWithValue("@KullaniciEmail", textBox13.Text);
            cmd.Parameters.AddWithValue("@KullaniciTc", textBox12.Text);
            cmd.Parameters.AddWithValue("@KullaniciKrediKart", textBox11.Text);
            cmd.Parameters.AddWithValue("@KullaniciSonKullanma", textBox9.Text);
            cmd.Parameters.AddWithValue("@KullaniciGuvenlikNo", textBox8.Text);
            cmd.Parameters.AddWithValue("@KullaniciTelefon", textBox10.Text);



            cmd.ExecuteNonQuery();
            con.Close();



            MessageBox.Show("tebrik");

  //*************************************************

            sayi = rnd.Next(10000, 90000);
            MailMessage msj = new MailMessage();
            SmtpClient client = new SmtpClient();

            client.Credentials = new System.Net.NetworkCredential("CineTicket.adu@hotmail.com", "cineticket123");
            client.Port=587;
            //587
            client.Host = "smtp.live.com";
            client.EnableSsl = true;
            object userState = msj;



            msj.To.Add(textBox13.Text);
            msj.From = new MailAddress("CineTicket.adu@hotmail.com", "CineTicket");
            msj.Subject = "CineTicket -> Güvenlik Kodu";

            msj.Body = sayi.ToString() + " Biletinizin onayı için lütfen kodu CineTicket sayfasına doğru bir şekilde giriniz.";


            client.Send(msj);
            MessageBox.Show("Doğrulama Kodu Gönderildi");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = label7.Text;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text =label6.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
