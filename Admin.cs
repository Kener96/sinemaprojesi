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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=KAMILEENER-DELL\\KAMILEENER;Initial Catalog=dbo_sinema;Integrated Security=True");
        

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //SqlDataAdapter dr = new SqlDataAdapter(cmd);
            SqlCommand cmd = new SqlCommand("Select *from tbl_Admin where adminAd='" + textBox1.Text + "' and adminSifre='" + textBox2.Text + "' and adminSoyad='" + textBox3.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                AdminFormu formadminformu = new AdminFormu();
                formadminformu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User name-surname or password false. ");

            }
        }
    }
}
