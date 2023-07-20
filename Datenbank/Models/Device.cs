namespace Datenbank.Models;

public abstract class Device : Item
{
    public string SerialNumber { get; set; } = null!;
    public int ManufacturerID { get; set; }
    public Manufacturer Manufacturer { get; set; } = null!;
}
