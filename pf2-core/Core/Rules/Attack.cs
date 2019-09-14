using System.Collections.Generic;
using PF2.Core.Utility;

namespace PF2.Core.Rules {
    // Core Rulebook pg12
    public class Attack {
        public ICreature Attacker { get; set; }
        public IPfObject Target { get; set; }
        public List<Trait> Traits { get; set; }
        public Die D20 { get; set; }
        public Die[] DamageDice { get; set; }
        public Modifier AbilityModifier { get; set; }
        public Bonus ProficiencyBonus { get; set; }
    }
}