namespace RealWorld.IPL.MatchScheduler
{
    using RealWorld.IPL.Models;
    using System.Collections.Generic;

    public interface ITeamGenerator
    {
        List<Team> Generate();
    }
}
