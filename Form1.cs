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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Getting Connection ...");
            SqlConnection conn = DBSQLServerUtils.GetDBConnection("DESKTOP-LSEGFR1\\SQLEXPRESS", "QUAN_LY_NHAN_SU");

            SqlCommand sqlCommand;
            SqlDataReader dataReader;
            String sql; 
            sql = "select * from NHANVIEN";
            sqlCommand = new SqlCommand(sql, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);


            DataSet customers = new DataSet();
            adapter.Fill(customers, "Customers");

            sqlCommand.Dispose();
            conn.Close(); 

            
        }


        private void readByRow(SqlCommand  sqlCommand)
        {
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
          
            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    Console.WriteLine(dataReader.GetValue(i) + "  ");


                }
                Console.WriteLine("=================");
            }; 


        }
    }
}
