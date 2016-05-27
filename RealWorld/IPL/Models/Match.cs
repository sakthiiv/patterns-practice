namespace RealWorld.IPL.Models
{
    using System;

    public class Match
    {
        private Team _teamA;
        private Team _teamB;
        private Venue _venue;
        private DateTime _matchDate;

        public Team TeamA
        {
            get { return _teamA; }
        }

        public Team TeamB
        {
            get { return _teamB; }
        }

        public Venue Venue
        {
            get { return _venue; }
        }

        public DateTime MatchDate
        {
            get { return _matchDate; }
        }

        public Match(Team teamA, Team teamB, Venue venue, DateTime matchDate)
        {
            this._teamA = teamA;
            this._teamB = teamB;
            this._venue = venue;
            this._matchDate = matchDate;
        }
    }
}
