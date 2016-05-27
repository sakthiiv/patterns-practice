namespace RealWorldTests.IPLTests.MatchSchedulerTests
{
    using System;
    using System.Collections.Generic;
    using RealWorld.IPL.MatchScheduler;
    using RealWorld.IPL.Models;
    using Xunit;
    using FakeItEasy;

    public class TeamGeneratorFixture
    {
        public TeamGeneratorFixture()
        {
 
        }

        [Fact]
        public void Should_Return_Team_List()
        {
            Assert.True((new DefaultTeamGenerator()).Generate().Count > 0);
        }
    }
}
