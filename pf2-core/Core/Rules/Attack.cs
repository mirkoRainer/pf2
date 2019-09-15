using System.Collections.Generic;
using PF2.Core.Utility;

namespace PF2.Core.Rules {
    // Core Rulebook pg12
    public class Attack : ICheck {
        public IPfObject Attacker { get; set; }
        public IPfObject Target { get; set; }
        public List<Trait> Traits { get; set; }
        public Die D20 { get; set; }
        public Die[] DamageDice { get; set; }
        public Bonus[] Bonuses { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public Die Die { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int DifficultyClass { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public Modifier[] Modifiers { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public IOutcome Outcome { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public Penalty[] Penalties { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}