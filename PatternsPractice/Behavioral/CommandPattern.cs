using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractice
{
    class CommandPattern
    {
        //public static void Main(string[] args)
        //{
        //    Receiver r = new Receiver();
        //    ConcreteCommand c = new ConcreteCommand(new Receiver());
        //    c.Execute();
        //    Console.ReadLine();
        //}
    }

    abstract class Command
    {
        protected Receiver _receiver;

        public Command(Receiver receiver)
        {
            _receiver = receiver;
        }

        public abstract void Execute();
    }

    class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver)
            : base(receiver)
        {

        }

        public override void Execute()
        {
            _receiver.Action();
        }
    }

    class Receiver
    {
        public void Action()
        {
            Console.WriteLine("This is some Action");
        }
    }


}
