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
    public partial class BiletAl : Form
    {
        public BiletAl()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ND28RV8\\SQLEXPRESS;Initial Catalog=project3;Integrated Security=True");
        int filmid;
        int sehirid;
        //string filmad = null;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand("Select * from tbl_Sehir where SehirID='"+comboBox1.Text+"'", con);
            //SqlDataReader dr;
            //dr = komut.ExecuteReader();
            //while (dr.Read()) {
            //    string sehirad = (string)dr["SehirAd"].ToString();
            //    comboBox4.Text = sehirad;


        }
       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            { e.Handled = true; }
            else
            { e.Handled = false; }
        }


        private void BiletAl_Load_1(object sender, EventArgs e)
        {
            comboBoxcity.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select SehirAd from tbl_Sehir";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxcity.Items.Add(dr["SehirAd"].ToString());
            }
            con.Close();
            con.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select FilmAd from tbl_Film";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                comboBoxfilm.Items.Add(dr["FilmAd"].ToString());
            }
            con.Close();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            KoltukSecimi form = new KoltukSecimi();
            form.Show();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxsalon.Items.Clear();
            con.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select tbl_Salon.SalonAd from tbl_Salon inner join tbl_Sehir on tbl_Salon.SehirID=tbl_Sehir.SehirID where tbl_Sehir.SehirAd='" + comboBoxcity.Text + "'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                comboBoxsalon.Items.Add(dr["SalonAd"].ToString());
            }
            con.Close();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select tbl_Seans.SeansSaat from tbl_Seans right join tbl_Salon on tbl_Salon.SalonID=tbl_Seans.SalonID where tbl_Salon.SalonAd='" + comboBoxsalon.Text + "'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                comboBoxseans.Items.Add(dr["SeansSaat"].ToString());
            }
            con.Close();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            labelseat.Text = "1";
        }

        private void button70_Click(object sender, EventArgs e)
        {
            labelseat.Text = "2";
        }

        private void button69_Click(object sender, EventArgs e)
        {
            labelseat.Text = "3";
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            string film = comboBoxfilm.Text;
            string city = comboBoxcity.Text;
            string salon = comboBoxsalon.Text;
            string seans = comboBoxseans.Text;
            int seatnum = Int32.Parse(labelseat.Text);
            string query = "insert into tbl_BiletAlma(FilmAd,SalonAd,SehirAd,SeansAd,KoltukNumara) values ('"+film+"','"+salon+"','"+city+"','"+seans+"','"+seatnum+"')";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            con.Close();
            labelMessage.Visible = true;
            labelMessage.Text = "successfull.";
        }
    }
}
