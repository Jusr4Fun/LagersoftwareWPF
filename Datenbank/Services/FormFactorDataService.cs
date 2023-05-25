using Datenbank.Models;
using Datenbank.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenbank.Services
{
    public class FormFactorDataService
    {
        private LagerverwaltungDBContext _dbContext;
        public List<FormFactor> FormFactorList { get; private set; }
        public FormFactorDataService(LagerverwaltungDBContext dbContext)
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
            FormFactorList = _dbContext.FormFactor.ToList();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
