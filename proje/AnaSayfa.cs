using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilk
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
    
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ND28RV8\\SQLEXPRESS;Initial Catalog=project3;Integrated Security=True");

        private void circularButton1_Click(object sender, EventArgs e)
        {
            Filmler frm2 = new Filmler();
            frm2.Show();
            this.Hide();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("select resim from tbl_Image where ID=5", con);
            byte[] img = (byte[])cmd.ExecuteScalar();
            MemoryStream ms = new MemoryStream(img);
            pictureBoxbum.Image = Image.FromStream(ms);

            SqlCommand cmd1 = new SqlCommand("select resim from tbl_Image where ID=1", con);
            byte[] img1 = (byte[])cmd1.ExecuteScalar();
            MemoryStream ms1 = new MemoryStream(img1);
            pictureBoxaqua.Image = Image.FromStream(ms1);

            SqlCommand cmd5 = new SqlCommand("select resim from tbl_Image where ID=12", con);
            byte[] img5 = (byte[])cmd5.ExecuteScalar();
            MemoryStream ms5 = new MemoryStream(img5);
            pictureBoxhedef.Image = Image.FromStream(ms5);

            SqlCommand cmd6 = new SqlCommand("select resim from tbl_Image where ID=16", con);
            byte[] img6 = (byte[])cmd6.ExecuteScalar();
            MemoryStream ms6 = new MemoryStream(img6);
            pictureBoxmüslüm.Image = Image.FromStream(ms6);

            SqlCommand cmd7 = new SqlCommand("select resim from tbl_Image where ID=10", con);
            byte[] img7 = (byte[])cmd7.ExecuteScalar();
            MemoryStream ms7 = new MemoryStream(img7);
            pictureBoxdeliler.Image = Image.FromStream(ms7);
            con.Close();
        }

        private void circularButton2_Click(object sender, EventArgs e)
        {
            Sehirler formsehir = new Sehirler();
            formsehir.Show();
            this.Hide();
        }

        private void circularButton3_Click(object sender, EventArgs e)
        {
            Seans formseans = new Seans();
            formseans.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            iletisim formiletisim = new iletisim();
            formiletisim.Show();
            this.Hide();
        }


    }
}
