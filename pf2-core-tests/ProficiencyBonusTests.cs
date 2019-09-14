
using NUnit.Framework;
using PF2.Core.Rules;

namespace PF2.Tests
{
    public class ProficiencyBonusTests
    {
        int level;
        Proficiency proficiency;

        [SetUp]
        public void Setup() 
        {
            level = 5;
        }

        [Test]
        public void UntrainedLevelFive_ReturnsFive()
        {
            //arrange
            Setup();
            //act
            proficiency = Proficiency.Untrained;
            ProficiencyBonus bonus = new ProficiencyBonus(level, proficiency);
            //assert
            Assert.AreEqual(5, bonus.Amount);
        }
    }
}