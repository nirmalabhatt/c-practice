using System;
namespace Indexer
{
    internal class IndexerExample

    {
        private string[] n = new string[size];
        static int size = 10;

        // A simple indexer 
        public string this[int i]
        {
            get
            {
                return n[i];
            }
            set
            {
                n[i] = value;
            }
        }

        static void Main(string[] args)
        {
            IndexerExample obj = new IndexerExample();
           
            obj[0] = "Hello";
            obj[1] = "Nirmala";
            obj[2] = "Bhatt";
            obj[3] = "BCA";
            obj[4] = "Student";

            // using the indexer 
            for (int i = 0; i < size; i++)
                Console.WriteLine(obj[i]);
            Console.ReadLine();

        }
    }
}
