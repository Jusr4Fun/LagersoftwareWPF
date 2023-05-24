using System.Collections.Generic;

namespace Datenbank.Models;

public class NetworkDeviceType
{
    public int NetworkDeviceTypeID { get; set; }
    public string NetworkDeviceTypeName { get; set;}

    public ICollection<NetworkDevice> NetworkDevice { get; set; }
}
