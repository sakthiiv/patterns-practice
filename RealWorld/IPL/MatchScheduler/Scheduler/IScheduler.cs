using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld.IPL.MatchScheduler
{
    interface IScheduler
    {        
        void Generate(IMatchGenerator match, ITeamGenerator team);
    }
}
