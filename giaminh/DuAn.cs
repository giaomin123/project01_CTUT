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


namespace giaminh
{
    public partial class DuAn : Form
    {
        SqlConnection ketnoi = new SqlConnection(@"Data Source=DESKTOP-2VP3D1S\SQLEXPRESS;Initial Catalog=QLDA;Integrated Security=True");
        public DuAn()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            
        }

        private void dsQLDA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            
        }

        public void load() {
            ketnoi.Open();
            string sqlSELECT = "select * from QLDA";
            SqlCommand k = new SqlCommand(sqlSELECT, ketnoi);
            SqlDataReader lgm = k.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(lgm);
            dsQLDA.DataSource = dt;
            dsQLDA.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dsQLDA.AutoSizeRowsMode = (DataGridViewAutoSizeRowsMode)DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
