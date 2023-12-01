using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adoDOTnet
{
    internal class InsertUser
    {
        static void main(string[] args)
        {
            SqlConnection conn;
            string connString = "Data Source=DESKTOP-BMH1KMQ\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True";
            try
            {

                conn = new SqlConnection(connString);
                conn.Open();
                
                Console.WriteLine("Enter ID:");
                string ID= Console.ReadLine();
                Console.WriteLine("Enter Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Salary:");
                double Salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter HireDAte(MM/dd/yyyy)");
                DateTime HireDate= Convert.ToDateTime(Console.ReadLine());
                string sql = $"insert into emp values('{ID}','{Name}',{Salary},'{HireDate}')";
                SqlCommand query = new SqlCommand(sql, conn);
                SqlDataReader d = query.ExecuteReader();
                Console.WriteLine("Data Inserted Successfully");
                d.Close();

                string sql1 = "select * from emp";
                SqlCommand query1= new SqlCommand(sql1, conn);
                SqlDataReader reader = query1.ExecuteReader();
                Console.WriteLine("id\t\t name\t\t\tsalary\t\t\tHireDate");
                Console.WriteLine("===========================================================================");
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    string name = reader.GetString(1);
                    decimal salary = reader.GetDecimal(2);
                    DateTime hireDate = reader.GetDateTime(3);
                    Console.WriteLine($"{id}\t\t{name}\t\t{salary}\t\t{hireDate.ToString("yyyy-MM-dd")}");

                }
                reader.Close();
                Console.WriteLine("enter the id you want to delete");
                string Id = Console.ReadLine();

                string sqlDlt = $"delete from emp where id = '{Id}'";

                SqlCommand sqlDlt2 = new SqlCommand(sqlDlt, conn);
                SqlDataReader dr = sqlDlt2.ExecuteReader();
                Console.WriteLine("Data Deleted Successfully!!");
                dr.Close();


                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!!" + e);
            }
        }
    }
}



    