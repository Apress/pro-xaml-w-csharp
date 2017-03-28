using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMVVMWPF
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private PersonModel _Model;
        private string _FullName;

        public MainWindowViewModel()
        {
            _Model = new PersonModel
            {
                FirstName = "Buddy",
                LastName = "James"
            };

            this.FullName = string.Format("{0} {1}", _Model.FirstName, _Model.LastName); 
        }

        public string FirstName
        {
            get { return _Model.FirstName; }
            set 
            { 
                _Model.FirstName = value;
                this.FullName = string.Format("{0} {1}", _Model.FirstName, _Model.LastName); 

                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return _Model.LastName; }
            set
            {
                _Model.LastName = value;
                this.FullName = string.Format("{0} {1}", _Model.FirstName, _Model.LastName); 

                OnPropertyChanged("LastName");
            }
        }

        public string FullName
        {
            get { return _FullName; }
            set
            {
                _FullName = value;
                OnPropertyChanged("FullName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
