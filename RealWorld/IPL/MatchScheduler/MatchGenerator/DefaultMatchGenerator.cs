using System.Collections.Generic;
using RealWorld.IPL.Models;
using System;
namespace RealWorld.IPL.MatchScheduler
{
    class DefaultMatchGenerator : IMatchGenerator
    {
        public DefaultMatchGenerator()
        {
            
        }

        public List<Match> Generate(ITeamGenerator team)
        {
            List<Team> teams = team.Generate();
            List<Match> matches = new List<Match>();

            AlternateMatchGenerator(teams, matches);
            AlternateMatchGenerator(teams, matches, true);

            return matches;
        }

        private void AlternateMatchGenerator(List<Team> teams, List<Match> matches, bool isPlayed = false)
        {
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
                k--; i = 0; ;
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
