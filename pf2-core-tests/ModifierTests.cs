using NUnit.Framework;
using PF2.Core.Rules;

namespace PF2.Tests
{
    [TestFixture]
    public class ModifierTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, -5)]
        [TestCase(2, -4)]
        [TestCase(3, -4)]
        [TestCase(4, -3)]
        [TestCase(5, -3)]
        [TestCase(6, -2)]
        [TestCase(7, -2)]
        [TestCase(8, -1)]
        [TestCase(9, -1)]
        [TestCase(10, 0)]
        [TestCase(11, 0)]
        [TestCase(12, 1)]
        [TestCase(13, 1)]
        [TestCase(14, 2)]
        [TestCase(15, 2)]
        [TestCase(16, 3)]
        [TestCase(17, 3)]
        [TestCase(18, 4)]
        [TestCase(19, 4)]
        [TestCase(20, 5)]
        public void AbilityScores_HaveAppropriateModifier(int score, int expectedModifier)
        {
            AbilityScore abilityScore = new AbilityScore(score, Ability.Strength);
            AbilityModifier modifier = new AbilityModifier(abilityScore);
            Assert.AreEqual(modifier.Amount, expectedModifier);
        }
    }
}