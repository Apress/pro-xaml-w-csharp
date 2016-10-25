using System.Windows;
using System.Windows.Controls;
using WpfDemo.ViewModels;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private MainViewModel _viewModel = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();

            //DataContext = _viewModel;
        }
    }
}
