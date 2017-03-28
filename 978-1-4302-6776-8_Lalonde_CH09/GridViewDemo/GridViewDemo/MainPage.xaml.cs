using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using GridViewDemo.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace GridViewDemo
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

        private void OnGridViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CompanyGridView.SelectedItem != null)
            {
                this.Frame.Navigate(typeof(DetailsPage), CompanyGridView.SelectedItem);
            }
        }

    }
}
