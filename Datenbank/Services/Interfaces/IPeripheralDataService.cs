using Datenbank.Models;
using System.Collections.Generic;

namespace Datenbank.Services
{
    public interface IPeripheralDataService
    {
        List<Peripheral> PeripheralList { get; set; }

        void Create(string name, string label, string beschreibung, int anzahl, Location lagerort, PeripheralType peripherietyp);
        void Delete();
        void Get();
        void GetAll();
        void Update();
    }
}