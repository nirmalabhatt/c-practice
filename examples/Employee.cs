using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//program of indexing:
namespace examples
{
    internal class Employee : EmployeeBase
    {
        private string[]arr= new string[2];
        public string this[int i]
        {
            get
            {
                return arr[i];
            }
            set
            {
                arr[i] = value;
            }
        }

    }
    
 }


