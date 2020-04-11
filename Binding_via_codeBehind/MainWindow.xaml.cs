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

namespace Binding_via_codeBehind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Binding binding = new Binding()
            {
                ElementName = "slider",
                Path = new PropertyPath("Value"),
                Mode = BindingMode.OneWay
            };
            text.SetBinding(TextBlock.FontSizeProperty, binding);

            Binding bindColor = new Binding
            {
                ElementName = "textBox",
                Path = new PropertyPath("Text"),
                Mode = BindingMode.OneWay
            };
            text.SetBinding(TextBlock.BackgroundProperty, bindColor);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            text.ClearValue(TextBlock.FontSizeProperty);
        }
    }
}
