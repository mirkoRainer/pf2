using System;

namespace PF2.Core.Utility
{
    public class Die
    {
        public int NumberOfSides { get; private set; }

        public Die( int maxValue ) 
        {
            NumberOfSides = maxValue;
        }
            
        public int Roll() 
        {
            Random rand = new Random();
            return rand.Next( 1, NumberOfSides );
        }
    }
}