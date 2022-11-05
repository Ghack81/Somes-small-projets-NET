using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Stackpanel
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tuto sur les stackPanel");
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tuto sur les pour et les contre du StackPanel qui nous permet de stocker des contrôles différent dans un container ");
        }
    }
}
