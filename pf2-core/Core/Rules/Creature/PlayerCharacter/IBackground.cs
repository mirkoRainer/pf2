namespace PF2.Core.Rules.Creature.PlayerCharacter
{
    public interface IBackground
    {
        AbilityScoreBoost[] AbilityBoosts { get; set; }
        IPcFeat SkillFeat { get; set; }
        ISkill TrainedSkill { get; set; } // one should be Lore
        ISkill TrainedLoreSkill { get; set; }
    }
}