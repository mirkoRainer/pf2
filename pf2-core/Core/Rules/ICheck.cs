using PF2.Core.Utility;

namespace PF2.Core.Rules
{
    interface ICheck
    {
        // 1. Roll a d20
        // 2. identify modifiers, bonuses, and penalties
        // 3. compare result to DC
        // 4. determine degree of success/failure
        Bonus[] Bonuses { get; set; }
        Die Die { get; set; }
        int DifficultyClass { get; set; }
        Modifier[] Modifiers { get; set; }
        IOutcome Outcome { get; set; } // critical success, success, failure, critical failure
        Penalty[] Penalties { get; set; }

    }
}