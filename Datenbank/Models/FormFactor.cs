using System.Collections.Generic;

namespace Datenbank.Models;

public class FormFactor
{
    public int FormFactorID { get; set; }
    public string FormFactorName { get; set;}

    public ICollection<StorageDevice> StorageDevice { get; set; }
}
