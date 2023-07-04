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

namespace LagersoftwareWPF.Components
{
    /// <summary>
    /// Interaktionslogik für OtherDetails.xaml
    /// </summary>
    public partial class OtherDetails : UserControl
    {
        private Other _other;
        public OtherDetails(Other other)
        {
            InitializeComponent();
            _other = other;
            this.DataContext = _other;
        }
    }
}
