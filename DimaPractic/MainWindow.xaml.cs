using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace DimaPractic
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

        private void btnLab6_7_9(object sender, RoutedEventArgs e)
        {
            WindowLab6_7_9 window = new WindowLab6_7_9();
            window.Show();
        }

        private void btnLab8_10(object sender, RoutedEventArgs e)
        {
            WindowLab8_10 window = new WindowLab8_10();
            window.Show();
        }
    }
}
