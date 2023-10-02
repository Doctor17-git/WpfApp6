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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "Привет!";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            button2.Background = new SolidColorBrush(Colors.Red);
            button2.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
