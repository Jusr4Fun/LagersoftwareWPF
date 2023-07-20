using Datenbank.Models;
using System.Collections.Generic;

namespace Datenbank.Services
{
    public interface IPeripheralTypeDataService
    {
        List<PeripheralType> PeripheralTypeList { get; set; }

        void Create();
        void Delete();
        void Get();
        void GetAll();
        void Update();
    }
}