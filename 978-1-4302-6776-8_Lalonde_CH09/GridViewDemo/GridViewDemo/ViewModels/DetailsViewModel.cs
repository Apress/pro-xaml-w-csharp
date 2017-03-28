using GridViewDemo.Models;

namespace GridViewDemo.ViewModels
{
    public class DetailsViewModel : ViewModelBase
    {
        private Company selectedCompany;
        public Company SelectedCompany
        {
            get
            {
                return selectedCompany;
            }
            set
            {
                if (value != selectedCompany)
                {
                    selectedCompany = value;
                    OnPropertyChanged();
                }
            }
        }

    }
}
