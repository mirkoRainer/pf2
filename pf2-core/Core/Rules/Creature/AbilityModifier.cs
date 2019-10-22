using System;

namespace PF2.Core.Rules.Creature
{
    public class AbilityModifier
    {
        public Ability Type { get; private set; }
        public int Amount { get; private set; }

        public AbilityModifier(AbilityScore abilityScore)
        {
            Type = abilityScore.Ability;
            double result = (double)(abilityScore.Score - 10) / 2;
            Amount = (int)Math.Floor(result);
        }
    }
}