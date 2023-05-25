using Datenbank.Models;
using Datenbank.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenbank.Services
{
    public class NetworkDeviceDataService
    {
        private LagerverwaltungDBContext _dbContext;

        public List<NetworkDevice> NetworkDeviceList { get; private set; }
        public NetworkDeviceDataService(LagerverwaltungDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public void Create(string name, string label, string beschreibung, int anzahl, Location location, string seriennummer, Manufacturer herrsteller, string macadresse, NetworkDeviceType netzwerkgerätetyp)
        {
            var networkdevice = new NetworkDevice()
            {
                Name = name,
                Label = label,
                Description = beschreibung,
                Amount = anzahl,
                Location = location,
                SerialNumber = seriennummer,
                Manufacturer = herrsteller,
                MacAdress = macadresse,
                NetworkDeviceType = netzwerkgerätetyp
            };
            _dbContext.Add(networkdevice);
            _dbContext.SaveChanges();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            NetworkDeviceList = _dbContext.NetworkDevice.ToList();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
