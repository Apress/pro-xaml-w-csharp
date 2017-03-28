using System;
using Windows.UI.Xaml.Controls;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ApplicationInsightsDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private TelemetryClient client = new TelemetryClient();

        public MainPage()
        {
            this.InitializeComponent();
            LogAppEvent("Application launched");
        }

        private void LogAppEvent(string message)
        {
            try
            {
                client.TrackEvent("Application launched");
                throw new Exception("My custom exception");
            }
            catch (Exception ex)
            {
                client.TrackException(ex);
            }
        }
    }
}
