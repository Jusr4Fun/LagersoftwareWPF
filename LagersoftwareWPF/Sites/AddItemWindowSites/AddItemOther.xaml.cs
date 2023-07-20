using Datenbank;
using Datenbank.Models;
using Datenbank.Services;
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
/// Interaktionslogik für AddItemOther.xaml
/// </summary>
public partial class AddItemOther : Page
{
    private LagerverwaltungDBContext _dbContext;
    private OtherDataService _otherDataService;
    public AddItemOther()
    {
        InitializeComponent();
        _dbContext = new LagerverwaltungDBContext();
        _otherDataService = new OtherDataService(_dbContext);
        GetAllRequiredData();
    }

    private void GetAllRequiredData()
    {
        var locationDataService = new LocationDataService(_dbContext);
        locationDataService.GetAll();
        Lagerort.ItemsSource = locationDataService.LocationList;
    }

    private void SaveNew_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            _otherDataService.Create(Name.Text,
                                     Label.Text,
                                     Beschreibung.Text,
                                     Convert.ToInt32(Anzahl.Text),
                                     (Location)Lagerort.SelectedItem,
                                     DetailBeschreibung.Text
                                     );
            MessageBox.Show("Neuer Sonstiger Gegenstand Erfolgreich angelegt");
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
