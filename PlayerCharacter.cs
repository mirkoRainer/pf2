using System;
using NUnit.Framework;
using PF2.Core;
using PF2.Core.Utility;
namespace PF2.Core.Rules { 

public struct PC 
{
    // PC data
    // Basic info.
    public string Player_Name;
    public string PC_Name;
    public string Player_Class;
    public int level;
    // abliity scores and mods
    public int STR_Score;
    public int STR_Mod;
    public int Dex_Score;
    public int DEX_Mod;
    public int Con_Score;
    public int Con_Mod;
    public int Int_Score;
    public int Int_Mod;
    public int Wis_Score;
    public int Wis_mod;
    public int Con_Score;
    public int Con_mod;
    // Defensive scores
    public int Armor_Class;
    public int Will_Save;
    public int Reflex_save;
    public int Fort_Save;
    // Offensive scores
    public int Weapon_Strike;
    public int Weapon_damage;
    public int Spell_DC;
}

class Player {

    static void Main(string[] args)
        {
            PC testPlayer;
    
        testPlayer.PC_Name = "Yanna";
        testPlayer.Player_Class = "Fighter";
        testPlayer.level = 2;


        Console.WriteLine(testPlayer.Name + "is a level " + testPlayer.level + " " + testPlayer.level);
        }
}                   
}
