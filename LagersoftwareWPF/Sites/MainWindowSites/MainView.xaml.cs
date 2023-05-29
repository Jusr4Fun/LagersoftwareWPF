using Datenbank.Models;
using Datenbank.Services;
using LagersoftwareWPF.Components;
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

namespace LagersoftwareWPF.Sites.MainWindowSites
{
    /// <summary>
    /// Interaktionslogik für MainView.xaml
    /// </summary>
    public partial class MainView : Page
    {
        public MainView()
        {
            InitializeComponent();
            GetAllRequiredData();
        }

        public void GetAllRequiredData()
        {
            var itemdataservice = new ItemDataService(new Datenbank.LagerverwaltungDBContext());
            itemdataservice.GetAll();
            AllList.ItemsSource = itemdataservice.Items;
        }

        private void AllList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = AllList.SelectedItem;
            if (selected.GetType() == typeof(Cable))
            {
                Detail.Content = new CableDetails((Cable)selected);
            }
            else if (selected.GetType() == typeof(Display))
            {
                Detail.Content = new DisplayDetails();
            }
            else if (selected.GetType() == typeof(NetworkDevice))
            {
                Detail.Content = new NetworkDeviceDetails();
            }
            else if (selected.GetType() == typeof(Other))
            {
                Detail.Content = new OtherDetails();
            }
            else if (selected.GetType() == typeof(PC)) 
            { 
                Detail.Content = new PCDetails(); 
            }
            else if (selected.GetType() == typeof(Peripheral))
            {
                Detail.Content = new PeripheralDetails();
            }
            else if (selected.GetType() == typeof(StorageDevice))
            {
                Detail.Content = new StorageDeviceDetails();
            }
            else
            {
                Detail.Content = null;
            }
            //Detail.Content = 
        }
    }
}
