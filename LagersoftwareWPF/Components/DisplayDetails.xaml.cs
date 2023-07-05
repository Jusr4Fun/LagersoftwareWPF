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

namespace LagersoftwareWPF.Components
{
    /// <summary>
    /// Interaktionslogik für DisplayDetails.xaml
    /// </summary>
    public partial class DisplayDetails : UserControl
    {
        private Display _display;
        private LagerverwaltungDBContext _dbContext;
        public DisplayDetails(Display display)
        {
            InitializeComponent();
            _display = display;
            this.DataContext = _display;
            _dbContext = new LagerverwaltungDBContext();
            GetAllRequiredData();
        }

        private void GetAllRequiredData()
        {
            var screensizedataservice = new ScreeSizeDataService(_dbContext);
            screensizedataservice.GetAll();
            Bildschirmdiagonale.ItemsSource = screensizedataservice.ScreenSizeList;
            foreach(ScreenSize screenSize in Bildschirmdiagonale.Items)
            {
                if(screenSize.ScreenSizeID == _display.ScreenSizeID)
                {
                    Bildschirmdiagonale.SelectedItem = screenSize;
                }
            }
            var locationDataService = new LocationDataService(_dbContext);
            locationDataService.GetAll();
            Lagerort.ItemsSource = locationDataService.LocationList;
            foreach (Location location in Lagerort.Items)
            {
                if (location.LocationID == _display.LocationID)
                {
                    Lagerort.SelectedItem = location;
                }
            }
            var manufacturedataservice = new ManufacturerDataService(_dbContext);
            manufacturedataservice.GetAll();
            Herrsteller.ItemsSource = manufacturedataservice.ManufacturerList;
            foreach (Manufacturer manufacturer in Herrsteller.Items)
            {
                if (manufacturer.ManufacturerID == _display.ManufacturerID)
                {
                    Herrsteller.SelectedItem = manufacturer;
                }
            }
        }
    }
}
