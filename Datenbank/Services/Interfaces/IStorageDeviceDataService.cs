using Datenbank.Models;
using System.Collections.Generic;

namespace Datenbank.Services
{
    public interface IStorageDeviceDataService
    {
        List<StorageDevice> StorageDeviceList { get; set; }

        void Create(string name, string label, string beschreibung, int anzahl, Location lagerort, string seriennummer, Manufacturer herrsteller, double kapazitaet, FormFactor formfactor);
        void Delete();
        void Get();
        void GetAll();
        void Update();
    }
}