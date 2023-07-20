using System.Collections.Generic;

namespace Datenbank.Models;

public class CableType
{
    public int CableTypeID { get; set; }
    public string CableTypeName { get; set; } = null!;

    public ICollection<Cable> Cable { get; set; } = null!;
}
