using RealWorld.IPL.Models;
using System.Collections.Generic;

namespace RealWorld.IPL.MatchScheduler
{
    interface ITeamGenerator
    {
        List<Team> Generate();
    }
}
