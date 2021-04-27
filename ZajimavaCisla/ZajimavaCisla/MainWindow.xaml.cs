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
using System.Windows.Shapes;

namespace ZajimavaCisla
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            WindowFrame.Content = new uvod();
        }

        private void I_Click(object sender, RoutedEventArgs e)
        {
            WindowFrame.Content = new I();
        }
        private void II_Click(object sender, RoutedEventArgs e)
        {
            WindowFrame.Content = new II();
        }
        private void III_Click(object sender, RoutedEventArgs e)
        {
            WindowFrame.Content = new III();
        }
        private void IV_Click(object sender, RoutedEventArgs e)
        {
            WindowFrame.Content = new IV();
        }
        private void V_Click(object sender, RoutedEventArgs e)
        {
            WindowFrame.Content = new V();
        }
        private void VI_Click(object sender, RoutedEventArgs e)
        {
            WindowFrame.Content = new VI();
        }
        private void VII_Click(object sender, RoutedEventArgs e)
        {
            WindowFrame.Content = new VII();
        }
        private void VIII_Click(object sender, RoutedEventArgs e)
        {
            WindowFrame.Content = new VIII();
        }
        private void IX_Click(object sender, RoutedEventArgs e)
        {
            WindowFrame.Content = new IX();
        }
        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            WindowFrame.Content = new Settings();
        }
    }
}
