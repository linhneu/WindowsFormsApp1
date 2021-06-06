using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    interface SQLCustomeCommand
    {
        void update();
        void insert();
        void delete(); 

    }
}
