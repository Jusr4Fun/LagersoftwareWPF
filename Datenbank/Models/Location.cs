using System.Collections.Generic;

namespace Datenbank.Models;

public class Location
{
    public int LocationID { get; set; }

    public string LocationName { get; set; }

    public ICollection<Item> Item { get; set; }
}