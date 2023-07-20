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

namespace LagersoftwareWPF.Sites.AddItemWindowSites
{
    /// <summary>
    /// Interaktionslogik für AddItemCable.xaml
    /// </summary>
    public partial class AddItemCable : Page
    {
        private protected LagerverwaltungDBContext _dbContext;
        private protected CableDataService _cableDataService;
        public AddItemCable()
        {
            InitializeComponent();
            _dbContext = new LagerverwaltungDBContext();
            _cableDataService = new CableDataService(_dbContext);
            GetAllRequiredData();
        }

        private void GetAllRequiredData()
        {
            var cabletypedataservice = new CableTypeDataService(_dbContext);
            cabletypedataservice.GetAll();
            CableType.ItemsSource = cabletypedataservice.CableTypeList;
            var locationDataService = new LocationDataService(_dbContext);
            locationDataService.GetAll();
            Location.ItemsSource = locationDataService.LocationList;
        }

        private void SaveNew_Click(object sender, RoutedEventArgs e)
        {
            string name = Benennung.Text;
            string label = Label.Text;
            string beschreibung = Beschreibung.Text;
            int anzahl = Convert.ToInt32(Anzahl.Text);
            Location location = (Location)Location.SelectedItem;
            double laenge = Convert.ToDouble(Laenge.Text);
            CableType cableType = (CableType)CableType.SelectedItem;
            try { 
                _cableDataService.Create(name, label, beschreibung, anzahl, location, laenge, cableType);
                MessageBox.Show("Neues Kabel Erfolgreich angelegt");
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
}
