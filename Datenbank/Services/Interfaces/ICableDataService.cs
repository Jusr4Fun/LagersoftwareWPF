using Datenbank.Models;
using System.Collections.Generic;

namespace Datenbank.Services
{
    public interface ICableDataService
    {
        List<Cable> CableList { get; }

        void Create(string name, string label, string despriction, int amount, Location location, double length, CableType cableType);
        void Delete();
        void Get();
        void GetAll();
        void Update();
    }
}