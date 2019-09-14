using System;
using System.Collections.Generic;

namespace PF2.Core.Utility
{
    public class MultiDiceRoller {
        public Die[] Dice { get; private set; }

        public MultiDiceRoller( string dice ) {
            Dice = ParseDiceString( dice );
        }

        private Die[] ParseDiceString( string dice ) {
            // format for dice string: "XdY XdY" x = number of dice; y = number of sides on dice
            List<Die> finalDice = new List<Die>();
            var splitDice = dice.Split( ' ' );
            foreach ( string splitDie in splitDice ) {
                var xySplit = splitDie.Split( 'd' );
                var x = int.Parse( xySplit[0] );
                var y = int.Parse( xySplit[1] );
                for ( int i = 1; i <= x; i++ ) {
                    finalDice.Add( new Die( y ) );
                }
            }
            return finalDice.ToArray();
        }
    }
}
