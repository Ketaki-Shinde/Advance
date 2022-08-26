using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DemoAdoNet
{
    class DisConnected
    {
        public static DataSet getAllStudents()
        {
            SqlConnection conn = null;

            conn = DBConnect.getconnection();

            SqlDataAdapter sda = new SqlDataAdapter("select * from student", conn);
            DataSet ds = new DataSet();//Collection of tables

            sda.Fill(ds, "student");
            return ds;
        }

        static void Main(String[] args)
        {
         
            DataSet ds = getAllStudents();  
            foreach (DataRow dr in ds.Tables["student"].Rows)
            {
                Console.WriteLine(dr[0]+" " + dr[1]+" " + dr[2]);
            }
        }
    }
}
