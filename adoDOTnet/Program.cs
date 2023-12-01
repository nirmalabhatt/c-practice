using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adoDOTnet
{
    internal class Program
    {
        static void main(string[] args)
        {
            SqlConnection conn ;
            string conString = "Data Source=DESKTOP-BMH1KMQ\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True";
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();
                Console.WriteLine("Connection openSuccessfully");

                string sql = "select * from emp";
                SqlCommand query= new SqlCommand(sql, conn);
                SqlDataReader reader = query.ExecuteReader();
                Console.WriteLine("id\t\t name\t\t\tsalary\t\t\tHireDate");
                Console.WriteLine("===========================================================================");
                while (reader.Read())
                {
                    //Console.WriteLine(reader.GetString(0));
                    //Console.WriteLine(reader.GetString(1));
                    //Console.WriteLine(reader.GetDecimal(2));
                    //Console.WriteLine(reader.GetDateTime(3));
                    string id = reader.GetString(0);
                    string name=reader.GetString(1);
                    decimal salary =reader.GetDecimal(2);
                    DateTime hireDate= reader.GetDateTime(3);
                    Console.WriteLine($"{id}\t\t{name}\t\t{salary}\t\t{hireDate.ToString("yyyy-MM-dd")}");

                }
                reader.Close();

                conn.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Eroor!!"+e);
            }

        }
    }
}
