using NUnit.Framework;
using PF2.Core.Rules;

namespace PF2.Tests.Rules
{
    [TestFixture]
    public class PriceTests
    {
        [Test]
        [TestCase(5, 0, 0, 0, "5 cp")]
        [TestCase(0, 8, 0, 0, "8 sp")]
        [TestCase(0, 0, 900, 0, "900 gp")]
        [TestCase(0, 0, 0, 20, "20 pp")]
        [TestCase(0, 0, 0, 0, "Free")]
        public void TestPriceDisplay(int Copper, int Silver, int Gold, int Platinum, string ExpectedDisplay)
        {
            var testPrice = new Price(Copper, Silver, Gold, Platinum);
            Assert.That(testPrice.GetDisplayPrice, Is.EqualTo(ExpectedDisplay));
        }
    }
}