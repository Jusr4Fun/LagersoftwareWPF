using Datenbank;
using Datenbank.Models;
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

namespace LagersoftwareWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (var context = new LagerverwaltungDBContext())
            {
                //var cabletype = new CableType
                //{
                //    CableTypeName = "Cat 5e Patchkabel"
                //};
                //context.Add(cabletype);

                //var location = new Location
                //{
                //    LocationName = "Regal 1 Fach 1",
                //};
                //context.Add(location);
                //var other = new Other
                //{
                //    Name = "Kevin",
                //    Label = "ein Kevin",
                //    Amount = 1,
                //    Description = "einfachnurKEvinc",
                //    LocationID = 1,
                //    DetailedDescription = "ja was wei0 ich"
                //};
                //context.Item.Add(other);

                //var cable = new Cable
                //{
                //    Name = "Cat 5e",
                //    Label = "Cat 5e 5m",
                //    Amount = 3,
                //    Description = "Patchkabel",
                //    LocationID = 1,
                //    CableTypeID = 1,
                //    Length = 5,
                //};
                //context.Item.Add(cable);
                try
                {
                    context.SaveChanges();
                }
                catch(Exception e) 
                {
                    e.ToString();
                }
                
            }
        }
    }
}
