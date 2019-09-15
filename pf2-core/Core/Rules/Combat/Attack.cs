using System.Collections.Generic;
using PF2.Core.Utility;

namespace PF2.Core.Rules {
    // Core Rulebook pg12
    public class Attack : ICheck {
        IPfObject Attacker { get; set; }
        IPfObject Target { get; set; }
        List<Trait> Traits { get; set; }
        IWeapon Weapon { get; set; }
        public Die Die { set => new Die(20); }
        public IBonus[] Bonuses { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int DifficultyClass { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public Modifier[] Modifiers { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public IOutcome Outcome { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public IPenalty[] Penalties { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public Attack(
            IPfObject attacker,
            IPfObject target,
            List<Trait> traits,
        )
        {
            
        }
    }
}