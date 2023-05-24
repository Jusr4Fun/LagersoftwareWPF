using System.Collections.Generic;

namespace Datenbank.Models;

public class CableType
{
    public int CableTypeID { get; set; }
    public string CableTypeName { get; set; }

    public ICollection<Cable> Cable { get; set; }
}
