using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractice.Structural
{
    class FacadePattern
    {
        //public static void Main(string[] args)
        //{
        //    Facade facade = new Facade();
        //    facade.FacadeA();
        //    facade.FacadeB();

        //    Console.ReadKey();
        //}
    }

    class Facade
    {
        SubSystemOne _one;
        SubSystemTwo _two;
        SubSystemThree _three;

        public Facade()
        {
            _one = new SubSystemOne();
            _two = new SubSystemTwo();
            _three = new SubSystemThree();
        }

        public void FacadeA()
        {
            _one.Execute();
            _two.Execute();
        }

        public void FacadeB()
        {
            _two.Execute();
            _three.Execute();
        }
    }

    #region Sub-Systems

    class SubSystemOne
    {
        public void Execute()
        {
            Console.WriteLine("One.");
        }
    }

    class SubSystemTwo
    {
        public void Execute()
        {
            Console.WriteLine("Two.");
        }
    }

    class SubSystemThree
    {
        public void Execute()
        {
            Console.WriteLine("Three.");
        }
    }

    #endregion

}
