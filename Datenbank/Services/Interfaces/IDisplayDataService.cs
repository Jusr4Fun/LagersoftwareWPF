using Datenbank.Models;
using System.Collections.Generic;

namespace Datenbank.Services
{
    public interface IDisplayDataService
    {
        List<Display> DisplayList { get; }

        void Create(string name, string label, string beschreibung, int anzahl, Location location, string seriennummer, ScreenSize screensize, Manufacturer manufacturer);
        void Delete();
        void Get();
        void GetAll();
        void Update();
    }
}