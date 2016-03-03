using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractice.Structural
{    
    class CompositePattern
    {        
        //public static void Main(string[] args)
        //{
        //    IComponent compA = new Component("LeafA");
        //    IComponent compB = new Component("LeafB");
        //    IComponent compC = new Component("LeafC");
        //    IComponent compD = new Component("LeafD");
        //    IComponent composA = new Composite("BranchA") { components = { compA, compB} };
        //    IComponent composB = new Composite("BranchB") { components = { composA, compC, compD } };
        //    IComponent composC = new Composite("BranchC") { components = { composA, composB } };
        //    composC.Activate();
        //    Console.ReadKey();
        //}
    }

    interface IComponent
    {
        //Setting Properties into Interface - Remember the get; set;
        int Level { get; set; }
        string Name { get; set; }
        void Activate();       
    }

    class Component : IComponent
    {
        private string _name = string.Empty;
        private int _level = 1;

        public string Name { get { return _name; } set { } }
        public int Level { get { return _level; } set { _level = value; } }

        public Component(string name)
        {
            _name = name;
        }

        public void Activate()
        {
            Console.WriteLine(new String('*', this._level) + " " + this._name);
        }
    }

    class Composite : IComponent
    {
        // IComponent helps in adding hierarchy structures of objects
        public List<IComponent> components = new List<IComponent>();

        private string _name = string.Empty;
        private int _level = 1;

        public string Name { get { return _name; } set { _name = value; } }
        public int Level { get { return _level; } set { _level = value; } }

        public Composite(string name)
        {
            Name = name;
        }

        public void Activate()
        {
            Console.WriteLine(new String('*', this._level) + " " + this._name);
            int childLevel = ++this._level;
            foreach (IComponent component in components)
            {
                component.Level = childLevel;
                component.Activate();
            }
        }
    }

}
