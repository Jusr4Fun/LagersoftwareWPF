using Datenbank.Models;
using System.Collections.Generic;

namespace Datenbank.Services
{
    public interface IManufacturerDataService
    {
        List<Manufacturer> ManufacturerList { get; }

        void Create();
        void Delete();
        void Get();
        void GetAll();
        void Update();
    }
}