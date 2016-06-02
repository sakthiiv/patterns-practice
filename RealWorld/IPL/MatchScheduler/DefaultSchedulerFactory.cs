using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld.IPL.MatchScheduler
{
    public class DefaultSchedulerFactory : ISchedulerFactory
    {
        private readonly IMatchGeneratorFactory _matchGeneratorFactory;
        private readonly ITeamGeneratorFactory _teamGeneratorFactory;
        private readonly SchedulerBase _scheduler;

        public DefaultSchedulerFactory(IMatchGeneratorFactory matchGeneratorFactory, ITeamGeneratorFactory teamGeneratorFactory, SchedulerBase scheduler)
        {
            this._matchGeneratorFactory = matchGeneratorFactory;
            this._teamGeneratorFactory = teamGeneratorFactory;
            this._scheduler = scheduler;
        }

        public IMatchGenerator GetMatchGenerator()
        {
            return this._matchGeneratorFactory.Create();
        }

        public ITeamGenerator GetTeamGenerator()
        {
            return this._teamGeneratorFactory.Create();
        }


        public SchedulerBase GetScheduler()
        {
            return this._scheduler;
        }
    }
}
