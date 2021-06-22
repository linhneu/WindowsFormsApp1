using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmDoiMatKhau : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            string update = "update tbuser set Pass='" + tbxMatKhauMoi.Text + "' where(Username=N'" + tbxTenDangNhap.Text + "' and Pass='" + tbxMatKhauCu.Text + "')";
            string ten = tbxTenDangNhap.Text;
            if (ten == "")
            {
                MessageBox.Show("Bạn chưa nhập tên truy cập");
            }
            else
            {
                if (tbxMatKhauCu.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                }
                else
                {
                    if (tbxMatKhauMoi.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                    }
                    else
                    {
                        if (tbxGoLaiMK.Text == "")
                        {
                            MessageBox.Show("Bạn chưa nhập lại mật khẩu");
                        }
                        else
                        {
                            if (tbxMatKhauMoi.Text == tbxGoLaiMK.Text)
                            {
                                cls.thucthiketnoi(update);
                                MessageBox.Show("Bạn đã thay đổi mật khẩu thành công");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Bạn nhập lại mật khẩu không đúng");
                            }
                        }
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            tbxTenDangNhap.Text = "";
            tbxMatKhauCu.Text = "";
            tbxMatKhauMoi.Text = "";
            tbxGoLaiMK.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
