namespace RealWorld.Bootstrapper
{
    using RealWorld.IPL.MatchScheduler;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public sealed class RealWorldInternalConfiguration
    {
        public static Func<RealWorldInternalConfiguration> Default
        {
            get
            {
                return () => new RealWorldInternalConfiguration
                {
                    SchedulerFactory = typeof(DefaultSchedulerFactory),
                    TeamGeneratorFactory = typeof(DefaultTeamGeneratorFactory),
                    MatchGeneratorFactory = typeof(DefaultMatchGeneratorFactory),
                    Scheduler = typeof(DefaultScheduler),
                };
            }
        }

        public bool IsValid
        {
            get
            {
                try
                {
                    return this.GetTypeRegistrations().All(tr => tr.RegistrationType != null);
                }
                catch (ArgumentNullException)
                {
                    return false;
                }
            }
        }

        public Type SchedulerFactory { get; set; }
        public Type TeamGeneratorFactory { get; set; }
        public Type MatchGeneratorFactory { get; set; }
        public Type Scheduler { get; set; }

        public IEnumerable<TypeRegistration> GetTypeRegistrations()
        {
            return new[]
            {
                new TypeRegistration(typeof(ISchedulerFactory), this.SchedulerFactory),
                new TypeRegistration(typeof(ITeamGeneratorFactory), this.TeamGeneratorFactory),
                new TypeRegistration(typeof(IMatchGeneratorFactory), this.MatchGeneratorFactory),
                new TypeRegistration(typeof(SchedulerBase), this.Scheduler),
            };
        }
    }
}
