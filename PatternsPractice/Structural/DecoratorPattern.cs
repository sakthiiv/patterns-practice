using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractice.Structural
{
    class DecoratorPattern
    {
        //public static void Main(string[] args)
        //{
        //    Component C = new ComponentA();
        //    Decorator D = new ConcreteDecoratorA();
        //    Decorator D2 = new ConcreteDecoratorB();

        //    D.SetComponent(C);
        //    //By Mistake, used D for the below statement and It didn't work :D
        //    D2.SetComponent(D);

        //    D2.Operation();
        //    Console.ReadLine();
        //}
    }

    abstract class Component
    {
        //Error virtual or abstract members cannot be private	
        public abstract void Operation();
    }

    class ComponentA : Component
    {
        //Specify override when using abstract
        public override void Operation()
        {
            Console.WriteLine("From Component A");
        }
    }

    abstract class Decorator : Component
    {
        private Component _component = null;

        public void SetComponent(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            if (_component != null)
                _component.Operation();            
        }

    }

    class ConcreteDecoratorA : Decorator
    {
        //Can add override to override the base class
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("From Decorator A with Component");
        }
    }

    class ConcreteDecoratorB : Decorator
    {
        //Can add override to override the base class
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("From Decorator B with Component");
        }
    }

}
