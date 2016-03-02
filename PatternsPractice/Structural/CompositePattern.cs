using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractice.Structural
{
    class CompositePattern
    {
        public static void Main(string[] args)
        {

        }
    }

    interface IComponent
    {
        void Activate();
    }

    class Component : IComponent
    {
        private string _name = string.Empty;
        public Component(string name)
        {
            _name = name;
        }

        public void Activate()
        {
            Console.WriteLine("Activated for " + this._name);
        }
    }

    class Composite : IComponent
    {
        // IComponent helps in adding hierarchy structures of objects
        List<IComponent> _components = new List<IComponent>();

        public Composite(Component component)
        {
            _components.Add(component);
        }

        public void Activate()
        {
            foreach (Component component in _components)
            {
                component.Activate();
            }
        }
    }

}
