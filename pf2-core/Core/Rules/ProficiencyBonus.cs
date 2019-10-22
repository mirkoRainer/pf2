namespace PF2.Core.Rules
{
    public class ProficiencyBonus : IBonus
    {
        #region IBonus
        public int Amount { get; }
        public string Type { get; }
        #endregion

        public ProficiencyBonus(int level, Proficiency proficiency)
        {
            Type = Bonustype.Proficiency.ToString("g");
            Amount = proficiency != Proficiency.Untrained 
                ? level + (int)proficiency 
                : 0;
        }
    }
}