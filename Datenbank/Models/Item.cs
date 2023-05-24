namespace Datenbank.Models;

public abstract class Item
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Label { get; set; }
    public string Description { get; set; }
    public int Count { get; set; }

    public int LocationID { get; set; }
    public Location Location { get; set; }
}
