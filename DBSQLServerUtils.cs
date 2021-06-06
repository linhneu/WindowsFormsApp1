using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace WindowsFormsApp1
{
    // Data Source=DESKTOP-LSEGFR1\SQLEXPRESS;Initial Catalog=QUAN_LY_NHAN_SU;Integrated Security=True
    class DBSQLServerUtils
    {
        public static SqlConnection GetDBConnection(string datasource, string database)
        {
            //
            // Data Source=TRAN-VMWARE\SQLEXPRESS;Initial Catalog=simplehr;Persist Security Info=True;User ID=sa;Password=12345
            //
            string connString = @"Data Source=" + datasource + 
                                ";Initial Catalog=" + database +
                                ";Integrated Security=True" ;

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            return conn;
        }

        public static SqlConnection GetDBConnection()
        {
            //
            // Data Source=TRAN-VMWARE\SQLEXPRESS;Initial Catalog=simplehr;Persist Security Info=True;User ID=sa;Password=12345
            //
            string connString = @"Data Source=DESKTOP-LSEGFR1\SQLEXPRESS;Initial Catalog=QUAN_LY_NHAN_SU;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            return conn;
        }

       /* private void getData(string tableName)
        {
            SqlConnection conn = GetDBConnection();
            MySqlDataReader row;
            row = conn.ExecuteReader(query);

        }*/



    }
}
