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
    public partial class SalonDuzenle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=KAMILEENER-DELL\\KAMILEENER;Initial Catalog=dbo_sinema;Integrated Security=True");

        public SalonDuzenle()
        {
            InitializeComponent();
        }



        private void SalonDuzenle_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
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
                comboBox1.Items.Add(dr["SehirAd"].ToString());
            }
            con.Close();
            comboBoxadd.Items.Clear();
            con.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select SehirAd from tbl_Sehir";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                comboBoxadd.Items.Add(dr1["SehirAd"].ToString());
            }
            con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;

            con.Open();
            SqlCommand cmd = new SqlCommand("select tbl_Salon.SalonAd,tbl_Salon.SalonKapasite,tbl_Salon.SehirID,tbl_Sehir.SehirAd from tbl_Salon right join tbl_Sehir On tbl_Salon.SehirID=tbl_Sehir.SehirID where tbl_Sehir.SehirAd='" + comboBox1.Text + "'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["SalonAd"].ToString());                
                item.SubItems.Add(dr["SalonKapasite"].ToString());
                item.SubItems.Add(dr["SehirID"].ToString());
                listView1.Items.Add(item);
            }


            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void txtad_TextChanged(object sender, EventArgs e)
        {

        }


        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxadd_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select tbl_Salon.SehirID from tbl_Salon right join tbl_Sehir on tbl_Salon.SehirID=tbl_Sehir.SehirID where tbl_Sehir.SehirAd='" + comboBoxadd.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                textBoxsehir.Text=dr["SehirID"].ToString();
            }
            con.Close();


            comboBox3.Items.Clear();
            con.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select tbl_Salon.SalonAd from tbl_Salon right join tbl_Sehir on tbl_Salon.SehirID=tbl_Sehir.SehirID where tbl_Sehir.SehirAd='" + comboBoxadd.Text + "'";
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

        private void buttonadd_Click(object sender, EventArgs e)
        {
            string salon = textBoxsalon.Text;
            int kapa = Int32.Parse(textBoxkap.Text);
            int sehir = Int32.Parse(textBoxsehir.Text);
            string query = "insert into tbl_Salon(SalonAd,SalonKapasite,SehirID) values('" + salon + "','" + kapa + "','" + sehir + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            con.Close();
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            string salon = textBoxsalon.Text;
            int sehir = Int32.Parse(textBoxsehir.Text);
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=KAMILEENER-DELL\\KAMILEENER;Initial Catalog=dbo_sinema;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from tbl_Salon where SalonAd='" + salon + "'and SehirID='" + sehir + "'", con);
                    // cmd.Parameters.AddWithValue("@salon",textBoxsalon.Text);
                    
                    SqlDataReader dr = cmd.ExecuteReader();
                    con.Close();



                }

            }
            catch(SystemException ex)
            {
                MessageBox.Show(string.Format("data is incorrect", ex.Message));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string salon = textBoxsalon.Text;
            int kapa = Int32.Parse(textBoxkap.Text);
            int sehir = Int32.Parse(textBoxsehir.Text);
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=KAMILEENER-DELL\\KAMILEENER;Initial Catalog=dbo_sinema;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("update tbl_Salon set tbl_Salon.SalonAd='" + salon + "',tbl_Salon.SalonKapasite='" + kapa + "',tbl_Salon.SehirID='" + sehir + "' from tbl_Salon inner join tbl_Sehir on tbl_Salon.SehirID=tbl_Sehir.SehirID where tbl_Salon.SalonAd='" + comboBox3.Text + "' and tbl_Sehir.SehirAd='" + comboBoxadd.Text + "'", con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Data is incorrect", ex.Message));
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelsehir_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           //.SelectedItems[0].Remove();
        }

        private void textBoxsalon_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
