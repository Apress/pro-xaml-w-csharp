using System.Collections.ObjectModel;
using System.Linq;

namespace ShareDemo.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private bool shareText;
        public bool ShareText 
        {
            get { return shareText; }
            set
            {
                if (value != shareText)
                {
                    shareText = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool shareLink;
        public bool ShareLink
        {
            get { return shareLink; }
            set
            {
                if (value != shareLink)
                {
                    shareLink = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool shareImage;
        public bool ShareImage
        {
            get { return shareImage; }
            set
            {
                if (value != shareImage)
                {
                    shareImage = value;
                    OnPropertyChanged();
                }
            }
        }

    }
}
