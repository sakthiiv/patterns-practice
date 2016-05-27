namespace RealWorldTests.IPLTests
{
    using RealWorld.IPL.MatchScheduler;
    using RealWorld.IPL.Models;
    using System;
    using System.Collections.Generic;

    public class FakeTeamGenerator : ITeamGenerator
    {
        List<Team> ITeamGenerator.Generate()
        {
            return new List<Team>() { 
                new Team("A", new Venue("a")), 
                new Team("B", new Venue("b")),
                new Team("C", new Venue("c")), 
                new Team("D", new Venue("d")) 
            };
        }
    }
}
