using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractice.Structural
{
    class AdapterPattern
    {
        //public static void Main(string[] args)
        //{
        //    ITarget target = new Adaptor();
        //    target.Execute();
        //    Console.ReadKey();
        //}
    }

    interface ITarget
    {
        void Execute();
    }

    class Target : ITarget
    {
        public virtual void Execute()
        {
            Console.WriteLine("From Target.");
        }
    }

    interface IAdaptor : ITarget
    {
        
    }


    class Adaptor : IAdaptor
    {
        Adaptee adaptee = new Adaptee();
        public void Execute()
        {
            adaptee.SpecificRequest();
        }
    }

    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("From Specific Adaptee.");
        }
    }

}
