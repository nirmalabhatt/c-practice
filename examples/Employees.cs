using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    class Employees
    {
        private double salary;
        public void setSalary(double s)
        {
            salary = s;
        }
        public double getSalary()
        {
            return salary;
        }
    }
    class manager : Employees
    {
        private double bonos;
        public void displayBonos(double salary, double percent)
        {
            bonos = salary * percent / 100;
            Console.WriteLine(" the bonos is:" + bonos);
        }

    }
}
   




