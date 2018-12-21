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

namespace ilk
{
    public partial class FilmDüzenle : Form
    {
        public FilmDüzenle()
        {
            InitializeComponent();
            
        }

        SqlConnection con = new SqlConnection("Data Source=KAMILEENER-DELL\\KAMILEENER;Initial Catalog=dbo_sinema;Integrated Security=True");


        private void film()
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
            con.Close();


        }
        private void filmekle()
        {
            con.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_film(FilmAd,FilmTur,FilmSure,FilmYonetmen,FilmIcerik,FilmCast,FilmFragman,FilmAciklama,FilmAfis)values(@t1,@t2,@t3,@t4,@t5,@t6,@t7,@t8,@t9)", con);
            komut.Parameters.AddWithValue("@t1", txtad.Text);
            komut.Parameters.AddWithValue("@t2", txttur.Text);
            komut.Parameters.AddWithValue("@t3", txtsure.Text);
            komut.Parameters.AddWithValue("@t4", txtyonetmen.Text);
            komut.Parameters.AddWithValue("@t5", txticerik.Text);
            komut.Parameters.AddWithValue("@t6", txtcast.Text);
            komut.Parameters.AddWithValue("@t7", txtfragman.Text);
            komut.Parameters.AddWithValue("@t8", txtaciklama.Text);
            komut.Parameters.AddWithValue("@t9", txtresim.Text);
            komut.ExecuteNonQuery();
            con.Close();
            





        }
        private void film_sil()
        {
            
        }

        private void FilmDüzenle_Load(object sender, EventArgs e)
        {
            film();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filmekle();
            comboBox1.Refresh();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resimkutusu.ImageLocation = openFileDialog1.FileName;
            txtresim.Text = openFileDialog1.FileName;
        }
    }
}
