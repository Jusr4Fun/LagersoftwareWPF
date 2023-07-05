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
    /// Interaktionslogik für NetworkDeviceDetails.xaml
    /// </summary>
    public partial class NetworkDeviceDetails : UserControl
    {
        private NetworkDevice _networkdevice;
        private LagerverwaltungDBContext _dbContext;
        public NetworkDeviceDetails(NetworkDevice networkDevice)
        {
            InitializeComponent();
            _networkdevice = networkDevice;
            this.DataContext = _networkdevice;
            _dbContext = new LagerverwaltungDBContext();
            GetAllRequiredData();
        }

        private void GetAllRequiredData()
        {
            var networkdevicetype = new NetworkDeviceTypeDataService(_dbContext);
            networkdevicetype.GetAll();
            Netzwerkgeätetyp.ItemsSource = networkdevicetype.NetworkDeviceTypeList;
            foreach (NetworkDeviceType netdevtype in Netzwerkgeätetyp.Items)
            {
                if (netdevtype.NetworkDeviceTypeID == _networkdevice.NetworkDeviceTypeID)
                {
                    Netzwerkgeätetyp.SelectedItem = netdevtype;
                }
            }
            var locationDataService = new LocationDataService(_dbContext);
            locationDataService.GetAll();
            Lagerort.ItemsSource = locationDataService.LocationList;
            foreach (Location location in Lagerort.Items)
            {
                if (location.LocationID == _networkdevice.LocationID)
                {
                    Lagerort.SelectedItem = location;
                }
            }
            var manufacturedataservice = new ManufacturerDataService(_dbContext);
            manufacturedataservice.GetAll();
            Herrsteller.ItemsSource = manufacturedataservice.ManufacturerList;
            foreach (Manufacturer manufacturer in Herrsteller.Items)
            {
                if (manufacturer.ManufacturerID == _networkdevice.ManufacturerID)
                {
                    Herrsteller.SelectedItem = manufacturer;
                }
            }
        }
    }
}
