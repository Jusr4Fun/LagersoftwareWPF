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
    /// Interaktionslogik für AddItemPeripheral.xaml
    /// </summary>
public partial class AddItemPeripheral : Page
{
    private protected LagerverwaltungDBContext _dbContext;
    private protected PeripheralDataService _peripheralDataService;
    public AddItemPeripheral()
    {
        InitializeComponent();
        _dbContext = new LagerverwaltungDBContext();
        _peripheralDataService = new PeripheralDataService(_dbContext);
        GetAllRequiredData();
    }

    private void GetAllRequiredData()
    {
        var locationDataService = new LocationDataService(_dbContext);
        locationDataService.GetAll();
        Lagerort.ItemsSource = locationDataService.LocationList;
        var peripheraltypeDataService = new PeripheralTypeDataService(_dbContext);
        peripheraltypeDataService.GetAll();
        PeriherieTyp.ItemsSource = peripheraltypeDataService.PeripheralTypeList;
    }

    private void SaveNew_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            _peripheralDataService.Create(Benennung.Text,
                                          Label.Text,
                                          Beschreibung.Text,
                                          Convert.ToInt32(Anzahl.Text),
                                          (Location)Lagerort.SelectedItem,
                                          (PeripheralType)PeriherieTyp.SelectedItem
                                         );
            MessageBox.Show("Neues Peripherie Gerät Erfolgreich angelegt");
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

