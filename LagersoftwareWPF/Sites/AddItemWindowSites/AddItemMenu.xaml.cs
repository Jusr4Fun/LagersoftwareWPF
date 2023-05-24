using System.Windows;
using System.Windows.Controls;

namespace LagersoftwareWPF.Sites.AddItemWindowSites;

/// <summary>
/// Interaktionslogik für AddItemMenu.xaml
/// </summary>
public partial class AddItemMenu : Page
{
    public AddItemMenu()
    {
        InitializeComponent();
    }

    private void Nav_AddDisplay_Click(object sender, RoutedEventArgs e)
    {
        this.NavigationService.Navigate(new AddItemDisplay());
    }
    private void Nav_AddCable_Click(object sender, RoutedEventArgs e)
    {
        this.NavigationService.Navigate(new AddItemCable());
    }
    private void Nav_AddNetworkDevice_Click(object sender, RoutedEventArgs e)
    {
        this.NavigationService.Navigate(new AddItemNetworkDevice());
    }
    private void Nav_AddOther_Click(object sender, RoutedEventArgs e)
    {
        this.NavigationService.Navigate(new AddItemOther());
    }
    private void Nav_AddPC_Click(object sender, RoutedEventArgs e)
    {
        this.NavigationService.Navigate(new AddItemPC());
    }
    private void Nav_AddPeripheral_Click(object sender, RoutedEventArgs e)
    {
        this.NavigationService.Navigate(new AddItemPeripheral());
    }
    private void Nav_AddStorageDevice_Click(object sender, RoutedEventArgs e)
    {
        this.NavigationService.Navigate(new AddItemStorageDevice());
    }
}
