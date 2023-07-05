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
    /// Interaktionslogik für PCDetails.xaml
    /// </summary>
    public partial class PCDetails : UserControl
    {
        private PC _pc;
        private LagerverwaltungDBContext _dbContext;
        public PCDetails(PC pc)
        {
            InitializeComponent();
            _pc = pc;
            this.DataContext = _pc;
            _dbContext = new LagerverwaltungDBContext();
            GetAllRequiredData();
        }

        private void GetAllRequiredData()
        {
            var locationDataService = new LocationDataService(_dbContext);
            locationDataService.GetAll();
            Lagerort.ItemsSource = locationDataService.LocationList;
            foreach (Location location in Lagerort.Items)
            {
                if (location.LocationID == _pc.LocationID)
                {
                    Lagerort.SelectedItem = location;
                }
            }
            var manufacturedataservice = new ManufacturerDataService(_dbContext);
            manufacturedataservice.GetAll();
            Herrsteller.ItemsSource = manufacturedataservice.ManufacturerList;
            foreach (Manufacturer manufacturer in Herrsteller.Items)
            {
                if (manufacturer.ManufacturerID == _pc.ManufacturerID)
                {
                    Herrsteller.SelectedItem = manufacturer;
                }
            }
        }
    }
}
