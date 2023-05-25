using Datenbank.Models;
using Datenbank.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenbank.Services;

public class ItemDataService : IItemDataService
{
    private readonly LagerverwaltungDBContext _dbContext;

    public List<Item> Items { get; private set; }

    public ItemDataService(LagerverwaltungDBContext dbContext)
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
        Items = _dbContext.Item.ToList();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}
