namespace RealWorld.IPL
{
    using RealWorld.IPL.MatchScheduler;

    public interface IIPLBootstrapper
    {
        ISchedulerFactory GetSchedulerFactory();
    }
}
