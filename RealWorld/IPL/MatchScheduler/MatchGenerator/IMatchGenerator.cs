namespace RealWorld.IPL.MatchScheduler
{
    using RealWorld.IPL.Models;
    using System.Collections.Generic;

    public interface IMatchGenerator
    {
       List<Match> GenerateMatch(ITeamGenerator team);
    }
}
