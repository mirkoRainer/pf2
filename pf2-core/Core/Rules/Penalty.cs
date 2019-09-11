namespace PF2.Core.Rules
{
    public class Penalty
    {
        public string Type { get; set; }
        private int amount;
        public int Amount
        {
            get { return amount; }
            set 
            { 
                if (value > 0) 
                {
                    amount = 0;
                }
                else 
                {
                    amount = value; 
                }
            }
        }
    }
}