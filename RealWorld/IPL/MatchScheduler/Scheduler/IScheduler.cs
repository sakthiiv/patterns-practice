namespace RealWorld.IPL.MatchScheduler
{
    interface IScheduler
    {        
        void Generate(IMatchGenerator match, ITeamGenerator team);
    }
}
