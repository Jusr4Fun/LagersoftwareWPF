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
    /// Interaktionslogik für OtherDetails.xaml
    /// </summary>
    public partial class OtherDetails : UserControl
    {
        private Other _other;
        private LagerverwaltungDBContext _dbContext;
        public OtherDetails(Other other)
        {
            InitializeComponent();
            _other = other;
            this.DataContext = _other;
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
                if (location.LocationID == _other.LocationID)
                {
                    Lagerort.SelectedItem = location;
                }
            }
        }
    }
}
