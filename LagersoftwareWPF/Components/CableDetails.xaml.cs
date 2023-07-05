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
using static System.Net.Mime.MediaTypeNames;

namespace LagersoftwareWPF.Components
{
    /// <summary>
    /// Interaktionslogik für CableDetails.xaml
    /// </summary>
    public partial class CableDetails : UserControl
    {
        private Cable _cable;
        private LagerverwaltungDBContext _dbContext;
        public CableDetails(Cable cable)
        {
            InitializeComponent();
            _dbContext = new LagerverwaltungDBContext();
            _cable = cable;
            this.DataContext = _cable;
            GetAllRequiredData();
        }

        private void GetAllRequiredData()
        {
            var cabletypedataservice = new CableTypeDataService(_dbContext);
            cabletypedataservice.GetAll();
            CableType.ItemsSource = cabletypedataservice.CableTypeList;
            foreach (CableType cable in CableType.Items)
            {
                if (cable.CableTypeID == _cable.CableTypeID)
                {
                    CableType.SelectedItem = cable;
                }
            }
            var locationDataService = new LocationDataService(_dbContext);
            locationDataService.GetAll();
            Location.ItemsSource = locationDataService.LocationList;
            foreach (Location location in Location.Items)
            {
                if (location.LocationID == _cable.LocationID)
                {
                    Location.SelectedItem = location;
                }
            }
        }
    }
}
