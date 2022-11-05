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

namespace WrapPanel
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
            MessageBox.Show("le WrapPanel permet de ne pas faire disparaitre du container le Bouton 2  si le bouton 1 prentoute la place du container dans ce cas il fait passer à la ligne l'autre contrôle"); 
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("le WrapPanel permet de ne pas faire disparaitre du container le Bouton 2  si le bouton 1 prentoute la place du container dans ce cas il fait passer à la ligne l'autre contrôle");
        }
    }
}
