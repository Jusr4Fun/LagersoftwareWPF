using Datenbank.Services;
using Datenbank;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Datenbank.Models;

namespace LagersoftwareWPF.Sites.AddItemWindowSites;

/// <summary>
/// Interaktionslogik für AddItemPC.xaml
/// </summary>
public partial class AddItemPC : Page
{
    private LagerverwaltungDBContext _dbContext;
    private PCDataService _pcDataService;
    public AddItemPC()
    {
        InitializeComponent();
        _dbContext = new LagerverwaltungDBContext();
        _pcDataService = new PCDataService(_dbContext);
        GetAllRequiredData();
    }

    private void GetAllRequiredData()
    {
        var locationDataService = new LocationDataService(_dbContext);
        locationDataService.GetAll();
        Lagerort.ItemsSource = locationDataService.LocationList;
        var manufacturedataservice = new ManufacturerDataService(_dbContext);
        manufacturedataservice.GetAll();
        Herrsteller.ItemsSource = manufacturedataservice.ManufacturerList;
    }

    private void SaveNew_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            _pcDataService.Create(Name.Text,
                                  Label.Text,
                                  Beschreibung.Text,
                                  Convert.ToInt32(Anzahl.Text),
                                  (Location)Lagerort.SelectedItem,
                                  Seriennummer.Text,
                                  (Manufacturer)Herrsteller.SelectedItem,
                                  InstallierterKey.Text
                                         );
            MessageBox.Show("Neuen PC Erfolgreich angelegt");
            this.NavigationService.GoBack();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Bitte überprüfen sie ihre Eingaben");
        }
    }

    private void Back_Click(object sender, RoutedEventArgs e)
    {
        this.NavigationService.GoBack();
    }
}
