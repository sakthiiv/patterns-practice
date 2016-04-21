using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractice.Behavioral
{
    class CommandPattern
    {
        //public static void Main(string[] args)
        //{
        //    Invoker i = new Invoker();
        //    Receiver r = new Receiver();
        //    ConcreteCommand c = new ConcreteCommand(new Receiver());
        //    i.SetCommand(c);
        //    i.ExecuteCommand();
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

    class Invoker
    {
        Command _command;
        public void SetCommand(Command command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            if (_command != null)
            {
                _command.Execute();
            }
        }
    }


}
