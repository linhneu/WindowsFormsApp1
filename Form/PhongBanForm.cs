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
    public partial class PhongBanForm : Form
    {

        private BindingSource bindingSource1 = new BindingSource();
        public PhongBanForm()
        {
            InitializeComponent();
        }


        private void loadData()
        {
            Console.WriteLine("Getting Connection ...");

            DataTable dataTable = DBSQLServerUtils.loadData("PHONGBAN");
            bindingSource1.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource1;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
            
        }
        public void updateQuery()
        {

        }

      

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // get selected content by click 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                tbMaPhongBan.Text = row.Cells["MaPhongBan"].Value.ToString();
                tbTenPhongBan.Text = row.Cells["TenPhongBan"].Value.ToString();
                tbDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                tbChucNang.Text = row.Cells["ChucNang"].Value.ToString();
                tbSDT.Text = row.Cells["SDT"].Value.ToString();
                string dateTimeString = row.Cells["NgayThanhLap"].Value.ToString();
                dtNgayThanhLap.Value = DataUtils.convertStringToDate(dateTimeString); 
               
            }

        }
     


        private PhongBanSQLCommand getPhongBanObject ()
        {
            PhongBanSQLCommand phongBan = new PhongBanSQLCommand();
          
            phongBan.MaPhongBan = tbMaPhongBan.Text;
            phongBan.TenPhongBan = tbTenPhongBan.Text;
            phongBan.Diachi = tbDiaChi.Text;
            phongBan.ChucNang = tbChucNang.Text;
            phongBan.SoDienThoai = tbSDT.Text;
            phongBan.NgayTL = dtNgayThanhLap.Value.ToShortDateString();
            return phongBan;
        }


    

        private void clearData()
        {
            tbMaPhongBan.Text = null;
            tbTenPhongBan.Text = null;
            tbChucNang.Text = null;
            tbDiaChi.Text = null;
            tbSDT.Text = null;
            
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            getPhongBanObject().insert();
            loadData();
            clearData();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            getPhongBanObject().update();
            clearData();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            getPhongBanObject().delete();
            clearData();
            loadData();

        }
    }
}
