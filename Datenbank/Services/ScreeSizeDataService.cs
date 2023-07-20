using Datenbank.Models;
using Datenbank.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenbank.Services
{
    public class ScreeSizeDataService : IScreeSizeDataService
    {
        private LagerverwaltungDBContext _dbContext;
        public List<ScreenSize> ScreenSizeList { get; private set; }

        public ScreeSizeDataService(LagerverwaltungDBContext dbContext)
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
            ScreenSizeList = _dbContext.ScreenSize.ToList();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
