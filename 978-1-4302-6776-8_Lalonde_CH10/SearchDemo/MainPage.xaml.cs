using System.Collections.Generic;
using Windows.ApplicationModel.Search.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using SearchDemo.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace SearchDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly SearchSuggestionManager searchManager;

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
            this.DataContext = App.MainViewModel;

            //only show the search history list when the search box has focus
            CompanySearchBox.GotFocus += delegate(object sender, RoutedEventArgs args)
            {
                CompanySearchBox.SearchHistoryEnabled = true;
            };
            CompanySearchBox.LostFocus += delegate(object sender, RoutedEventArgs args)
            {
                CompanySearchBox.SearchHistoryEnabled = false;
            };

            //clear previous search history each time the application is launched
            searchManager = new SearchSuggestionManager();
            searchManager.ClearHistory();
        }


        private void SearchBox_OnQuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
            Frame.Navigate(typeof (CompanySearchResults), args.QueryText);
        }

        private void SearchBox_OnSuggestionsRequested(SearchBox sender, SearchBoxSuggestionsRequestedEventArgs args)
        {
            //clear search history, and add new suggestions to the search history list
            searchManager.ClearHistory();
            IEnumerable<Company> results = App.MainViewModel.GetSearchResults(args.QueryText);

            foreach (Company company in results)
            {
                searchManager.AddToHistory(company.CompanyName);
            }
        }
    }
}
