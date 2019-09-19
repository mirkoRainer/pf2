using System;

namespace PF2.Core.Rules
{
    public class CheckOutcome
    {
        int difficultyClass;
        int checkTotal;
        int dieValue;
        bool isCritical;
        bool isSuccess;
        int criticalThreshold = 10;

        public CheckOutcome(int dc, int total, int dieRoll)
        {
            checkTotal = total;
            difficultyClass = dc;
            dieValue = dieRoll;
            isCritical = false;
            isSuccess = false;
            DetermineOutcome();
        }

        private void DetermineOutcome()
        {
            int checkDCDifference = checkTotal - difficultyClass;

        }

        public string RetrieveOutcomeReport()
        {
            return "";
        }
    }
}