using Datenbank.Models;
using System.Collections.Generic;

namespace Datenbank.Services
{
    public interface IScreeSizeDataService
    {
        List<ScreenSize> ScreenSizeList { get; }

        void Create();
        void Delete();
        void Get();
        void GetAll();
        void Update();
    }
}