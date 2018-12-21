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
    public partial class BiletAyrinti : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ND28RV8\\SQLEXPRESS;Initial Catalog=project3;Integrated Security=True");
        public BiletAyrinti()
        {
            InitializeComponent();
        }

        private void BiletAyrinti_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT top 1 * FROM tbl_BiletAlma order by BiletID desc", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_BiletAlma");
            int sumsave = ds.Tables["tbl_BiletAlma"].Rows.Count;
            con.Open();
            DataRow kayit = ds.Tables["tbl_BiletAlma"].Rows[0];
            labelfilm.Text = kayit.ItemArray.GetValue(1).ToString();
            labelsalon.Text = kayit.ItemArray.GetValue(2).ToString();
            labelcity.Text = kayit.ItemArray.GetValue(3).ToString();
            labelseans.Text = kayit.ItemArray.GetValue(4).ToString();
            labelkoltuk.Text = kayit.ItemArray.GetValue(5).ToString();
        }
    }
}
