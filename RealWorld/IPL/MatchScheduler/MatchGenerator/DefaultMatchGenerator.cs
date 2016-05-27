namespace RealWorld.IPL.MatchScheduler
{
    using System;
    using System.Collections.Generic;
    using RealWorld.IPL.Models;    

    public class DefaultMatchGenerator : IMatchGenerator
    {
        public DefaultMatchGenerator()
        {
            
        }

        public List<Match> GenerateMatch(ITeamGenerator teamGenerator)
        {
            if (teamGenerator == null)
            {
                throw new ArgumentNullException("teamGenerator");
            }

            List<Team> teams = teamGenerator.Generate();
            List<Match> matches = new List<Match>();

            AlternateMatchGenerator(teams, matches);
            AlternateMatchGenerator(teams, matches, true);

            return matches;
        }

        private void AlternateMatchGenerator(List<Team> teams, List<Match> matches, bool isPlayed = false)
        {
            if (teams == null) {
                throw new ArgumentNullException("teams");
            }

            int i = 0, j = teams.Count - 1, k = teams.Count - 1, l = 0, m = 0, n = teams.Count - 1;

            while (k > i)
            {
                j = k;
                while (j > i && j != i)
                {
                    matches.Add(this.CreateMatch(teams[i], teams[j], isPlayed));
                    i++; j--;
                }
                j = n; l = ++m;
                while (j > l && j != l)
                {
                    matches.Add(this.CreateMatch(teams[l], teams[j], isPlayed));
                    l++; j--;
                }
                k--; i = 0;
                if (k < i)
                {
                    i++; k = teams.Count - 1;
                }
            }
        }

        private Match CreateMatch(Team teamA, Team teamB, bool isPlayed)
        {
            if (isPlayed)
            {
                Team temp = teamA;
                teamA = teamB;
                teamB = temp;
            }
            return new Match(teamA, teamB, teamA.Home, DateTime.Today);
        }
    }
}
