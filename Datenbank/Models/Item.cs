namespace Datenbank.Models;

public abstract class Item
{
    public int ID { get; set; }
    public string Name { get; set; } = null!;
    public string Label { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int Amount { get; set; }

    public int LocationID { get; set; }
    public Location Location { get; set; } = null!;
}
