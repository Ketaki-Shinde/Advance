using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DemoAdoNet
{
    static class DBConnect
    {
        public static SqlConnection getconnection()
        {
            string str = "server=LAPTOP-IV9I3N8R\\SQLEXPRESS; Database=hr;Integrated Security=true";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                con.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return con;
        }

    }
}
