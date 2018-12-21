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
    public partial class Salon : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ND28RV8\\SQLEXPRESS;Initial Catalog=project3;Integrated Security=True");
        public Salon()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            con.Open();
            SqlCommand cmd= new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select SehirAd from tbl_Sehir";
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
            string salon = textBoxsalon.Text;
            int kapa = Int32.Parse(textBoxkap.Text);
            int sehir = Int32.Parse(textBoxsehir.Text);
            string query = "insert into tbl_Salon(SalonAd,SalonKapasite,SehirID) values ('" + salon + "','" + kapa + "','" + sehir + "')";
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

        private void buttonshow_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select tbl_Salon.SalonAd,tbl_Salon.SalonKapasite,tbl_Salon.SehirID,tbl_Sehir.SehirAd from tbl_Salon right join tbl_Sehir On tbl_Salon.SehirID=tbl_Sehir.SehirID where tbl_Sehir.SehirAd='" + comboBox1.Text + "'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con.Close();
        }



        private void buttonguncel_Click(object sender, EventArgs e)
        {
            labelup.Visible = true;
            textBoxup1.Visible = true;
            labelup1.Visible = true;
            labelup2.Visible = true;
            labelup3.Visible = true;
            textBoxup.Visible = true;
            textBoxup2.Visible = true;
            buttonupd.Visible = true;
            comboBox2.Visible = true;
            label2.Visible = true;
            comboBox3.Visible = true;
            comboBox2.Items.Clear();
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
                comboBox2.Items.Add(dr["SehirAd"].ToString());
            }
            con.Close();
            labelup.Text = "SalonName:";
            labelup2.Text = "Capacity:";
            labelup3.Text = "ID:";
            
        }
        

        private void buttonupd_Click(object sender, EventArgs e)
        {
            string salon = textBoxup1.Text;
            int kapa = Int32.Parse(textBoxup.Text);
            int sehir = Int32.Parse(textBoxup2.Text);
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-ND28RV8\\SQLEXPRESS;Initial Catalog=project3;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("update tbl_Salon set tbl_Salon.SalonAd='"+salon+"',tbl_Salon.SalonKapasite='" + kapa + "',tbl_Salon.SehirID='" + sehir + "' from tbl_Salon inner join tbl_Sehir on tbl_Salon.SehirID=tbl_Sehir.SehirID where tbl_Salon.SalonAd='" + comboBox3.Text + "' and tbl_Sehir.SehirAd='" + comboBox2.Text + "'", con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    labelMessage.Visible = true;
                    labelMessage.Text = "successfull.";
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Data is incorrect", ex.Message));
            }
            
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            string salon = textBoxsalon.Text;
            int kapa = Int32.Parse(textBoxkap.Text);
            int sehir = Int32.Parse(textBoxsehir.Text);
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-ND28RV8\\SQLEXPRESS;Initial Catalog=project3;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("delete from tbl_Salon where SalonAd='" + salon + "'and SehirID='" + sehir + "'and SalonKapasite='" + kapa + "'", con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    labelMessage.Visible = true;
                    labelMessage.Text = "successfull.";
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Data is incorrect", ex.Message));
            }
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            comboBoxadd.Items.Clear();
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
                comboBoxadd.Items.Add(dr["SehirAd"].ToString());
            }
            con.Close();
            labeladd.Visible = true;
            comboBoxadd.Visible = true;
            labeladdsalon.Visible = true;
            labeladdkapa.Visible = true;
            labelsehir.Visible = true;
            textBoxsalon.Visible = true;
            textBoxkap.Visible = true;
            textBoxsehir.Visible = true;
            buttonadd.Visible = true;
            buttondelete.Visible = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            con.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select tbl_Salon.SalonAd from tbl_Salon inner join tbl_Sehir on tbl_Salon.SehirID=tbl_Sehir.SehirID where tbl_Sehir.SehirAd='" + comboBox2.Text + "'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                comboBox3.Items.Add(dr["SalonAd"].ToString());
            }
            con.Close();
        }

        private void comboBoxadd_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select tbl_Salon.SehirID from tbl_Salon right join tbl_Sehir On tbl_Salon.SehirID=tbl_Sehir.SehirID where tbl_Sehir.SehirAd='" + comboBoxadd.Text + "'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                textBoxsehir.Text = dr["SehirID"].ToString();
            }
            con.Close();
        }
    }
}
