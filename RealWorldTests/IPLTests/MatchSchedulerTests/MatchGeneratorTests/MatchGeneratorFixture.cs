namespace RealWorldTests.IPLTests.MatchSchedulerTests
{
    using System;
    using System.Collections.Generic;
    using Xunit;
    using FakeItEasy;
    using RealWorld.IPL.MatchScheduler;
    using RealWorld.IPL.Models;
    using RealWorld.IPL;

    public class MatchGeneratorFixture
    {
        private readonly IMatchGenerator _matchGenerator;
        private readonly ITeamGenerator _teamGenerator;
        private readonly ITeamGenerator _fakeTeamGenerator;

        public MatchGeneratorFixture()
        {
            this._matchGenerator = new DefaultMatchGenerator();
            this._teamGenerator = new DefaultTeamGenerator();
            this._fakeTeamGenerator = new FakeTeamGenerator();
        }

        [Fact]
        public void Should_Throw_With_Null_TeamGenerator_Passed()
        {
            var result = Record.Exception(() => this._matchGenerator.GenerateMatch((ITeamGenerator)null));
            Assert.IsAssignableFrom(typeof(ArgumentNullException), result);
        }

        [Fact]
        public void Should_Throw_With_Null_TeamGenerator_Team_Passed()
        {
            var teams = A.Fake<ITeamGenerator>();
            A.CallTo(() => teams.Generate()).Returns(null);
            Assert.IsAssignableFrom(typeof(ArgumentNullException), Record.Exception(() => this._matchGenerator.GenerateMatch(teams)));
        }

        [Fact]
        public void Should_Return_Number_Of_Matches_Scheduled()
        {
            var teams = A.Fake<ITeamGenerator>();
            A.CallTo(() => teams.Generate()).Returns(this._fakeTeamGenerator.Generate());
            Assert.True(this._matchGenerator.GenerateMatch(teams).Count == (teams.Generate().Count * (teams.Generate().Count - 1)));
        }

        [Fact]
        public void Should_Return_Number_Of_Matches_For_A_Team()
        {
            var teams = A.Fake<ITeamGenerator>();
            A.CallTo(() => teams.Generate()).Returns(this._fakeTeamGenerator.Generate());
            var results = this._matchGenerator.GenerateMatch(teams);
            int idx = 0;
            foreach (var match in results)
            {
                if (match.TeamA.Name == "A")
                    idx++;
            }
            Assert.True(idx == (teams.Generate().Count - 1));
        }
    }
}
