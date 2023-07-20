using Datenbank.Models;
using System.Collections.Generic;

namespace Datenbank.Services
{
    public interface IFormFactorDataService
    {
        List<FormFactor> FormFactorList { get; }

        void Create();
        void Delete();
        void Get();
        void GetAll();
        void Update();
    }
}