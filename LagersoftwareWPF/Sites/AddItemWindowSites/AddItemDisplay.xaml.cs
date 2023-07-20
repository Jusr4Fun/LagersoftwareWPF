using Datenbank;
using Datenbank.Models;
using Datenbank.Services;
using System;
using System.Windows;
using System.Windows.Controls;

namespace LagersoftwareWPF.Sites.AddItemWindowSites;

/// <summary>
/// Interaktionslogik für AddItemDisplay.xaml
/// </summary>
public partial class AddItemDisplay : Page
{
    private protected LagerverwaltungDBContext _dbContext;
    private protected DisplayDataService _displayDataService;
    public AddItemDisplay()
    {
        InitializeComponent();
        _dbContext = new LagerverwaltungDBContext();
        _displayDataService = new DisplayDataService(_dbContext);
        GetAllRequiredData();
    }

    private void GetAllRequiredData()
    {
        var screensizedataservice = new ScreeSizeDataService(_dbContext);
        screensizedataservice.GetAll();
        Bildschirmdiagonale.ItemsSource = screensizedataservice.ScreenSizeList;
        var locationDataService = new LocationDataService(_dbContext);
        locationDataService.GetAll();
        Lagerort.ItemsSource = locationDataService.LocationList;
        var manufacturedataservice = new ManufacturerDataService(_dbContext);
        manufacturedataservice.GetAll();
        Herrsteller.ItemsSource = manufacturedataservice.ManufacturerList;
    }

    private void SaveNew_Click(object sender, RoutedEventArgs e)
    {
        string name = Benennung.Text;
        string label = Label.Text;
        string beschreibung = Beschreibung.Text;
        int anzahl = Convert.ToInt32(Anzahl.Text);
        Location location = (Location)Lagerort.SelectedItem;
        string seriennummer = Seriennummer.Text;
        ScreenSize screensize = (ScreenSize)Bildschirmdiagonale.SelectedItem;
        Manufacturer manufacturer = (Manufacturer)Herrsteller.SelectedItem;
        try
        {
            _displayDataService.Create(name, label, beschreibung, anzahl, location, seriennummer, screensize, manufacturer);
            MessageBox.Show("Neuer Bildschirm Erfolgreich angelegt");
            this.NavigationService.GoBack();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Bitte überprüfen sie ihre Eingaben" + ex.Message);
        }
    }

    private void Back_Click(object sender, RoutedEventArgs e)
    {
        this.NavigationService.GoBack();
    }
}
