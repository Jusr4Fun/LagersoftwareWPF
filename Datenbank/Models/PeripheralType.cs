using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenbank.Models
{
    public class PeripheralType
    {
        public int PeripheralTypeID { get; set; }
        public string PeripheralTypeName { get; set; } = null!;

        public ICollection<Peripheral> Peripheral { get; set; } = null!;
    }
}
