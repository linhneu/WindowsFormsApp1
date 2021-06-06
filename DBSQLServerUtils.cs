using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using System.Data;



namespace WindowsFormsApp1
{
    // Data Source=DESKTOP-LSEGFR1\SQLEXPRESS;Initial Catalog=QUAN_LY_NHAN_SU;Integrated Security=True
    class DBSQLServerUtils
    {
        public static SqlConnection GetDBConnection(string datasource, string database)
        {
           
            string connString = @"Data Source=" + datasource + 
                                ";Initial Catalog=" + database +
                                ";Integrated Security=True" ;

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            return conn;
        }

        public static SqlConnection GetDBConnection()
        {
       
            string connString = @"Data Source=DESKTOP-LSEGFR1\SQLEXPRESS;Initial Catalog=QUAN_LY_NHAN_SU;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            return conn;
        }

       
        // insert 

            
        // Delete from database where 

       // Select * from database  load data from specific table name 

        public static DataTable loadData(string tableName)
        {
            SqlConnection conn = GetDBConnection();
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from ");
            sb.Append(tableName);

            SqlCommand command = new SqlCommand(sb.ToString(), conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            command.Dispose();
            conn.Close();
            return dataTable; 
        }

        private void readByRow(SqlCommand sqlCommand)
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
