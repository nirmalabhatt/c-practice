using System;
using System.Data.SqlClient;
namespace adoDOTnet
{
    internal class AdoCRUD
    {
        static SqlConnection conn;
        static string connString = "Data Source=DESKTOP-BMH1KMQ\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True";
        static void Main(string[] args)
        {
            int choose;
            try
            {
                do
                {
                    Console.WriteLine("\n========== Options==========");
                    Console.WriteLine("1)  INSERT");
                    Console.WriteLine("2)  Read");
                    Console.WriteLine("3)  Update");
                    Console.WriteLine("4)  Delete");
                    Console.WriteLine("5)  Exit");
                    Console.WriteLine("\n Choose An Option:");
                    choose = Convert.ToInt32(Console.ReadLine());
                    switch (choose)
                    {

                        case 1:
                            insertData();

                            break;
                        case 2:
                            readData();
                            break;
                        case 3:
                            updateData();
                            break;
                        case 4:
                            deleteData();
                            break;
                        case 5:
                            System.Environment.Exit(1);
                            break;
                        default:
                            {
                                Console.WriteLine("\n Invilid choise:");
                                break;
                            }
                    }
                }
                while (choose != 5);
            }catch (Exception e)
            {
                Console.WriteLine("Error!!!!" + e);
            }
        }
        private static void deleteData()
        {
            try
            {
                //Method for delete Data
                conn = new SqlConnection(connString);
                conn.Open();
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
                Console.WriteLine("Error!!!!" + e);
            }
        }
        private static void updateData()
        {
            int choice;
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                Console.WriteLine("\nYOUR OPTIONS:");
                Console.WriteLine("1)  UPDATE NAME");
                Console.WriteLine("2)  UPDATE SALARY");
                Console.WriteLine("3)  UPDATE HIREDATE");
                Console.WriteLine("CHOOSE ONE OPTION: ");
                choice= Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("enter the id to update Name:");
                        string Id = Console.ReadLine();
                        Console.WriteLine("Enter name for updateName");
                        string name = Console.ReadLine();
                        string  updateName = $"update emp set name ='{name}'where id = '{Id}' ";
                         SqlCommand update = new SqlCommand(updateName, conn);
                        SqlDataReader dr = update.ExecuteReader();
                        Console.WriteLine("Data Updated Successfully!!");
                        dr.Close();
                        break;
                    case 2:
                        Console.WriteLine("enter the id to update Salary:");
                        string ID = Console.ReadLine();
                        Console.WriteLine("Enter Salary:");
                        double Salary = Convert.ToDouble(Console.ReadLine());
                        string updateSalary = $"update emp set salary ='{Salary}'where id = '{ID}' ";
                        SqlCommand updateS = new SqlCommand(updateSalary, conn);
                        SqlDataReader s = updateS.ExecuteReader();
                        Console.WriteLine("Data Updated Successfully!!");
                        s.Close();
                        break;
                    case 3:
                        Console.WriteLine("enter the id to update hiredate:");
                        string iD = Console.ReadLine();
                        Console.WriteLine("Enter HireDAte(MM/dd/yyyy)");
                        DateTime HireDate = Convert.ToDateTime(Console.ReadLine());
                        string updateDate = $"update emp set hireDate ='{HireDate}'where id = '{iD}' ";
                        SqlCommand updated = new SqlCommand(updateDate, conn);
                        SqlDataReader d = updated.ExecuteReader();
                        Console.WriteLine("Data Updated Successfully!!");
                        d.Close();
                        break;
                        default:
                        {
                            Console.WriteLine("Please choose 1,2,3 Option only !!!:");
                            break;
                        }
                }
            }catch(Exception e)
            {
                Console.WriteLine(" Error in update data:"+e);
            }
        }
        private static void readData()
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                string sql1 = "select * from emp";
                SqlCommand query1 = new SqlCommand(sql1, conn);
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
                conn.Close();
            }catch (Exception e)
            {
                Console.WriteLine(" Error in Read data:" + e);
            }
        }
        private static void insertData()
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                Console.WriteLine("Enter ID:");
                string ID = Console.ReadLine();
                Console.WriteLine("Enter Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Salary:");
                double Salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter HireDAte(MM/dd/yyyy)");
                DateTime HireDate = Convert.ToDateTime(Console.ReadLine());
                string sql = $"insert into emp values('{ID}','{Name}',{Salary},'{HireDate}')";
                SqlCommand query = new SqlCommand(sql, conn);
                SqlDataReader d = query.ExecuteReader();
                Console.WriteLine("Data Inserted Successfully");
                d.Close();
                conn.Close();
            }catch (Exception e)
            {
                Console.WriteLine("Error in Insert data!!!!" + e);
            }

        }
       

    }
}




























            
           
