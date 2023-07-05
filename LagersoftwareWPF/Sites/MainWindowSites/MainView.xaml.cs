﻿using Datenbank.Models;
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
        private ItemDataService _itemDataService;
        private List<string> _kategorien = new List<string>() {"","Kabel","Bildschirm","Netzwerk Gerät","PC","Peripherie","Speicher Gerät","Anderes"};
        private List<string> templist1 = new List<string>();
        private List<string> templist2 = new List<string>();
        public MainView()
        {
            InitializeComponent();
            _itemDataService = new ItemDataService(new Datenbank.LagerverwaltungDBContext(), new Datenbank.Service.Filter());
            GetAllRequiredData();
            tempdataini();
            this.DataContext = _itemDataService;
        }

        private void tempdataini()
        {
            FilterComboBox.ItemsSource = _kategorien;
            FilterComboBox.SelectedIndex = 0;
            templist1.Add("1 - 2 Meter");
            Laenge.ItemsSource = templist1;
            Laenge.SelectedIndex = 0;
            templist2.Add("Cat-Verlegekabel");
            CableType.ItemsSource = templist2;
            CableType.SelectedIndex = 0;
        }

        public void GetAllRequiredData()
        {
            _itemDataService.GetAll();
        }

        private void AllList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = AllList.SelectedItem;
            if (selected != null)
            {
                if (selected.GetType() == typeof(Cable))
                {
                    Detail.Content = new CableDetails((Cable)selected);
                }
                else if (selected.GetType() == typeof(Display))
                {
                    Detail.Content = new DisplayDetails((Display)selected);
                }
                else if (selected.GetType() == typeof(NetworkDevice))
                {
                    Detail.Content = new NetworkDeviceDetails((NetworkDevice)selected);
                }
                else if (selected.GetType() == typeof(Other))
                {
                    Detail.Content = new OtherDetails((Other)selected);
                }
                else if (selected.GetType() == typeof(PC))
                {
                    Detail.Content = new PCDetails((PC)selected);
                }
                else if (selected.GetType() == typeof(Peripheral))
                {
                    Detail.Content = new PeripheralDetails((Peripheral)selected);
                }
                else if (selected.GetType() == typeof(StorageDevice))
                {
                    Detail.Content = new StorageDeviceDetails((StorageDevice)selected);
                }
                else
                {
                    Detail.Content = null;
                }
            }
            //Detail.Content = 
        }

        private void Suchfeld_TextChanged(object sender, TextChangedEventArgs e)
        {
            _itemDataService.Filter.ChangeFilterArguments(Suchfeld.Text);
            _itemDataService.GetAll();
        }

        private void FilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var test = FilterComboBox.SelectedItem;
            if (test != null)
            {

            }
        }
    }
}
