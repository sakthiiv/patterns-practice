using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractice.Behavioral
{
    class TemplatePattern
    {
        //public static void Main(string[] args)
        //{
        //    Template temp = new FeaturedAlgorithm();
        //    temp.Execute();
        //    temp = new BasicAlgorithm();
        //    temp.Execute();
        //    Console.ReadKey();
        //}
    }

    abstract class Template
    {
        public abstract void SortOperation();
        public abstract void SearchOperation();

        public void Execute()
        {
            SortOperation();
            SearchOperation();
        }
    }

    class FeaturedAlgorithm : Template
    {
        public override void SortOperation()
        {
            Console.WriteLine("Quick Sort");
        }

        public override void SearchOperation()
        {
            Console.WriteLine("Pattern Searching");
        }
    }

    class BasicAlgorithm : Template
    {
        public override void SortOperation()
        {
            Console.WriteLine("Insertion Sort");
        }

        public override void SearchOperation()
        {
            Console.WriteLine("Basic Searching");
        }
    }


}
