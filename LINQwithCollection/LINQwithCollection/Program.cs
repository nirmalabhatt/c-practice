using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQwithCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> marks = new List<int> { 10, 20, 58, 65, 98, 96, 23 };
            var marks1= from submarks in marks where submarks%2==0 select submarks;
            marks1.ToList();
            foreach (var mark in marks1)
            {
                Console.WriteLine(mark);
            }
        }
    }
}
