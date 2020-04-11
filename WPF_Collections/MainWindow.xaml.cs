using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF_Collections
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // List<string> list = new List<string>();
        ObservableCollection<string> list = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
            string[] arr = { "One", "Two", "Three", "Four" };
            foreach (var item in arr)
            {
                list.Add(item);
            }
            listBox.ItemsSource = list;
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            list.Add("fifth");
            list[0] = "new element";
        }
    }
}
