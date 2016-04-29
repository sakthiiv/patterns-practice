using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractice.Creational
{
    class PrototypePattern
    {
        //public static void Main(string[] args)
        //{
        //    ConcretePrototype cp = new ConcretePrototype("Prototype.");
        //    Prototype cloned = cp.Clone();
        //    Console.WriteLine("Cloned: {0}", cloned.Name);
        //    Console.ReadKey();
        //}
    }

    abstract class Prototype
    {
        private string _name;

        public Prototype(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public abstract Prototype Clone();
    }

    class ConcretePrototype : Prototype
    {
        public ConcretePrototype(string name)
            : base(name)
        {
        }

        // Creates a shallow copy
        // Shallow Copy - All the objects will be referencing the same memory
        // Deep Copy - Objects will be initialized and new instance will be created
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
