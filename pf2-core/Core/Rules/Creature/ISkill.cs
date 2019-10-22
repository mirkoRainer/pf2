namespace PF2.Core.Rules.Creature
{
    public interface ISkill
    {
        Proficiency Proficiency { get; set; }
        AbilityScore KeyAbility { get; set; }
    }
}