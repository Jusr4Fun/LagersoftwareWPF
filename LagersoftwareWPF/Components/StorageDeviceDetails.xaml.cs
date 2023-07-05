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
    /// Interaktionslogik für StorageDeviceDetails.xaml
    /// </summary>
    public partial class StorageDeviceDetails : UserControl
    {
        private StorageDevice _storagedevice;
        private LagerverwaltungDBContext _dbContext;
        public StorageDeviceDetails(StorageDevice storageDevice)
        {
            InitializeComponent();
            _storagedevice = storageDevice;
            this.DataContext = _storagedevice;
            _dbContext = new LagerverwaltungDBContext();
            GetAllRequiredData();
        }

        private void GetAllRequiredData()
        {
            var formfactordataservice = new FormFactorDataService(_dbContext);
            formfactordataservice.GetAll();
            Formfactor.ItemsSource = formfactordataservice.FormFactorList;
            foreach(FormFactor formfactor in Formfactor.Items)
            {
                if(formfactor.FormFactorID == _storagedevice.FormFactorID)
                {
                    Formfactor.SelectedItem = formfactor;
                }
            }
            var locationDataService = new LocationDataService(_dbContext);
            locationDataService.GetAll();
            Lagerort.ItemsSource = locationDataService.LocationList;
            foreach (Location location in Lagerort.Items)
            {
                if (location.LocationID == _storagedevice.LocationID)
                {
                    Lagerort.SelectedItem = location;
                }
            }
            var manufacturedataservice = new ManufacturerDataService(_dbContext);
            manufacturedataservice.GetAll();
            Herrsteller.ItemsSource = manufacturedataservice.ManufacturerList;
            foreach (Manufacturer manufacturer in Herrsteller.Items)
            {
                if (manufacturer.ManufacturerID == _storagedevice.ManufacturerID)
                {
                    Herrsteller.SelectedItem = manufacturer;
                }
            }
        }
    }
}
