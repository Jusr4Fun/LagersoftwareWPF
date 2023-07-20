using Datenbank.Models;
using System.Collections.Generic;

namespace Datenbank.Services
{
    public interface INetworkDeviceDataService
    {
        List<NetworkDevice> NetworkDeviceList { get; }

        void Create(string name, string label, string beschreibung, int anzahl, Location location, string seriennummer, Manufacturer herrsteller, string macadresse, NetworkDeviceType netzwerkgerätetyp);
        void Delete();
        void Get();
        void GetAll();
        void Update();
    }
}