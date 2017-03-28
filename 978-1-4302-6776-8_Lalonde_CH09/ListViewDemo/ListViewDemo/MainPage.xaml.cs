using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
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

        private void OnListViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CompanyListView.SelectedItem != null)
            {
                this.Frame.Navigate(typeof(DetailsPage), CompanyListView.SelectedItem);
            }
        }

    }
}
