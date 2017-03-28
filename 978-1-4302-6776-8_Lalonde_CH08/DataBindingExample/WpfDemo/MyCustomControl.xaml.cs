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

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MyCustomControl.xaml
    /// </summary>
    public partial class MyCustomControl : UserControl
    {
        public MyCustomControl()
        {
            InitializeComponent();
            (this.Content as FrameworkElement).DataContext = this;
        }

        public static readonly DependencyProperty MyCustomTextProperty = DependencyProperty.Register("MyCustomText", typeof(string), typeof(MyCustomControl));
        public string MyCustomText
        {
            get { return (string)GetValue(MyCustomTextProperty); }
            set { SetValue(MyCustomTextProperty, value); }
        }
    }
}
