using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld.IPL.Models
{
    class Team
    {
        private string _name;
        private Venue _home;
        private List<Player> _players;        

        public string Name
        {
            get { return _name; }
        }

        public Venue Home
        {
            get { return _home; }
        }

        public Team(string name, Venue home)
        {
            this._name = name;
            this._home = home;
        }

    }
}
