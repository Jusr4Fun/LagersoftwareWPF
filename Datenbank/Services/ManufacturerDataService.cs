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
    public class ManufacturerDataService
    {
        private LagerverwaltungDBContext _dbContext;

        public List<Manufacturer> ManufacturerList { get; private set; }
        public ManufacturerDataService(LagerverwaltungDBContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public void Create()
        {
            throw new NotImplementedException();
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
            ManufacturerList = _dbContext.Manufacturer.ToList();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
