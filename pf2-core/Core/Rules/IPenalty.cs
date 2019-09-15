namespace PF2.Core.Rules
{
    public  interface IPenalty
    {
        string Type { get; set; }
        int Amount{ get; set; }
    }
}