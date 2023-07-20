using Datenbank.Models;
using System.Collections.Generic;

namespace Datenbank.Services
{
    public interface IPCDataService
    {
        List<PC> PCList { get; set; }

        void Create(string name, string label, string beschreibung, int anzahl, Location lagerort, string seriennummer, Manufacturer herrsteller, string installedkey);
        void Delete();
        void Get();
        void GetAll();
        void Update();
    }
}