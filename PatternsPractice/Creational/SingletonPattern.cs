using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractice.Creational
{
    class SingletonPattern
    {
        public static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;

            if (s1 == s2)
            {
                Console.WriteLine("Objects are same.");
            }
            Console.ReadKey();
        }
    }

    public sealed class Singleton
    {
        private Singleton()
        {
        }

        public static Singleton Instance { get { return Nested.instance; } }

        private class Nested
        {
            static Nested()
            {
            }

            internal static readonly Singleton instance = new Singleton();
        }
    }
}
