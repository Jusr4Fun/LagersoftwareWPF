using Datenbank.Models;
using Datenbank.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenbank.Services
{
    public class DisplayDataService : IDisplayDataService
    {
        private LagerverwaltungDBContext _dbContext;

        public List<Display> DisplayList { get; private set; }

        public DisplayDataService(LagerverwaltungDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(string name, string label, string beschreibung, int anzahl, Location location, string seriennummer, ScreenSize screensize, Manufacturer manufacturer)
        {
            var display = new Display()
            {
                Name = name,
                Label = label,
                Description = beschreibung,
                Amount = anzahl,
                Location = location,
                SerialNumber = seriennummer,
                ScreenSize = screensize,
                Manufacturer = manufacturer
            };
            _dbContext.Item.Add(display);
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
            DisplayList = _dbContext.Display.ToList();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
