using NUnit.Framework;
using PF2.Core.Rules;

namespace PF2.Tests
{
    public class ProficiencyBonusTests
    {
        private int level;
        private Proficiency proficiency;

        [SetUp]
        public void Setup()
        {
            level = 5;
        }

        [Test]
        [TestCase(Proficiency.Untrained, 5)]
        [TestCase(Proficiency.Trained, 7)]
        [TestCase(Proficiency.Expert, 9)]
        [TestCase(Proficiency.Master, 11)]
        [TestCase(Proficiency.Legendary, 13)]
        public void ProficiencyAndLevel_ReturnsAppropriateBonus(Proficiency proficiency, int expectedBonus)
        {
            //arrange
            Setup();
            //act
            ProficiencyBonus bonus = new ProficiencyBonus(level, proficiency);
            //assert
            Assert.AreEqual(expectedBonus, bonus.Amount);
        }
    }
}