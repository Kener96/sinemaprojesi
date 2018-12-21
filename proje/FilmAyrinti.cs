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
    public partial class FilmAyrinti : Form
    {
        private string filmname="";
        private string filmtype="";
        private string filmdirector="";
        private string filmexp="";
        private string filmcast;
        private string filmtime;
        public FilmAyrinti()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ND28RV8\\SQLEXPRESS;Initial Catalog=project3;Integrated Security=True");
        private void FilmAyrinti_Load(object sender, EventArgs e)
        {
            filmexp = Filmler.metin.ToString();
            labelex.Text = filmexp;
            filmname = Filmler.metin1.ToString();
            labelname.Text = filmname;
            filmtype = Filmler.metin2.ToString();
            labeltype.Text = filmtype;
            filmtime = Filmler.metin3.ToString();
            labeltime.Text = filmtime;
            filmdirector = Filmler.metin4.ToString();
            labeldirector.Text = filmdirector;
            filmcast = Filmler.metin5.ToString();
            labelcast.Text = filmcast;
            con.Open();
            SqlCommand cmd = new SqlCommand("select resim from tbl_Image where FilmAd='"+ labelname.Text+ "'", con);
            byte[] img = (byte[])cmd.ExecuteScalar();
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            con.Close();
            

        }
    }
}
