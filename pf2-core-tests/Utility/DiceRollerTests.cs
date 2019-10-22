using NUnit.Framework;
using PF2.Core.Utility;

namespace PF2.Tests.Utility
{
    public class DiceRollerTests
    {
        private MultiDiceRoller diceRoller;
        private Die[] diceExpected;

        [SetUp]
        public void Setup()
        {
            string dice = "2d20 1d6 4d4";
            diceExpected = new Die[7];
            diceExpected[0] = new Die(20);
            diceExpected[0] = new Die(20);
            diceExpected[0] = new Die(6);
            diceExpected[0] = new Die(4);
            diceExpected[0] = new Die(4);
            diceExpected[0] = new Die(4);
            diceExpected[0] = new Die(4);
            diceRoller = new MultiDiceRoller(dice);
        }

        [Test]
        public void DiceRollerParseString_CreatesArrayOfDie()
        {
            //arrange
            Setup();
            //act
            Die[] diceActual = diceRoller.Dice;
            //assert
            Assert.IsInstanceOf(diceExpected.GetType(), diceActual);
        }
    }
}