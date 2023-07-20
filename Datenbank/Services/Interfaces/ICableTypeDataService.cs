using Datenbank.Models;
using System.Collections.Generic;

namespace Datenbank.Services
{
    public interface ICableTypeDataService
    {
        List<CableType> CableTypeList { get; }

        void Create();
        void Delete();
        void Get();
        void GetAll();
        void Update();
    }
}