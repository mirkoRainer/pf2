namespace PF2.Core.Rules
{
    public class ProficiencyBonus : IBonus
    {
        public int Amount { get; }
        public string Type { get; }
        public ProficiencyBonus (int level, Proficiency proficiency)
        {
            Type = Bonustype.Proficiency.ToString("g");
            Amount = level + (int) proficiency;
        }
    }
}