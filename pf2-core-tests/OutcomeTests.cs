using NUnit.Framework;
using PF2.Core.Rules;

namespace PF2.Tests
{
    [TestFixture]
    public class OutcomeTests
    {
        [SetUp]
        public void Setup()
        {
            int difficultyClass = 14;
        }
        [Test]
        [TestCase(24, 2, "Critical Success")]
        [TestCase(25, 10, "Critical Success")]
        [TestCase(25, 1, "Success")] // a 1 on the die lessens the degree of success/failure by one
        public void Check_Result_More_Than_Ten_Over_DC(int checkTotal, int dieValue, string outcome)
        {
            CheckOutcome testOutcome = new CheckOutcome();
        }
        [Test]
        public void Check_Result_At_Or_Over_DC()
        {

        }
        [Test]
        public void Check_Result_Under_DC()
        {

        }
        public void Check_Result_Under_DC_By_Ten_Or_More()
        {

        }
    }
}