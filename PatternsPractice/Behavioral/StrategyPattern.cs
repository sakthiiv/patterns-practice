using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractice.Behavioral
{
    class StrategyPattern
    {
        //public static void Main(string[] args)
        //{
        //    Context strategy;
        //    strategy = new Context(new GraphAlgorithm());
        //    strategy.Invoke();
        //    strategy = new Context(new TreeAlgorithm());
        //    strategy.Invoke();
        //    Console.ReadKey();
        //}
    }

    abstract class Algorithm
    {
        public abstract void InvokeAlgorithm();
    }

    class GraphAlgorithm : Algorithm
    {
        public override void InvokeAlgorithm()
        {
            Console.WriteLine("This is a graph Algorithm");
        }
    }

    class TreeAlgorithm : Algorithm
    {
        public override void InvokeAlgorithm()
        {
            Console.WriteLine("This is a tree Algorithm");
        }
    }

    class Context
    {
        Algorithm _algorithm;

        public Context(Algorithm algorithm)
        {
            this._algorithm = algorithm;
        }

        public void Invoke()
        {
            _algorithm.InvokeAlgorithm();
        }
    }

}
