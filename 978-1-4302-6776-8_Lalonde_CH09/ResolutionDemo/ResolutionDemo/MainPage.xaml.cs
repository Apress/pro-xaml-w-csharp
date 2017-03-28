using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace App3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            DisplayInformation info = DisplayInformation.GetForCurrentView();
            double scaleFactor = info.RawPixelsPerViewPixel * 100;

            string selectedScaleFactor = (scaleFactor <= 100) ? "100" :
                                         (scaleFactor <= 140) ? "140" : 
                                         "240";

            string imageUriString = string.Format(@"ms-appx:///Images/star.scale-{0}.png", selectedScaleFactor);

            Uri selectedImageUri = new Uri(imageUriString, UriKind.RelativeOrAbsolute);
            BitmapImage bmpImage = new BitmapImage(selectedImageUri);
            MyImage.Source = bmpImage;
        }
    }
}
