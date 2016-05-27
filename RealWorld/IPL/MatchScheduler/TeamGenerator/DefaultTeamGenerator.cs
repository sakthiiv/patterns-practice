namespace RealWorld.IPL.MatchScheduler
{
    using System.Collections.Generic;
    using RealWorld.IPL.Models;

    public class DefaultTeamGenerator : ITeamGenerator
    {
        public DefaultTeamGenerator()
        {
            
        }

        public List<Team> Generate()
        {
            List<Team> teams = new List<Team>();

            teams.Add(new Team("Delhi Daredevils", GetVenue("Delhi")));
            teams.Add(new Team("Gujarat Lions", GetVenue("Gujarat")));
            teams.Add(new Team("Kings XI Punjab", GetVenue("Punjab")));
            teams.Add(new Team("Kolkata Knight Riders", GetVenue("Kolkata")));
            teams.Add(new Team("Mumbai Indians", GetVenue("Mumbai")));
            teams.Add(new Team("Rising Pune Supergiants", GetVenue("Pune")));
            teams.Add(new Team("Royal Challengers Bangalore", GetVenue("Bangalore")));
            teams.Add(new Team("Sunrisers Hyderabad", GetVenue("Hyderabad")));

            return teams;
        }

        public Venue GetVenue(string name)
        {
            return new Venue(name);
        }
    }
}
