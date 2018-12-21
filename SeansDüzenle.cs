using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace ilk
{
    public partial class SeansDüzenle : Form
    {
        public SeansDüzenle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=KAMILEENER-DELL\\KAMILEENER;Initial Catalog=dbo_sinema;Integrated Security=True");

        private void SeansDüzenle_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SehirAd FROM tbl_Sehir";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["SehirAd"].ToString());
            }
            con.Close();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
           // salonid=comboBoxsalon.
           // int salon = Int32.Parse(comboBoxsalon.Text);
            string salon = comboBoxsalon.Text;
            string hour = textBoxhour.Text;
            string date = textBoxdate.Text;
            int salonid = Int32.Parse(textBox1.Text);
            

            string query = "insert into tbl_Seans(SalonID,SalonAd,SeansSaat,SeansTarih) values ('" + salonid + "','" + salon + "','" + hour + "','" + date + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            con.Open();
            comboBoxsalon.Items.Clear();
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            // cmd1.CommandText = "select tbl_Seans.SalonName from tbl_Seans right join tbl_Sehir on tbl_Seans.SalonID=tbl_Sehir.SalonID where tbl_Sehir.SehirAd='"+comboBox1.Text+"'";
            cmd1.CommandText = "select tbl_Salon.SalonAd from tbl_Salon right join tbl_Sehir on tbl_Salon.SehirID=tbl_Sehir.SehirID where tbl_Sehir.SehirAd='" + comboBox1.Text + "'";
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
           // comboBox2.Items.Clear();
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            // cmd1.CommandText = "select tbl_Seans.SalonName from tbl_Seans right join tbl_Sehir on tbl_Seans.SalonID=tbl_Sehir.SalonID where tbl_Sehir.SehirAd='"+comboBox1.Text+"'";
            cmd1.CommandText = "select tbl_Seans.SeansTarih from tbl_Seans right join  tbl_Salon on tbl_Seans.SalonID=tbl_Salon.SalonID where tbl_Seans.SeansSaat='" + comboBox2.Text + "'";
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                comboBox3.Items.Add(dr["SeansTarih"].ToString());
            }
            con.Close();




        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            string salon = comboBoxsalon.Text;
            string hour = textBoxhour.Text;
            string date = textBoxdate.Text;
            int salonid = Int32.Parse(textBox1.Text);
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source = KAMILEENER-DELL\\KAMILEENER; Initial Catalog = dbo_sinema; Integrated Security = True"))
                {
                    if (comboBox2.SelectedIndex==1 && comboBox3.SelectedIndex==1)
                    {
                        SqlCommand cmd = new SqlCommand("delete from tbl_Seans where SalonID='" + salonid + "' SalonName='" + salon + "'and SeansSaat='" + hour + "'and SeansTarih='" + date + "'", con);
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        con.Close();
                    }
                   
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Data is incorrect", ex.Message));
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxhour_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxsalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            comboBox2.Items.Clear();
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            // cmd1.CommandText = "select tbl_Seans.SalonName from tbl_Seans right join tbl_Sehir on tbl_Seans.SalonID=tbl_Sehir.SalonID where tbl_Sehir.SehirAd='"+comboBox1.Text+"'";
            cmd1.CommandText = "select tbl_Seans.SeansSaat from tbl_Seans right join tbl_Salon on tbl_Seans.SalonID=tbl_Salon.SalonID where tbl_Salon.SalonAd='" + comboBoxsalon.Text + "'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                comboBox2.Items.Add(dr["SeansSaat"].ToString());
            }
            con.Close();




            //***********************

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select tbl_Salon.SalonID from tbl_Salon right join tbl_Seans on tbl_Salon.SalonID=tbl_Seans.SalonID where tbl_Salon.SalonAd='" + comboBoxsalon.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox1.Text = dr["SalonID"].ToString();
            }
            con.Close();




        }

    }
}
