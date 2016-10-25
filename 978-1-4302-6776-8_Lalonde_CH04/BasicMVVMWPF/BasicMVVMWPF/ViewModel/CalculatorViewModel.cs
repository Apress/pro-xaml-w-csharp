using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BasicMVVMWPF.Command;

namespace BasicMVVMWPF.ViewModel
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private int _FirstNumber;
        private int _SecondNumber;
        private int _Sum;
        private ICommand _AddNumbersCommand;

        public ICommand AddNumbersCommand
        {
            get { return _AddNumbersCommand; }
            set 
            { 
                _AddNumbersCommand = value;
                OnPropertyChanged("AddNumbersCommand");
            }
        }

        public int FirstNumber
        {
            get { return _FirstNumber; }
            set 
            { 
                _FirstNumber = value;
                OnPropertyChanged("FirstNumber");
            }
        }

        public int SecondNumber
        {
            get { return _SecondNumber; }
            set 
            { 
                _SecondNumber = value;
                OnPropertyChanged("SecondNumber");
            }
        }

        public int Sum
        {
            get { return _Sum; }
            set
            {
                _Sum = value;
                OnPropertyChanged("Sum");
            }
        }

        public CalculatorViewModel()
        {
            _AddNumbersCommand = new AddNumbersCommand();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
