using System;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using ShareDemo.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ShareDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainViewModel mainViewModel = new MainViewModel();
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = mainViewModel;

            DataTransferManager dataTransferManager = DataTransferManager.GetForCurrentView();
            dataTransferManager.DataRequested += OnDataRequested;
        }

        private async void OnDataRequested(DataTransferManager sender, DataRequestedEventArgs e)
        {
            var deferral = e.Request.GetDeferral();

            DataRequest request = e.Request;
            request.Data.Properties.Title = "Share Demo";
            request.Data.Properties.Description = string.Format("Demonstrating the use of the Share Contract");

            if (mainViewModel.ShareText)
            {
                request.Data.SetText("This is a demo to show how easy sharing data can be using the  Share Contract.");
            }
            else if (mainViewModel.ShareLink)
            {
                request.Data.SetUri(new Uri("http://geekswithblogs.net/lorilalonde"));
            }
            else if (mainViewModel.ShareImage)
            {
                StorageFile imageFile = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("MontegoBay.png");

                var stream = RandomAccessStreamReference.CreateFromFile(imageFile);
                request.Data.SetBitmap(stream);
                request.Data.Properties.Thumbnail = stream;
            }

            deferral.Complete();
        }
    }
}
