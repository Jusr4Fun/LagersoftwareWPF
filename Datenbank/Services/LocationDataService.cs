using Datenbank.Models;
using Datenbank.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenbank.Services;

public class LocationDataService
{
    private readonly LagerverwaltungDBContext _dbContext;

    public List<Location> LocationList { get; private set; }

    public LocationDataService(LagerverwaltungDBContext dBContext)
    {
        _dbContext = dBContext;
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
        LocationList = _dbContext.Location.ToList();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}
