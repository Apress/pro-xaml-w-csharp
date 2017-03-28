using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BasicMVVMWPF.ViewModel;

namespace BasicMVVMWPF.Command
{
    public class AddNumbersCommand : ICommand
    {
        private CalculatorViewModel _ViewModel;

        public bool CanExecute(object parameter)
        {
            if (parameter == null)
                return false;
            else
            {
                _ViewModel = (CalculatorViewModel)parameter;
            }

            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (parameter == null)
            {
                if (_ViewModel == null)
                    throw new ArgumentNullException("parameter");
            }
            else
            {
                _ViewModel = (CalculatorViewModel)parameter;
            }

            _ViewModel.Sum = _ViewModel.FirstNumber + _ViewModel.SecondNumber;
        }
    }
}
