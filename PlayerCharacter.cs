using System;

using PF2.Core;
using PF2.Core.Utility;
namespace PF2.Core.Rules {

    public class PC
    { 

        // PC data
        // Basic info.
        public string PlayerName;
        public string PCName;
        public string PlayerClass;
        public int level;
        // abliity scores and mods
        public AbilityScore Strength;
        public AbilityScore Dexterity;
        public AbilityScore Constitution;
        public AbilityScore Intellgence;
        public AbilityScore Wisdom;
        public AbilityScore Charisma;

        // Defensive scores
        public class Armor_Class
        {

        }
        public class WillSave
        {

        }
        public class FortitudeSave
        {

        }
        public class ReflexSave
        {

        }
        // Offensive scores
        public class Weapon_Strike
        {

        }
        public class Weapon_damage
        {

        }
        public class Spell_DC
        {

        }
    

   
}

