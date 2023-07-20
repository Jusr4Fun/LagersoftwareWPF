using Datenbank.Models;
using System.Collections.Generic;

namespace Datenbank.Services
{
    public interface INetworkDeviceTypeDataService
    {
        List<NetworkDeviceType> NetworkDeviceTypeList { get; }

        void Create();
        void Delete();
        void Get();
        void GetAll();
        void Update();
    }
}