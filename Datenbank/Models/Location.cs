using System.Collections.Generic;

namespace Datenbank.Models;

public class Location
{
    public int LocationID { get; set; }

    public string LocationName { get; set; } = null!;

    public ICollection<Item> Item { get; set; } = null!;
}