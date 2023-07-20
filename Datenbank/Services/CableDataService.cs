using Datenbank.Models;
using Datenbank.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenbank.Services;

public class CableDataService : ICableDataService
{
    private readonly LagerverwaltungDBContext _dbcontext;

    public List<Cable> CableList { get; private set; }
    public CableDataService(LagerverwaltungDBContext dBContext)
    {
        _dbcontext = dBContext;
    }

    public void Create(string name, string label, string despriction, int amount, Location location, double length, CableType cableType)
    {
        var cable = new Cable()
        {
            Name = name,
            Label = label,
            Description = despriction,
            Amount = amount,
            Location = location,
            Length = length,
            CableType = cableType
        };
        _dbcontext.Item.Add(cable);
        _dbcontext.SaveChanges();
        //_dbcontext.ChangeTracker.Clear();
    }

    public void Get()
    {
        throw new NotImplementedException();
    }

    public void GetAll()
    {
        CableList = _dbcontext.Cable.ToList();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

}
