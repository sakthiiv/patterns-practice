namespace RealWorld.IPL.Models
{
    public class Venue
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
