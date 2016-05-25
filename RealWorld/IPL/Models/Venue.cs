using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld.IPL.Models
{
    class Venue
    {
        private string _name;

        public string Name
        {
            get { return _name; }
        }

        public Venue(string name)
        {
            this._name = name;
        }
    }
}
