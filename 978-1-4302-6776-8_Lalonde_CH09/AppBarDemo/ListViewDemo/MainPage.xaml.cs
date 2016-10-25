using System.Collections.ObjectModel;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using ListViewDemo.Models;
using ListViewDemo.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace ListViewDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainViewModel viewModel;
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            viewModel = new MainViewModel();
            DataContext = viewModel;

        }

        private void OnAddButtonClicked(object sender, RoutedEventArgs e)
        {
            //TODO: Show popup or navigate to new page providing entry fields for the user 
            //enter company name, logo path, year founded and company headquarters location
        }

        private void OnDeleteButtonClicked(object sender, RoutedEventArgs e)
        {
            var selectedCompanies = CompanyListView.SelectedItems.ToArray();
            foreach (Company item in selectedCompanies)
            {
                viewModel.DeleteCompany(item);
            }
        }
    }
}
