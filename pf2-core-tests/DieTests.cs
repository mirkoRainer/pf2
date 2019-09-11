using NUnit.Framework;
using PF2.Core;

namespace PF2.Tests
{
    public class DieTests
    {
        [Test]
        public void DieRollIsInRangeOneToMaxValue()
        {
            //arrange
            int maxValue = 20;
            Die die = new Die(maxValue);
            //act
            int result = die.Roll();
            bool passed = false;
            for (int i = 1; i <= 20; i++)
            {
                passed = (result == i);
                if (passed) break;
            }
            //assert
            Assert.IsTrue(passed, "The Die result was not in range 1-20.");
        }
    }
}