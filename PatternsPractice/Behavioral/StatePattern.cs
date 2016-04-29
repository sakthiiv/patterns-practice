using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractice.Behavioral
{
    class StatePattern
    {
        //public static void Main(string[] args)
        //{
        //    StateContext ctx = new StateContext();
        //    ctx.State = new StateA();
        //    ctx.Request();
        //    ctx.State = new StateB();
        //    ctx.Request();
        //    Console.ReadKey();
        //}
    }

    class StateContext
    {
        private State _state;
        public State State
        {
            set {
                _state = value;
            }
        }

        public StateContext()
        {
            
        }

        public void Request()
        {
            _state.CurrentState();
        }
    }

    abstract class State
    {
        public abstract void CurrentState();
    }

    class StateA : State
    {
        public override void CurrentState()
        {
            Console.WriteLine(this.GetType().ToString());
        }
    }

    class StateB : State
    {
        public override void CurrentState()
        {
            Console.WriteLine(this.GetType().ToString());
        }
    }
}
