using System;
using System.Text;

namespace PF2.Core.Rules
{
    public class CheckOutcome
    {
        int difficultyClass;
        int checkTotal;
        int numberOnDie;
        bool isCritical;
        bool isSuccess;
        int criticalThreshold;

        public CheckOutcome(int difficultyClass, int checkTotal, int dieRoll, int criticalThreshold = 10)
        {
            this.checkTotal = checkTotal;
            this.difficultyClass = difficultyClass;
            this.criticalThreshold = criticalThreshold;
            numberOnDie = dieRoll;
            isCritical = false;
            isSuccess = false;
            DetermineOutcome();
        }

        private void DetermineOutcome()
        {
            isSuccess = checkTotal >= difficultyClass;
            DetermineCritical();
        }

        private void DetermineCritical()
        {
            int difference = isSuccess ? checkTotal - difficultyClass : difficultyClass - checkTotal;
            isCritical = difference >= criticalThreshold ? true : false;
            AccountFor20or1onDie();
        }

        private void AccountFor20or1onDie()
        {
            if (numberOnDie == 1) DowngradeResult();
            if (numberOnDie == 20) UpgradeResult();
        }
        private void UpgradeResult()
        {
            if (isSuccess && isCritical) return;
            if (isSuccess && isCritical == false) isCritical = true;
            if (isSuccess == false && isCritical == false) isSuccess = true;
            if (isSuccess == false && isCritical) isCritical = false;
        }

        private void DowngradeResult()
        {
            if (isSuccess && isCritical)
            { 
                isCritical = false;
                return;
            }
            if (isSuccess && isCritical == false)
            {
                isSuccess = false;
                return;
            }
            if (isSuccess == false && isCritical == false)
            {
                isCritical = true;
                return;
            }
            if (isSuccess == false && isCritical)
            {
                return;
            }
        }


        public string RetrieveOutcomeReport()
        {
            var outcome = isSuccess ? "Success" : "Failure";
            outcome = isCritical ? "Critical " + outcome : outcome;
            return outcome;
        }
    }
}