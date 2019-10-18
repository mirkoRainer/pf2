namespace PF2.Core.Rules
{
    public interface IBonus
    {
        string Type { get; }
        int Amount { get; }
    }
}