using System;
using System.Collections.Generic;

namespace Datenbank.Service;

public class Filter
{
    public List<string> FilterArguments { get; set; } = new List<string>();
    public object? TypeFilter { get; set; }

    public void ChangeFilterArguments(string suche)
    {
        FilterArguments.Clear();
        var argumente = suche.Split(' ');

        foreach (var arg in argumente)
        {
            FilterArguments.Add(arg.ToLower());
        }
    }

    public void ChangeTypeFilter(object? type)
    {
        TypeFilter = type;
    }

    public void ClearFilters()
    {
        FilterArguments.Clear();
    }

    public string[] returnFilterArgsArray()
    {
        return FilterArguments.ToArray();
    }
}
