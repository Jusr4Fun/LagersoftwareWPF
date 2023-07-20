using Datenbank.Models;
using Datenbank.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenbank.Services
{
    public class PeripheralDataService : IPeripheralDataService
    {
        private LagerverwaltungDBContext _dbContext;
        public List<Peripheral> PeripheralList { get; set; }
        public PeripheralDataService(LagerverwaltungDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(string name, string label, string beschreibung, int anzahl, Location lagerort, PeripheralType peripherietyp)
        {
            var peripheral = new Peripheral()
            {
                Name = name,
                Label = label,
                Description = beschreibung,
                Amount = anzahl,
                Location = lagerort,
                PeripheralType = peripherietyp
            };
            _dbContext.Item.Add(peripheral);
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
            PeripheralList = _dbContext.Peripheral.ToList();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
