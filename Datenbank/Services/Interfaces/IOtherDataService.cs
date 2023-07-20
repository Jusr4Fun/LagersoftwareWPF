using Datenbank.Models;
using System.Collections.Generic;

namespace Datenbank.Services
{
    public interface IOtherDataService
    {
        List<Other> OtherList { get; set; }

        void Create(string name, string label, string beschreibung, int anzahl, Location lagerort, string detailbeschreibung);
        void Delete();
        void Get();
        void GetAll();
        void Update();
    }
}