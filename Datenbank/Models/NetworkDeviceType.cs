using System.Collections.Generic;

namespace Datenbank.Models;

public class NetworkDeviceType
{
    public int NetworkDeviceTypeID { get; set; }
    public string NetworkDeviceTypeName { get; set; } = null!;

    public ICollection<NetworkDevice> NetworkDevice { get; set; } = null!;
}
