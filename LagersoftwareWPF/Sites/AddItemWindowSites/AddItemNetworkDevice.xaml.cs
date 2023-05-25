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
using Microsoft.VisualBasic;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace LagersoftwareWPF.Sites.AddItemWindowSites;

/// <summary>
/// Interaktionslogik für AddItemNetworkDevice.xaml
/// </summary>
public partial class AddItemNetworkDevice : Page
{
    private LagerverwaltungDBContext _dbContext;
    private NetworkDeviceDataService _networkdeviceDataService;
    public AddItemNetworkDevice()
    {
        InitializeComponent();
        _dbContext = new LagerverwaltungDBContext();
        _networkdeviceDataService = new NetworkDeviceDataService(_dbContext);
        GetAllRequiredData();
    }

    private void GetAllRequiredData()
    {
        var networkdevicetype = new NetworkDeviceTypeDataService(_dbContext);
        networkdevicetype.GetAll();
        Netzwerkgeätetyp.ItemsSource = networkdevicetype.NetworkDeviceTypeList;
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
            _networkdeviceDataService.Create(Name.Text,
                                         Label.Text,
                                         Beschreibung.Text,
                                         Convert.ToInt32(Anzahl.Text),
                                         (Location)Lagerort.SelectedItem,
                                         Seriennummer.Text,
                                         (Manufacturer)Herrsteller.SelectedItem,
                                         MacAdress.Text,
                                         (NetworkDeviceType)Netzwerkgeätetyp.SelectedItem
                                         );
            MessageBox.Show("Neues Netzwerk Gerät Erfolgreich angelegt");
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
