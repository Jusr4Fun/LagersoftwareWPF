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
    /// Interaktionslogik für PeripheralDetails.xaml
    /// </summary>
    public partial class PeripheralDetails : UserControl
    {
        private Peripheral _peripheral;
        private LagerverwaltungDBContext _dbContext;
        public PeripheralDetails(Peripheral peripheral)
        {
            InitializeComponent();
            _peripheral = peripheral;
            this.DataContext = _peripheral;
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
                if (location.LocationID == _peripheral.LocationID)
                {
                    Lagerort.SelectedItem = location;
                }
            }
            var peripheraltypeDataService = new PeripheralTypeDataService(_dbContext);
            peripheraltypeDataService.GetAll();
            PeripherieTyp.ItemsSource = peripheraltypeDataService.PeripheralTypeList;
            foreach(PeripheralType peripheralType in PeripherieTyp.Items)
            {
                if (peripheralType.PeripheralTypeID == _peripheral.PeripheralTypeID)
                {
                    PeripherieTyp.SelectedItem = peripheralType;
                }
            }
        }
    }
}
