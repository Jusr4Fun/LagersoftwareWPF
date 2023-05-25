using Datenbank.Models;
using Datenbank.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenbank.Services
{
    public class OtherDataService
    {
        private LagerverwaltungDBContext _dbContext;

        public List<Other> OtherList { get; set; }
        public OtherDataService(LagerverwaltungDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public void Create(string name, string label, string beschreibung, int anzahl, Location lagerort, string detailbeschreibung)
        {
            var other = new Other()
            {
                Name = name,
                Label = label,
                Description = beschreibung,
                Amount = anzahl,
                Location = lagerort,
                DetailedDescription = detailbeschreibung
            };
            _dbContext.Add(other);
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
            OtherList = _dbContext.Other.ToList();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
