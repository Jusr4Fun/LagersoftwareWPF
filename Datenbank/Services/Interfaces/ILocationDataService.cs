using Datenbank.Models;
using System.Collections.Generic;

namespace Datenbank.Services
{
    public interface ILocationDataService
    {
        List<Location> LocationList { get; }

        void Create();
        void Delete();
        void Get();
        void GetAll();
        void Update();
    }
}