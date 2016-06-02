namespace RealWorld.IPL
{
    using RealWorld.Bootstrapper;
    using RealWorld.IPL.MatchScheduler;

    [BootStrapper]
    public class IPLBootstrapper : DefaultRealWorldBootstrapper, IIPLBootstrapper, IRealWorldEngine
    {
        public ISchedulerFactory GetSchedulerFactory()
        {
            return this.ApplicationContainer.Resolve<ISchedulerFactory>();
        }

        public override void Run()
        {
            this.GetSchedulerFactory().GetScheduler().Display();
        }
    }
}
