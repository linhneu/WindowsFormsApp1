using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


    class PhongBanSQLCommand : SQLCustomeCommand
    {

        private string maPhongBan;
        private string tenPhongBan;
        private string diachi;
        private string chucNang;
        private string soDienThoai;
        private string ngayTL;
      
        private SqlConnection conn;
        private SqlCommand cmd; 

        public string MaPhongBan { get => maPhongBan; set => maPhongBan = value; }
        public string TenPhongBan { get => tenPhongBan; set => tenPhongBan = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string ChucNang { get => chucNang; set => chucNang = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }

        public string NgayTL { get => ngayTL; set => ngayTL = value; }

     


        public PhongBanSQLCommand()
        {
            
        }

       

        public void delete()
        {
            if (conn == null)
                conn = DBSQLServerUtils.GetDBConnection();
            try
            {
                if (maPhongBan != null && maPhongBan != "")
                {
                    cmd = new SqlCommand("delete from PHONGBAN where maphongban=@MaPhongBan", conn);

                    cmd.Parameters.AddWithValue("@MaPhongBan", maPhongBan);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Deleted Successfully!");

                }
                else
                {
                    MessageBox.Show("Please Select Record to Delete");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }

        public void insert()
        {
            if (conn == null)
                conn = DBSQLServerUtils.GetDBConnection();
            if (maPhongBan != "" && tenPhongBan != null && maPhongBan != "" && chucNang != null)
            {
                string insertQuery = " insert into PHONGBAN values (@MaPhongBan, @tenPB, @ngayTL , @diaChi, @chucNang, @sdt)"; 
                cmd = new SqlCommand(insertQuery, conn);

                cmd.Parameters.AddWithValue("@MaPhongBan", maPhongBan);
                cmd.Parameters.AddWithValue("@tenPB", tenPhongBan);
                cmd.Parameters.AddWithValue("@diaChi", diachi);
                cmd.Parameters.AddWithValue("@sdt", SoDienThoai);
                cmd.Parameters.AddWithValue("@chucNang", chucNang);
                cmd.Parameters.AddWithValue("@ngayTL", ngayTL);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record insert Successfully");
                conn.Close();

            }
            else
            {
                MessageBox.Show("Something Wrong");
            }

        }

        public void update()
        {
            if (conn == null)
                conn = DBSQLServerUtils.GetDBConnection();
            if (tenPhongBan != "" && tenPhongBan != null && maPhongBan != "" && maPhongBan != null)
            {
                string updateQuery = "update PHONGBAN set " +
                    " TenPhongBan=@tenPB ," +
                    " DiaChi=@diaChiPB, " +
                    " SDT = @sdtPB,  " +
                    " ChucNang = @ChucNangPB,  " +
                    " NgayThanhLap = @ngayTL  " + 
                    " where MaPhongBan= @id";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);


                cmd.Parameters.AddWithValue("@id", maPhongBan);
                cmd.Parameters.AddWithValue("@tenPB", tenPhongBan);
                cmd.Parameters.AddWithValue("@diaChiPB", diachi);
                cmd.Parameters.AddWithValue("@sdtPB", SoDienThoai);
                cmd.Parameters.AddWithValue("@ngayTL", ngayTL);

                cmd.Parameters.AddWithValue("@ChucNangPB", chucNang); 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conn.Close();
               
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
            
        }

    }
}
