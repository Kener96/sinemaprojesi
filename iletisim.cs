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
using System.Data;
using System.Text.RegularExpressions;

namespace ilk
{
    public partial class iletisim : Form
    {
        public iletisim()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source = KAMILEENER - DELL\\KAMILEENER; Initial Catalog = dbo_sinema; Integrated Security = True");
        private void button_send_Click(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            string kayit = "insert into tbl_iletisim (iletisim_name,iletisim_surname,iletisim_comment,iletisim_mail,iletisim_type) values (@iletisim_name,@iletisim_surname,@iletisim_comment,@iletisim_mail,@iletisim_type)";
            SqlCommand cmd = new SqlCommand(kayit, con);

            cmd.Parameters.AddWithValue("@iletisim_name", txt_name.Text);
            cmd.Parameters.AddWithValue("@iletisim_surname", txt_surname.Text);
            cmd.Parameters.AddWithValue("@iletisim_mail", txt_mail.Text);
            cmd.Parameters.AddWithValue("@iletisim_comment", txt_comment.Text);
            cmd.Parameters.AddWithValue("@iletisim_type", checkedListBox1.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Comments posted successfully.");
        }

        private void txt_mail_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider provider1 = new ErrorProvider();
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txt_mail.Text, pattern))
            {
                provider1.Clear();
            }

            else
            {
                provider1.SetError(this.txt_mail, "Please provide valid Mail adress");
                return;
            }
        }

        private void iletisim_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
