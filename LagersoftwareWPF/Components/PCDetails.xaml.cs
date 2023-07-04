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
    /// Interaktionslogik für PCDetails.xaml
    /// </summary>
    public partial class PCDetails : UserControl
    {
        private PC _pc;
        public PCDetails(PC pc)
        {
            InitializeComponent();
            _pc = pc;
            this.DataContext = _pc;
        }
    }
}
