namespace RealWorld.IPL.MatchScheduler
{
    public class DefaultTeamGeneratorFactory : ITeamGeneratorFactory
    {
        public ITeamGenerator Create()
        {
            return new DefaultTeamGenerator();
        }
    }
}
