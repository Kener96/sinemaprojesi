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
using System.IO;

namespace ilk
{
    public partial class Filmler : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ND28RV8\\SQLEXPRESS;Initial Catalog=project3;Integrated Security=True");
        public static string metin = "";
        public static string metin1 = "";
        public static string metin2 = "";
        public static string metin3 = "";
        public static string metin4 = "";
        public static string metin5 = "";
        public Filmler()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //this.TopMost = true;
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Film ", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_Film");
            int sumsave = ds.Tables["tbl_Film"].Rows.Count;
            con.Open();
            DataRow kayit = ds.Tables["tbl_Film"].Rows[0];
            labelcakal.Text = kayit.ItemArray.GetValue(1).ToString();
            DataRow kayit1 = ds.Tables["tbl_Film"].Rows[1];
            labelhedef.Text = kayit1.ItemArray.GetValue(1).ToString();
            DataRow kayit2 = ds.Tables["tbl_Film"].Rows[2];
            labelaqua.Text = kayit2.ItemArray.GetValue(1).ToString();
            DataRow kayit3 = ds.Tables["tbl_Film"].Rows[3];
            labelkafa.Text = kayit3.ItemArray.GetValue(1).ToString();
            DataRow kayit4 = ds.Tables["tbl_Film"].Rows[4];
            labelbum.Text = kayit4.ItemArray.GetValue(1).ToString();
            DataRow kayit5 = ds.Tables["tbl_Film"].Rows[5];
            labeldeli.Text = kayit5.ItemArray.GetValue(1).ToString();
            DataRow kayit6 = ds.Tables["tbl_Film"].Rows[6];
            labelhatir.Text = kayit6.ItemArray.GetValue(1).ToString();
            DataRow kayit7 = ds.Tables["tbl_Film"].Rows[7];
            labelmüs.Text = kayit7.ItemArray.GetValue(1).ToString();
            
            SqlCommand cmd = new SqlCommand("select resim from tbl_Image where ID=5", con);
            byte[] img = (byte[])cmd.ExecuteScalar();
            MemoryStream ms = new MemoryStream(img);
            pictureBoxbum.Image = Image.FromStream(ms);

            SqlCommand cmd1 = new SqlCommand("select resim from tbl_Image where ID=1", con);
            byte[] img1 = (byte[])cmd1.ExecuteScalar();
            MemoryStream ms1 = new MemoryStream(img1);
            pictureBoxaqua.Image = Image.FromStream(ms1);
            
            SqlCommand cmd2 = new SqlCommand("select resim from tbl_Image where ID=4", con);
            byte[] img2 = (byte[])cmd2.ExecuteScalar();
            MemoryStream ms2 = new MemoryStream(img2);
            pictureBoxhatir.Image = Image.FromStream(ms2);
            
            SqlCommand cmd3 = new SqlCommand("select resim from tbl_Image where ID=14", con);
            byte[] img3 = (byte[])cmd3.ExecuteScalar();
            MemoryStream ms3 = new MemoryStream(img3);
            pictureBoxkafa.Image = Image.FromStream(ms3);
            
            SqlCommand cmd4 = new SqlCommand("select resim from tbl_Image where ID=8", con);
            byte[] img4 = (byte[])cmd4.ExecuteScalar();
            MemoryStream ms4 = new MemoryStream(img4);
            pictureBoxcakal.Image = Image.FromStream(ms4);
            
            SqlCommand cmd5 = new SqlCommand("select resim from tbl_Image where ID=12", con);
            byte[] img5 = (byte[])cmd5.ExecuteScalar();
            MemoryStream ms5 = new MemoryStream(img5);
            pictureBoxhedef.Image = Image.FromStream(ms5);
            
            SqlCommand cmd6 = new SqlCommand("select resim from tbl_Image where ID=16", con);
            byte[] img6 = (byte[])cmd6.ExecuteScalar();
            MemoryStream ms6 = new MemoryStream(img6);
            pictureBoxmuslum.Image = Image.FromStream(ms6);
            
            SqlCommand cmd7 = new SqlCommand("select resim from tbl_Image where ID=10", con);
            byte[] img7 = (byte[])cmd7.ExecuteScalar();
            MemoryStream ms7 = new MemoryStream(img7);
            pictureBoxdeliler.Image = Image.FromStream(ms7);
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa frm1 = new AnaSayfa();
            frm1.Show();
            this.Hide();
        }

        private void pictureBoxaqua_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Film ", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_Film");
            int sumsave = ds.Tables["tbl_Film"].Rows.Count;
            con.Open();
            DataRow kayit = ds.Tables["tbl_Film"].Rows[2];
            label1.Text = kayit.ItemArray.GetValue(7).ToString();
            label2.Text = kayit.ItemArray.GetValue(1).ToString();
            label3.Text = kayit.ItemArray.GetValue(2).ToString();
            label4.Text = kayit.ItemArray.GetValue(3).ToString();
            label5.Text = kayit.ItemArray.GetValue(4).ToString();
            label6.Text = kayit.ItemArray.GetValue(5).ToString();
            FilmAyrinti frm4 = new FilmAyrinti();
            metin = label1.Text;
            metin1 = label2.Text;
            metin2 = label3.Text;
            metin3 = label4.Text;
            metin4 = label5.Text;
            metin5 = label6.Text;
            frm4.ShowDialog();
            con.Close();
        }

        private void pictureBoxhatir_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Film ", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_Film");
            int sumsave = ds.Tables["tbl_Film"].Rows.Count;
            con.Open();
            DataRow kayit = ds.Tables["tbl_Film"].Rows[6];
            label1.Text = kayit.ItemArray.GetValue(7).ToString();
            label2.Text = kayit.ItemArray.GetValue(1).ToString();
            label3.Text = kayit.ItemArray.GetValue(2).ToString();
            label4.Text = kayit.ItemArray.GetValue(3).ToString();
            label5.Text = kayit.ItemArray.GetValue(4).ToString();
            label6.Text = kayit.ItemArray.GetValue(5).ToString();
            FilmAyrinti frm4 = new FilmAyrinti();
            metin = label1.Text;
            metin1 = label2.Text;
            metin2 = label3.Text;
            metin3 = label4.Text;
            metin4 = label5.Text;
            metin5 = label6.Text;
            frm4.ShowDialog();
            con.Close();
        }

        private void pictureBoxkafa_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Film ", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_Film");
            int sumsave = ds.Tables["tbl_Film"].Rows.Count;
            con.Open();
            DataRow kayit = ds.Tables["tbl_Film"].Rows[3];
            label1.Text = kayit.ItemArray.GetValue(7).ToString();
            label2.Text = kayit.ItemArray.GetValue(1).ToString();
            label3.Text = kayit.ItemArray.GetValue(2).ToString();
            label4.Text = kayit.ItemArray.GetValue(3).ToString();
            label5.Text = kayit.ItemArray.GetValue(4).ToString();
            label6.Text = kayit.ItemArray.GetValue(5).ToString();
            FilmAyrinti frm4 = new FilmAyrinti();
            metin = label1.Text;
            metin1 = label2.Text;
            metin2 = label3.Text;
            metin3 = label4.Text;
            metin4 = label5.Text;
            metin5 = label6.Text;
            frm4.ShowDialog();
            con.Close();
        }

        private void pictureBoxcakal_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Film ", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_Film");
            int sumsave = ds.Tables["tbl_Film"].Rows.Count;
            con.Open();
            DataRow kayit = ds.Tables["tbl_Film"].Rows[0];
            label1.Text = kayit.ItemArray.GetValue(7).ToString();
            label2.Text = kayit.ItemArray.GetValue(1).ToString();
            label3.Text = kayit.ItemArray.GetValue(2).ToString();
            label4.Text = kayit.ItemArray.GetValue(3).ToString();
            label5.Text = kayit.ItemArray.GetValue(4).ToString();
            label6.Text = kayit.ItemArray.GetValue(5).ToString();
            FilmAyrinti frm4 = new FilmAyrinti();
            metin = label1.Text;
            metin1 = label2.Text;
            metin2 = label3.Text;
            metin3 = label4.Text;
            metin4 = label5.Text;
            metin5 = label6.Text;
            frm4.ShowDialog();
            con.Close();
        }

        private void pictureBoxhedef_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Film ", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_Film");
            int sumsave = ds.Tables["tbl_Film"].Rows.Count;
            con.Open();
            DataRow kayit = ds.Tables["tbl_Film"].Rows[1];
            label1.Text = kayit.ItemArray.GetValue(7).ToString();
            label2.Text = kayit.ItemArray.GetValue(1).ToString();
            label3.Text = kayit.ItemArray.GetValue(2).ToString();
            label4.Text = kayit.ItemArray.GetValue(3).ToString();
            label5.Text = kayit.ItemArray.GetValue(4).ToString();
            label6.Text = kayit.ItemArray.GetValue(5).ToString();
            FilmAyrinti frm4 = new FilmAyrinti();
            metin = label1.Text;
            metin1 = label2.Text;
            metin2 = label3.Text;
            metin3 = label4.Text;
            metin4 = label5.Text;
            metin5 = label6.Text;
            frm4.ShowDialog();
            con.Close();
        }

        private void pictureBoxmuslum_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Film ", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_Film");
            int sumsave = ds.Tables["tbl_Film"].Rows.Count;
            con.Open();
            DataRow kayit = ds.Tables["tbl_Film"].Rows[7];
            label1.Text = kayit.ItemArray.GetValue(7).ToString();
            label2.Text = kayit.ItemArray.GetValue(1).ToString();
            label3.Text = kayit.ItemArray.GetValue(2).ToString();
            label4.Text = kayit.ItemArray.GetValue(3).ToString();
            label5.Text = kayit.ItemArray.GetValue(4).ToString();
            label6.Text = kayit.ItemArray.GetValue(5).ToString();
            FilmAyrinti frm4 = new FilmAyrinti();
            metin = label1.Text;
            metin1 = label2.Text;
            metin2 = label3.Text;
            metin3 = label4.Text;
            metin4 = label5.Text;
            metin5 = label6.Text;
            frm4.ShowDialog();
            con.Close();
        }

        private void pictureBoxdeliler_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Film ", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_Film");
            int sumsave = ds.Tables["tbl_Film"].Rows.Count;
            con.Open();
            DataRow kayit = ds.Tables["tbl_Film"].Rows[5];
            label1.Text = kayit.ItemArray.GetValue(7).ToString();
            label2.Text = kayit.ItemArray.GetValue(1).ToString();
            label3.Text = kayit.ItemArray.GetValue(2).ToString();
            label4.Text = kayit.ItemArray.GetValue(3).ToString();
            label5.Text = kayit.ItemArray.GetValue(4).ToString();
            label6.Text = kayit.ItemArray.GetValue(5).ToString();
            FilmAyrinti frm4 = new FilmAyrinti();
            metin = label1.Text;
            metin1 = label2.Text;
            metin2 = label3.Text;
            metin3 = label4.Text;
            metin4 = label5.Text;
            metin5 = label6.Text;
            frm4.ShowDialog();
            con.Close();
        }

        private void pictureBoxbum_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Film ", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_Film");
            int sumsave = ds.Tables["tbl_Film"].Rows.Count;
            con.Open();
            DataRow kayit = ds.Tables["tbl_Film"].Rows[4];
            label1.Text = kayit.ItemArray.GetValue(7).ToString();
            label2.Text = kayit.ItemArray.GetValue(1).ToString();
            label3.Text = kayit.ItemArray.GetValue(2).ToString();
            label4.Text = kayit.ItemArray.GetValue(3).ToString();
            label5.Text = kayit.ItemArray.GetValue(4).ToString();
            label6.Text = kayit.ItemArray.GetValue(5).ToString();
            FilmAyrinti frm4 = new FilmAyrinti();
            metin = label1.Text;
            metin1 = label2.Text;
            metin2 = label3.Text;
            metin3 = label4.Text;
            metin4 = label5.Text;
            metin5 = label6.Text;
            frm4.ShowDialog();
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
