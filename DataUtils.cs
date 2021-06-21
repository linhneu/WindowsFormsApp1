using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DataUtils
    {
        public static DateTime convertStringToDate(string v)
        {

            string[] v1 = v.Split(' ');
            string[] v2 = v1[0].Split('/');

            int month1 = Int32.Parse(v2[0]);
            int day1 = Int32.Parse(v2[1]);
            int year1 = Int32.Parse(v2[2]);
            DateTime d1 = new DateTime(year1, month1, day1);
            return d1;

        }
    }
}
