using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenbank.Models;

public class Peripheral : Item
{
    public int PeripheralTypeID { get; set; }
    public PeripheralType PeripheralType { get; set; } = null!;
}
