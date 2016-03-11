using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractice.Behavioral
{
    class ObserverPattern
    {
        public static void Main(string[] args)
        {
            ConcreteSubject cs = new ConcreteSubject();

            ConcreteObserverA oa = new ConcreteObserverA(cs);
            ConcreteObserverB ob = new ConcreteObserverB(cs);            
            cs.Attach(oa);
            cs.Attach(ob);

            cs.state = "Completed";
            cs.Notify();            

            Console.WriteLine("*** Detaching ConcreteObserverA  ***");

            cs.Detach(oa);
            cs.state = "Again Started";
            cs.Notify();

            Console.ReadKey();
        }
    }

    abstract class Subject
    {
        List<Observer> _observers = new List<Observer>();
        public string state = "In Progress ..";
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer observer in _observers)
            {
                observer.Update();
            }
        }
    }

    class ConcreteSubject : Subject
    {
        public string State
        {
            get { return state; }
            set
            {
                state = value;
                this.Notify();
            }
        }

        ////No Need as the base class Notify will be exposed
        //public new void Notify()
        //{
        //    base.Notify();
        //}
    }

    abstract class Observer
    {
        public Subject subject;
        public Observer(Subject subject)
        {
            this.subject = subject;
        }

        public abstract void Update();
    }

    class ConcreteObserverA : Observer
    {
        public ConcreteObserverA(Subject subject)
            : base(subject)
        {
 
        }

        public override void Update()
        {
            Console.WriteLine("ConcreteObserverA State: " + subject.state);
        }
    }

    class ConcreteObserverB : Observer
    {
        public ConcreteObserverB(Subject subject)
            : base(subject)
        {
 
        }

        public override void Update()
        {
            Console.WriteLine("ConcreteObserverA State: " + subject.state);
        }
    }
}
