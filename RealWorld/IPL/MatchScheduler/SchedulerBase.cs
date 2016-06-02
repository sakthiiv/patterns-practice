namespace RealWorld.IPL.MatchScheduler
{
    using RealWorld.IPL.Common;
    using RealWorld.IPL.Models;
    using System.Collections.Generic;

    // Template Pattern
    public abstract class SchedulerBase : IScheduler
    {
        private List<Match> _matches;

        public List<Match> Matches
        {
            get { return _matches; }
            protected set { _matches = value; }
        }

        public SchedulerBase()
        {
            
        }

        public abstract void Generate(IMatchGenerator match, ITeamGenerator team);
        public abstract void Display();
    }
}
