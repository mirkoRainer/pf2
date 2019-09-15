using System;

namespace PF2.Core.Rules
{
    public class Modifier
    {
        public Ability Type { get; private set; }
        public int Amount { get; private set; }
        public Modifier(AbilityScore abilityScore)
        {
            Type = abilityScore.Ability;
            double result = (double)(abilityScore.Score - 10) / 2;
            Amount = (int)Math.Floor(result);
        }
    }
}