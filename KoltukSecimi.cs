using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace ilk
{
    public partial class KoltukSecimi : Form
    {
        public KoltukSecimi()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=KAMILEENER-DELL\\KAMILEENER;Initial Catalog=dbo_sinema;Integrated Security=True");

        private void KoltukSecimi_Load(object sender, EventArgs e)
        {
            Panel p = new Panel();



            int sayac = 71;
            for (int i = 1; i < 8; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sayac--;

                    Button b = new Button();




                    b.BackgroundImage = Properties.Resources.koltuk_kırmızı;
                    b.Location = new System.Drawing.Point(j * 37, i * 35);
                    b.Size = new System.Drawing.Size(40, 37);
                   
                    b.Text = sayac.ToString();
                    this.Controls.Add(b);
                    b.Click += new EventHandler(b_Click);//b.Click diyerek tıklama özelliğine bir event tanımladık.

                }
            }


        }
        
  
    void b_Click(object sender, EventArgs e)
    {
        /* MessageBox.Show(((Button)sender).Text + "  tıklandı");*///sender o olayda kullanılan nesneleri bize getirir.((Button)sender) diyerek bu eventta kullanılan buttonu elde etmiş olduk.Farklı nesneler kullanılmış olsaydı örneğin ((Panel)sender) diyerek elde etmiş olurduk.
        textBox4.Text = ((Button)sender).Text;
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void click (object sender,EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
      







        private void textBox1_Click(object sender, EventArgs e)
        {


        }

       

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
