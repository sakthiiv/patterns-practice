namespace RealWorld.IPL.MatchScheduler
{
    public class DefaultMatchGeneratorFactory : IMatchGeneratorFactory
    {
        public IMatchGenerator Create()
        {
            return new DefaultMatchGenerator();
        }
    }
}
