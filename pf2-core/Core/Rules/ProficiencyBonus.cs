namespace PF2.Core.Rules
{
    public class ProficiencyBonus
    {
        public int Amount { get; }
        public ProficiencyBonus (int level, Proficiency proficiency)
        {
            Amount = level + (int) proficiency;
        }
    }
}