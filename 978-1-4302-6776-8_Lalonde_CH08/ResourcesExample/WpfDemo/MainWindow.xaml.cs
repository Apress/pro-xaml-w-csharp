using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string textBoxLabel;
        private int clickedCount = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddItemButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.Resources["TextBlockLabel"] = string.Format("Clicked {0} time(s)", ++clickedCount);

        }
    }
}
