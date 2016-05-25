using RealWorld.IPL.Models;
using System.Collections.Generic;

namespace RealWorld.IPL.MatchScheduler
{
    interface IMatchGenerator
    {
        List<Match> Generate(ITeamGenerator team);
    }
}
