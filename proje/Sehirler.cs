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
    public partial class Sehirler : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ND28RV8\\SQLEXPRESS;Initial Catalog=project3;Integrated Security=True");
        SqlCommand cmd;

        public Sehirler()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM Tbl_Sehir where SehirAd='" + comboBox2.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string adres = (string)dr["SehirID"].ToString();
                textBox2.Text = adres;


                string avmad = (string)dr["SehirAd"].ToString();
                textBox1.Text = avmad;
            }

            con.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            AnaSayfa formanasayfa = new AnaSayfa();
            formanasayfa.Show();
            this.Hide();
        }

        private void Sehirler_Load(object sender, EventArgs e)
        {

            comboBox2.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SehirAd FROM tbl_Sehir";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["SehirAd"].ToString());
            }
            con.Close();
        }
    }
}
