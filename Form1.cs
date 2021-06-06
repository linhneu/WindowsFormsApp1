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

        private BindingSource bindingSource1 = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Console.WriteLine("Getting Connection ...");

            DataTable dataTable = DBSQLServerUtils.loadData("PHONGBAN");
            bindingSource1.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource1;


        }
        public void updateQuery()
        {

        }

      

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tableName = tbTableName.Text;

            Console.WriteLine("Getting Connection ...");

            DataTable dataTable = DBSQLServerUtils.loadData(tableName);
            bindingSource1.DataSource = dataTable;

            
        }
    }
}
