using System.Collections.ObjectModel;
using ListViewDemo.Models;

namespace ListViewDemo.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<Company> Companies { get; set; }

        public MainViewModel()
        {
            LoadCompanies();
        }

        private void LoadCompanies()
        {
            Companies = new ObservableCollection<Company>
            {
                new Company {LogoImagePath = "Assets/Amazon.png", CompanyName = "Amazon", YearFounded=1994, Headquarters = "Seattle, WA, USA"},
                new Company {LogoImagePath = "Assets/Apple.png", CompanyName = "Apple", YearFounded=1976, Headquarters = "Cupertino, CA, USA"},
                new Company {LogoImagePath = "Assets/Blackberry.png", CompanyName = "Blackberry", YearFounded=1984, Headquarters="Waterloo, ON, Canada" },
                new Company {LogoImagePath = "Assets/BoxNet.png", CompanyName = "Box.net", YearFounded = 2005, Headquarters = "Los Altos, CA, USA"},
                new Company {LogoImagePath = "Assets/Delicious.png", CompanyName = "Delicious", YearFounded = 2003, Headquarters = "San Mateo, CA, USA"},
                new Company {LogoImagePath = "Assets/Digg.png", CompanyName = "Digg", YearFounded = 2004, Headquarters = "New York, NY, USA"},
                new Company {LogoImagePath = "Assets/Ebay.png", CompanyName = "eBay", YearFounded = 1995, Headquarters = "San Jose, CA, USA"},
                new Company {LogoImagePath = "Assets/Evernote.png", CompanyName = "Evernote", YearFounded = 2007, Headquarters = "Redwood City, CA, USA"},
                new Company {LogoImagePath = "Assets/Facebook.png", CompanyName = "Facebook", YearFounded = 2004, Headquarters = "Menlo Park, CA, USA"},
                new Company {LogoImagePath = "Assets/Flickr.png", CompanyName = "Flickr", YearFounded = 2004, Headquarters = "Sunnyvale, CA, USA"},
                new Company {LogoImagePath = "Assets/Flipboard.png", CompanyName = "Flipboard", YearFounded = 2010, Headquarters = "Palo Alto, CA, USA"},
                new Company {LogoImagePath = "Assets/Google.png", CompanyName = "Google", YearFounded=1998, Headquarters = "Mountain View, CA, USA"},
                new Company {LogoImagePath = "Assets/HP.png", CompanyName = "HP", YearFounded = 1939, Headquarters = "Palo Alto, CA, USA"},
                new Company {LogoImagePath = "Assets/Intel.png", CompanyName = "Intel", YearFounded = 1968, Headquarters = "Santa Clara, CA, USA"},
                new Company {LogoImagePath = "Assets/Lenovo.png", CompanyName = "Lenovo", YearFounded = 1984, Headquarters = "Morrisville, NC, USA"},
                new Company {LogoImagePath = "Assets/LG.png", CompanyName = "LG", YearFounded = 1958, Headquarters = "Seoul, South Korea"},
                new Company {LogoImagePath = "Assets/LinkedIn.png", CompanyName = "LinkedIn", YearFounded = 2003, Headquarters = "Mountain View, CA, USA"},
                new Company {LogoImagePath = "Assets/Microsoft.png", CompanyName = "Microsoft", YearFounded = 1974, Headquarters = "Redmond, WA, USA"},
                new Company {LogoImagePath = "Assets/PayPal.png", CompanyName = "PayPal", YearFounded = 1998, Headquarters = "San Jose, CA, USA"},
                new Company {LogoImagePath = "Assets/Pinterest.png", CompanyName = "Pinterest", YearFounded = 2009, Headquarters = "San Francisco, CA, USA"},
                new Company {LogoImagePath = "Assets/Reddit.png", CompanyName = "Reddit", YearFounded = 2005, Headquarters = "San Francisco, CA, USA"},
                new Company {LogoImagePath = "Assets/Square.png", CompanyName = "Square", YearFounded = 2009, Headquarters = "San Francisco, CA, USA"},
                new Company {LogoImagePath = "Assets/Twitter.png", CompanyName = "Twitter", YearFounded = 2006, Headquarters = "San Francisco, CA, USA"},
                new Company {LogoImagePath = "Assets/Udemy.png", CompanyName = "Udemy", YearFounded = 2010, Headquarters = "San Francisco, CA, USA"},
                new Company {LogoImagePath = "Assets/YouTube.png", CompanyName = "YouTube", YearFounded = 2005, Headquarters = "San Bruno, CA, USA"},

            };
        }

    }
}
