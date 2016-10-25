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

namespace WpfApplication1
{
    //Equivalent to the MainWindow element
    public class CSMainWindow : Window
    {
        private Grid _ContentGrid;
        private Button _BtnClickOk;
        private TextBlock _ButtonText;

        public CSMainWindow()
        {
            //Set the window properties
            SetValue(TitleProperty, "CSMainWindow");
            this.Height = 350;
            this.Width = 525;

            //Instantiate each object (element) in the Window
            _ButtonText = new TextBlock();
            _ButtonText.Text = "Click Me!";
            _ButtonText.FontSize = 100.0;

            _BtnClickOk = new Button();
            _BtnClickOk.Content = _ButtonText;

            _ContentGrid = new Grid();
            _ContentGrid.Children.Add(_BtnClickOk);

            this.Content = _ContentGrid;

        }
    }
}
