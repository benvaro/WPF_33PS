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

namespace WPF_StaticRes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SomeClass obj = new SomeClass() { MyProperty = "My property from CodeBehind!", 
        MyProperty2 = "Other property"};
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = obj;
        }

    }
    public class SomeClass
    {
        public string MyProperty { get; set; }
        public string MyProperty2 { get; set; }
    }
}
