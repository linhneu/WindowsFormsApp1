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

namespace WindowsFormsApp1
{
    public partial class FrmDangNhap : Form
    {
        Clsdatabase cls = new Clsdatabase();
        private SqlConnection Con = null;
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-L9AEUH9\SQLEXPRESS;Initial Catalog=QLNS123;Integrated Security=True";
            Con.Open();
            string select = "Select * From tbuser where Username='" + tbxUsername.Text + "' and Pass='" + tbxPassword.Text + "' and Quyen='Admin'";
            SqlCommand cmd = new SqlCommand(select, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Read();
                MessageBox.Show("Đăng nhập vào hệ thống (Quyền Admin) !", "Thông báo !");
                FrmMain.quyen = "Admin";
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập vào hệ thống (Quyền user) !", "Thông báo !");
                FrmMain.quyen = "user";
                this.Hide();
                this.Close();
            }
            FrmMain frm = new FrmMain();
            frm.ShowDialog();
            cmd.Dispose();
            reader.Close();
            reader.Dispose();
        }
    }

}
    

