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
using LagersoftwareWPF.Windows;

namespace LagersoftwareWPF.Sites.MainWindowSites
{
    /// <summary>
    /// Interaktionslogik für MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Nav_Einlagern_Click(object sender, RoutedEventArgs e)
        {
            var einlagern = new AddItemWindow();
            einlagern.ShowDialog();
        }

        private void Nav_Gesamt_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainView());
        }
    }
}
