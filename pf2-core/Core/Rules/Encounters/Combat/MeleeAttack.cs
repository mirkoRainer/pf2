using PF2.Core.Rules.Creature;
using PF2.Core.Utility;
using System.Collections.Generic;

namespace PF2.Core.Rules.Encounters.Combat
{
    // Core Rulebook pg12
    public class MeleeAttack : ICheck
    {
        private List<Trait> Traits { get; set; }
        public IBonus[] Bonuses { get; set; }
        public Die Die { set => new Die(20); }
        public AbilityModifier Modifier { get; set; }
        public IPenalty[] Penalties { get; set; }
    }
}