using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adoDOTnet
{
    internal class Insert
    {

        static void main(string[] args)
        {
            SqlConnection conn;
            string connString = "Data Source=DESKTOP-BMH1KMQ\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True";
            try
            {
                
                conn = new SqlConnection(connString);
                conn.Open();
                string sql = "insert into emp values('S105','NirmalaBhatt',3000,'2020-05-19')";
                SqlCommand query = new SqlCommand(sql, conn);
                query.ExecuteReader();

                Console.WriteLine("Data Inserted Successfully");

                conn.Close();
            }catch(Exception e)
            {
                Console.WriteLine("Error!!"+e);
            }
        }
    }
}
