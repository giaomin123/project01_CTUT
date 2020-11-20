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
        SqlConnection ketnoi = new SqlConnection(@"Data Source=DESKTOP-2VP3D1S\SQLEXPRESS;Initial Catalog=dbQLCDACNTT;Integrated Security=True");
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
            load();
        }

        public void load() {
            ketnoi.Open();
            string sqlSELECT = "select * from QuanLyDuAn";
            SqlCommand m = new SqlCommand(sqlSELECT, ketnoi);
            SqlDataReader lgm = m.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(lgm);
            dsQLDA.DataSource = dt;
            ketnoi.Close();
            dsQLDA.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dsQLDA.AutoSizeRowsMode = (DataGridViewAutoSizeRowsMode)DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String tenDA = txtTenDA.Text.Trim();
            String maDA = txtMaDA.Text.Trim();
            String noiTrienKhai = txtNoiTK.Text.Trim();
            String loaiDA = txtLoaiDA.Text.Trim();
            DateTime dateBatDau = dateBD.Value;
            DateTime dateKetThuc = dateKT.Value;
            float kp = float.Parse(txtKP.Text.Trim());

            ketnoi.Open();
            String query = "Insert into QuanLyDuAn (tenDA, maDA, ngayBD, ngayKT, kinhphiDA, loaiDA, noiTrienKhai) VALUES (" + tenDA + ", " + maDA + "," + dateBatDau + "," + dateKetThuc + "," + kp + "," + loaiDA + "," + noiTrienKhai + ")";
            SqlCommand m = new SqlCommand(query, ketnoi);
            m.ExecuteNonQuery();
            ketnoi.Close();
            load();
        }
    }
}
