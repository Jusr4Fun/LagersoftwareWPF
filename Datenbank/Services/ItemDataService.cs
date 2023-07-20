using Datenbank.Models;
using Datenbank.Service;
using Datenbank.Services.Interfaces;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Datenbank.Services;

public class ItemDataService : IItemDataService ,INotifyPropertyChanged
{
    private readonly LagerverwaltungDBContext _dbContext;
    private ObservableCollection<Item>? _items;
    public readonly Filter Filter;

    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); }

    public ObservableCollection<Item> Items { get 
        { 
            // unschöner fix falls _items null ist
            _items ??= new ObservableCollection<Item>();
            return _items;
        } 
        private set
        {
            if (_items == value) return;

            _items = value;
            OnPropertyChanged();
        } 
    }

    public ItemDataService(LagerverwaltungDBContext dbContext, Filter filter)
    {
        _dbContext = dbContext;
        Filter = filter;
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
        Items = new ObservableCollection<Item>(SearchItems(Filter.returnFilterArgsArray()).ToList());
    }

    public void Update()
    {
        throw new NotImplementedException();
    }

    IQueryable<Item> SearchItems(params string[] keywords)
    {
        IQueryable<Item> query = _dbContext.Item;

        foreach (string keyword in keywords)
        {
            string temp = keyword;
            query = query.Where(p => p.Name.Contains(temp)
                                  || p.Label.Contains(temp)
                                  || p.Amount.Equals(temp)
                                  || p.Description.Contains(temp)
                                  || p.Location.LocationName.Contains(temp)
                                     );
        }
        return query;
    }
}
