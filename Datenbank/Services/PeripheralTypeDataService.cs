using Datenbank.Models;
using Datenbank.Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenbank.Services
{
    public class PeripheralTypeDataService
    {
        private LagerverwaltungDBContext _dbContext;
        public List<PeripheralType> PeripheralTypeList { get; set; }
        public PeripheralTypeDataService(LagerverwaltungDBContext dbContext)
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
            PeripheralTypeList = _dbContext.PeripheralType.ToList();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
