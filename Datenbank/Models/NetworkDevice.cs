namespace Datenbank.Models;

public class NetworkDevice :Device
{
    public string MacAdress { get; set; }
    
    public int NetworkDeviceTypeID { get; set; }
    public NetworkDeviceType NetworkDeviceType { get; set; }
}
