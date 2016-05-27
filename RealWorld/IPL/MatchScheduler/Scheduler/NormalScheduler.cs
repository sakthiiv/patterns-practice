namespace RealWorld.IPL.MatchScheduler
{
    using System;
    using RealWorld.IPL.Common;
    using RealWorld.IPL.Models;
    using System.Collections.Generic;

    class NormalScheduler : SchedulerBase
    {
        IMatchGenerator matchGenerator = new DefaultMatchGenerator();
        ITeamGenerator teamGenerator = new DefaultTeamGenerator();        

        public NormalScheduler()
        {
            this.Generate(matchGenerator, teamGenerator);
        }

        public override void Generate(IMatchGenerator match, ITeamGenerator team)
        {
            base.Matches = match.GenerateMatch(team);
        }

        public override void Display()
        {
            IFormatter<Tuple<int, string, string, string>> formatter = new TableFormatter<Tuple<int, string, string, string>>(new[] { "", "Team A", "Team B", "Venue" });
            List<Tuple<int, string, string, string>> matches = new List<Tuple<int, string, string, string>>();
            int i = 0;
            Matches.ForEach((m) =>
            {
                matches.Add(Tuple.Create(++i, m.TeamA.Name, m.TeamB.Name, m.Venue.Name));
            });
            formatter.Format(matches, idx => idx.Item1, t => t.Item2, t => t.Item3, v => v.Item4);
        }
    }
}
