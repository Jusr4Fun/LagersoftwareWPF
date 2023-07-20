using Datenbank.Models;
using Datenbank.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenbank.Services
{
    public class PCDataService : IPCDataService
    {
        private LagerverwaltungDBContext _dbContext;

        public List<PC> PCList { get; set; }
        public PCDataService(LagerverwaltungDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(string name, string label, string beschreibung, int anzahl, Location lagerort, string seriennummer, Manufacturer herrsteller, string installedkey)
        {
            var pc = new PC()
            {
                Name = name,
                Label = label,
                Description = beschreibung,
                Amount = anzahl,
                Location = lagerort,
                SerialNumber = seriennummer,
                Manufacturer = herrsteller,
                InstalledKey = installedkey
            };
            _dbContext.Item.Add(pc);
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
            PCList = _dbContext.PC.ToList();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
