namespace PF2.Core.Rules.Equipment
{
    public interface IPfEquipment
    {
        int Level { get; set; }
        Price Price { get; set; }
        int Bulk { get; set; }
    }
}