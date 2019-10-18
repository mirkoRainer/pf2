namespace PF2.Core.Rules
{
    public interface IAdventurerClass
    {
        string Name { get; set; }
        int HitPoints { get; set; }
        IFeat[] ClassFeats { get; set; }
    }
}