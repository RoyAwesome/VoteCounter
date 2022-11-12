using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace VoteCounter
{
    [TestFixture]
    class RCVTester
    {

        [Test]
        public void TestParsing()
        {
            string[] ballots = new string[]
            {
                "Candidate 1, Candidate 2, Candidate 3",
                "Candidate 2, Candidate 3, Candidate 1",
                "Candidate 3, Candidate 2, Candidate 1",
                "Candidate 2, Candidate 1, Candidate 3",
                "Candidate 3, Candidate 2, Candidate 1",
            };

            RankedChoiceVotingTabulator tabulator = new(ballots);

            Assert.That(tabulator.Candidates, Is.EquivalentTo(new string[] { "Candidate 1".ToLower(), "Candidate 2".ToLower(), "Candidate 3".ToLower() }));
        }

        [Test]
        public void TestSingleRound()
        {
            string[] ballots = new string[]
           {
                "Candidate 1, Candidate 2, Candidate 3",
                "Candidate 2, Candidate 3, Candidate 1",
                "Candidate 3, Candidate 2, Candidate 1",
                "Candidate 2, Candidate 1, Candidate 3",
                "Candidate 3, Candidate 2, Candidate 1",
           };

            RankedChoiceVotingTabulator tabulator = new(ballots);

            RankedChoiceVotingTabulator.RCVRound round = tabulator.CalculateSingleRound(0);

            Assert.That(round.HasWinner, Is.False);
            Assert.That(round.ExhaustedBallots, Is.Zero);
            Assert.That(round.VoteCounts, Is.EqualTo(new Dictionary<string, int> { { "candidate 1", 1 }, { "candidate 2", 2 }, { "candidate 3", 2 } }));
            Assert.That(round.GetElimatedCandidate(), Is.EqualTo("candidate 1"));
        }

        [Test]
        public void TestTwoRounds()
        {
            string[] ballots = new string[]
            {
                "Candidate 1, Candidate 2, Candidate 3",
                "Candidate 2, Candidate 3, Candidate 1",
                "Candidate 3, Candidate 2, Candidate 1",
                "Candidate 2, Candidate 1, Candidate 3",
                "Candidate 3, Candidate 2, Candidate 1",
            };

            RankedChoiceVotingTabulator tabulator = new(ballots);

            var round1 = tabulator.CalculateSingleRound(0);
            var round2 = tabulator.CalculateSingleRound(1, round1);

            Assert.That(round2.HasWinner, Is.True);
            Assert.That(round2.ExhaustedBallots, Is.Zero);
            Assert.That(round2.VoteCounts, Is.EqualTo(new Dictionary<string, int> { { "candidate 2", 3 }, { "candidate 3", 2 } }));

        }

        [Test]
        public void TestAutomaticTabulator()
        {
            string[] ballots = new string[]
            {
                "Candidate 1, Candidate 2, Candidate 3",
                "Candidate 2, Candidate 3, Candidate 1",
                "Candidate 3, Candidate 2, Candidate 1",
                "Candidate 2, Candidate 1, Candidate 3",
                "Candidate 3, Candidate 2, Candidate 1",
            };

            RankedChoiceVotingTabulator tabulator = new(ballots);

            tabulator.TabulateRounds();

            Assert.That(tabulator.Rounds.Count, Is.EqualTo(2));
            var round2 = tabulator.Rounds[1];

            Assert.That(round2.HasWinner, Is.True);
            Assert.That(round2.ExhaustedBallots, Is.Zero);
            Assert.That(round2.VoteCounts, Is.EqualTo(new Dictionary<string, int> { { "candidate 2", 3 }, { "candidate 3", 2 } }));
            Assert.That(round2.Winner, Is.EqualTo("candidate 2"));

        }

        [Test]
        public void TestTie()
        {
            string[] ballots = new string[]
            {
                "Candidate 1, abstain",
                "Candidate 2, Candidate 3, Candidate 1",
                "Candidate 3, Candidate 2, Candidate 1",
                "Candidate 2, Candidate 1, Candidate 3",
                "Candidate 3, Candidate 2, Candidate 1",
            };

            RankedChoiceVotingTabulator tabulator = new(ballots);

            var round1 = tabulator.CalculateSingleRound(0);
            var round2 = tabulator.CalculateSingleRound(1, round1);

            Assert.That(round2.HasTie, Is.True);
            Assert.That(round2.ExhaustedBallots, Is.EqualTo(1));
            Assert.That(round2.VoteCounts, Is.EqualTo(new Dictionary<string, int> { { "candidate 2", 2 }, { "candidate 3", 2 } }));

        }

        [Test]
        public void TestNewFormat()
        {
            string[] Candidates = new string[]
            {
                "Candidate 1",
                "Candidate 2",
                "candidate 3"
            };

            string[] Ballots = new string[]
            {
                "First	Second	",
                "First	Third	Second",
                "Second	First	Third",
                "Second		",
                "Second		Third",
            };

            var Converted = RankedChoiceVotingTabulator.ConvertFormatTwo(Candidates, Ballots, out var InvalidBallots);


            RankedChoiceVotingTabulator tabulator = new(Converted);

            tabulator.TabulateRounds();

            Assert.That(tabulator.Rounds.Count, Is.EqualTo(1));
            var round2 = tabulator.Rounds[0];
            Assert.That(round2.HasWinner, Is.True);
            Assert.That(round2.ExhaustedBallots, Is.Zero);
        }

    }
}
