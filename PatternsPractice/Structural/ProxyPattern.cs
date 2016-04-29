using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractice.Structural
{
    class ProxyPattern
    {
        //public static void Main(string[] args)
        //{
        //    ProxySubject ps = new ProxySubject();
        //    ps.Request();
        //    Console.ReadKey();
        //}
    }

    abstract class Subject
    {
        public abstract void Request();
    }

    class ConcreteSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("From Concrete Subject.");
        }
    }

    class ProxySubject : Subject
    {
        private ConcreteSubject _cs;

        public override void Request()
        {
            if (_cs == null)
            {
                _cs = new ConcreteSubject();
            }
            _cs.Request();
        }
    }
}
