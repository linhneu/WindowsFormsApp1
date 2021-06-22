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

namespace WindowsFormsApp1
{
    public partial class FrmDangKi : Form
    {
        Clsdatabase cls = new Clsdatabase();
        Ketnoi kn = new Ketnoi();
        public FrmDangKi()
        {
            InitializeComponent();
        }
        private void FrmDangKi_Load(object sender, EventArgs e)
        {  
            cls.loaddatagridview(dgvTaiKhoan, "select * from tbuser");
            DuLieu_User();
            Hienthi_Dulieu();

        }

        public void DuLieu_User()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select Username, Pass, Ten, Quyen from tbuser");
            dgvTaiKhoan.DataSource = dta;

        }
        private void Hienthi_Dulieu()
        {
            tbxTenDangNhap.DataBindings.Clear();
            tbxTenDangNhap.DataBindings.Add("Text", dgvTaiKhoan.DataSource, "Username");

            tbxMatKhau.DataBindings.Clear();
            tbxMatKhau.DataBindings.Add("Text", dgvTaiKhoan.DataSource, "Pass");

            tbxHovaTen.DataBindings.Clear();
            tbxHovaTen.DataBindings.Add("Text", dgvTaiKhoan.DataSource, "Ten");

            cboQuyen.DataBindings.Clear();
            cboQuyen.DataBindings.Add("Text", dgvTaiKhoan.DataSource, "Quyen");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string delete = "delete from tbuser where Username=N'" + tbxTenDangNhap.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dgvTaiKhoan, "select * from tbuser");
            }
            MessageBox.Show("Đã xóa dữ liệu ");
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            tbxTenDangNhap.Text = "";
            tbxMatKhau.Text = "";
            tbxHovaTen.Text = "";
            cboQuyen.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update tbuser set Username=N'" + tbxTenDangNhap.Text + "',Pass=N'" + tbxMatKhau.Text + "',Quyen=N'" + cboQuyen.Text + "',Ten=N'" + tbxHovaTen.Text + "' where Username='" + tbxTenDangNhap.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dgvTaiKhoan, "select * from tbuser");
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string insert = "insert into tbuser values(N'" + tbxTenDangNhap.Text + "',N'" + cboQuyen.Text + "',N'" + tbxMatKhau.Text + "',N'" + tbxHovaTen.Text + "')";
                if (cls.kttrungkhoa(tbxTenDangNhap.Text, "select * from tbuser") == true)
                    MessageBox.Show("Tên đăng nhập này đã tồn tại. Bạn có thể thử tên khác");
                else
                {
                    cls.thucthiketnoi(insert);
                    MessageBox.Show("Chúc mừng bạn đã đăng kí thành công");
                    cls.loaddatagridview(dgvTaiKhoan, "select * from tbuser");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                tbxTenDangNhap.Text = dgvTaiKhoan.Rows[hang].Cells[0].Value.ToString();
                tbxMatKhau.Text = dgvTaiKhoan.Rows[hang].Cells[1].Value.ToString();
                tbxHovaTen.Text = dgvTaiKhoan.Rows[hang].Cells[2].Value.ToString();
                cboQuyen.Text = dgvTaiKhoan.Rows[hang].Cells[3].Value.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("");
            }

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
