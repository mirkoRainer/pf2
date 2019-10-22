namespace PF2.Core.Rules.Creature.PlayerCharacter
{
    public interface IPcClass
    {
        string Name { get; set; }
        int HitPoints { get; set; }
        IPcFeat[] ClassFeats { get; set; }
    }
}