using NUnit.Framework;
using PF2.Core.Rules;

namespace PF2.Tests
{
    [TestFixture]
    public class OutcomeTests
    {
        private int difficultyClass;

        [SetUp]
        public void Setup()
        {
            difficultyClass = 14;
        }

        [Test]
        [TestCase(24, 20, "Critical Success")] // a 20 on the die increases the degree of success/failure by one
        [TestCase(25, 10, "Critical Success")]
        [TestCase(25, 1, "Success")] // a 1 on the die lessens the degree of success/failure by one
        [TestCase(18, 20, "Critical Success")]
        [TestCase(14, 10, "Success")]
        [TestCase(15, 10, "Success")]
        [TestCase(15, 1, "Failure")]
        [TestCase(13, 20, "Success")]
        [TestCase(13, 10, "Failure")]
        [TestCase(12, 1, "Critical Failure")]
        [TestCase(4, 20, "Failure")]
        [TestCase(4, 10, "Critical Failure")]
        [TestCase(3, 10, "Critical Failure")]
        [TestCase(4, 1, "Critical Failure")]
        public void CheckResultYieldsAppropriateOutcome(int checkTotal, int dieValue, string expectedOutcome)
        {
            CheckOutcome outcome = new CheckOutcome(difficultyClass, checkTotal, dieValue);
            string outcomeReport = outcome.RetrieveOutcomeReport();
            Assert.That(outcomeReport, Is.EqualTo(expectedOutcome));
        }
    }
}