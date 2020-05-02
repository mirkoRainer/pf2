namespace PF2.Core.Rules.Equipment
{
    public interface IEquipment
    {
        int Level { get; set; }
        Price Price { get; set; }
        Bulk Bulk { get; set; }
    }
}