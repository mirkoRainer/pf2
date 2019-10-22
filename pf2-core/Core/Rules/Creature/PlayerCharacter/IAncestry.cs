using System.Collections.Generic;

namespace PF2.Core.Rules.Creature.PlayerCharacter
{
    public interface IAncestry
    {
        int HitPoints { get; set; }
        Size Size { get; set; }
        int Speed { get; set; }
        AbilityScore[] AbilityBoosts { get; set; }
        AbilityScore[] AbilityFlaws { get; set; }
        List<Languages> Languages { get; set; }
        Trait[] Traits { get; set; }
        Ability[] SpecialAbilities { get; set; }
        Heritage Heritage { get; set; }
        IBackground Background { get; set; }
    }
}