namespace PF2.Core.Rules
{
    public interface IBackground
    {
        AbilityScoreBoost[] AbilityBoosts { get; set; }
        IFeat SkillFeat { get; set; }
        ISkill TrainedSkill { get; set; } // one should be Lore
        ISkill TrainedLoreSkill { get; set; }
    }
}