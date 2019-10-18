namespace PF2.Core.Rules
{
    internal interface IAction
    {
        ActionCost ActionCost { get; set; }
        IAction[] SubordinateActions { get; set; }
        Trait[] Traits { get; set; }
        string Trigger { get; set; }
        ICheck Check { get; set; }
        IEffect Effect { get; set; }
    }
}