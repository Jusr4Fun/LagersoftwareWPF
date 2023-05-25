using Datenbank.Models;
using Datenbank.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenbank.Services
{
    public class StorageDeviceDataService
    {
        private LagerverwaltungDBContext _dbContext;

        public List<StorageDevice> StorageDeviceList { get; set; }
        public StorageDeviceDataService(LagerverwaltungDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(string name, string label, string beschreibung, int anzahl, Location lagerort, string seriennummer, Manufacturer herrsteller, double kapazitaet, FormFactor formfactor)
        {
            var storagedevice = new StorageDevice()
            {
                Name = name, 
                Label = label,
                Description = beschreibung,
                Amount = anzahl,
                Location = lagerort,
                SerialNumber = seriennummer,
                Manufacturer = herrsteller,
                Capacity = kapazitaet,
                FormFactor = formfactor
            };
            _dbContext.Item.Add(storagedevice);
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
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
