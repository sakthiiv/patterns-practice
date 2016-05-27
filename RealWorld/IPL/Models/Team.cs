namespace RealWorld.IPL.Models
{
    using System.Collections.Generic;

    public class Team
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
