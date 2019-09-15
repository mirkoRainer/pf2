namespace PF2.Core.Rules
{
    public class CheckOutcome
    {
        int difficultyClass { get; set; }
        int checkTotal { get; set; }
        int dieValue { get; set; }
        bool isCritical { get; set; }
        bool isSuccess { get; set; }
        public CheckOutcome(int dc, int checkTotal, int dieValue)
        {
            checkResult = result;
            
        }
    }
}