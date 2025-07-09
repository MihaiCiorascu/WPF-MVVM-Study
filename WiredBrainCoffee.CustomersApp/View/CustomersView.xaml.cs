using System.Windows;
using System.Windows.Controls;
using WiredBrainCoffee.CustomersApp.Data;
using WiredBrainCoffee.CustomersApp.ViewModel;

namespace WiredBrainCoffee.CustomersApp.View
{
  public partial class CustomersView : UserControl
  {
    private CustomersViewModel viewModel;
    
    public CustomersView()
    {
      InitializeComponent();
      viewModel = new CustomersViewModel(new CustomerDataProvider());
      DataContext = viewModel;
      Loaded += CustomersView_Loaded;
    }

    private async void CustomersView_Loaded(object sender, RoutedEventArgs e)
    {
        await viewModel.LoadAsync();
    }
  }
}
