using Datenbank;
using Datenbank.Models;
using Datenbank.Services;
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

namespace LagersoftwareWPF.Sites.AddItemWindowSites;

/// <summary>
/// Interaktionslogik für AddItemStorageDevice.xaml
/// </summary>
public partial class AddItemStorageDevice : Page
{
    private protected LagerverwaltungDBContext _dbContext;
    private protected StorageDeviceDataService _storagedeviceDataService;
    public AddItemStorageDevice()
    {
        InitializeComponent();
        _dbContext = new LagerverwaltungDBContext();
        _storagedeviceDataService = new StorageDeviceDataService(_dbContext);
        GetAllRequiredData();
    }

    private void GetAllRequiredData()
    {
        var formfactordataservice = new FormFactorDataService(_dbContext);
        formfactordataservice.GetAll();
        Formfactor.ItemsSource = formfactordataservice.FormFactorList;
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
            _storagedeviceDataService.Create(Name.Text,
                                             Label.Text,
                                             Beschreibung.Text,
                                             Convert.ToInt32(Anzahl.Text),
                                             (Location)Lagerort.SelectedItem,
                                             Seriennummer.Text,
                                             (Manufacturer)Herrsteller.SelectedItem,
                                             Convert.ToDouble(Kapazitaet.Text),
                                             (FormFactor)Formfactor.SelectedItem
                                         );
            MessageBox.Show("Neues Speicher Gerät Erfolgreich angelegt");
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
