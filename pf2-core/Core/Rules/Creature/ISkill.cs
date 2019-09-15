namespace PF2.Core.Rules
{
    public interface ISkill
    {
        Proficiency Proficiency { get; set; }
        AbilityScore KeyAbility { get; set; }
    }
}