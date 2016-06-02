using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld.IPL.MatchScheduler
{
    public interface ISchedulerFactory
    {
        IMatchGenerator GetMatchGenerator();
        ITeamGenerator GetTeamGenerator();
        SchedulerBase GetScheduler();
    }
}
