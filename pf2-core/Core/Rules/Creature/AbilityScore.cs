namespace PF2.Core.Rules
{
    public class AbilityScore
    {
        public int Score { get; private set; }
        public Ability Ability { get; private set; }

        public AbilityScore(int score,
                            Ability ability)
        {
            Score = score;
            Ability = ability;
        }
    }
}