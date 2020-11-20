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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection ketnoi = new SqlConnection(@"Data Source=DESKTOP-2VP3D1S\SQLEXPRESS;Initial Catalog=NguoiDung;Integrated Security=True");
            if (txttaikhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên tài khoản !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtmatkhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    ketnoi.Open();
                    string tdn = txttaikhoan.Text;
                    string mk = txtmatkhau.Text;
                    string sql = "select * from NguoiDung where TaiKhoan = '" + tdn + " ' and MatKhau = '" + mk + "'";
                    SqlCommand m = new SqlCommand(sql, ketnoi);
                    SqlDataReader lgm = m.ExecuteReader();
                    if (lgm.Read() == true)
                    {
                        MessageBox.Show("Đăng nhập thành công", "Chúc mừng ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Hide();
                        DuAn DuAn = new DuAn();
                        DuAn.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập", "Thông Báo");
                    }
                    ketnoi.Close();
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối ! ");
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}