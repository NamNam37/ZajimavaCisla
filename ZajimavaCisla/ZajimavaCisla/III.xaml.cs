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

namespace ZajimavaCisla
{
    /// <summary>
    /// Interaction logic for III.xaml
    /// </summary>
    public partial class III : Page
    {
        public III()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            bool ValidniINP0 = long.TryParse(Input0.Text, out long input0);
            bool ValidniINP1 = long.TryParse(Input1.Text, out long input1);

            if (ValidniINP0 == false || ValidniINP1 == false)
            {
                OutputField.Text = "Vstupní hodnoty musí být pouze numerické.";
            }
            else if (input0 <= 0 || input1 <= 0)
            {
                OutputField.Text = "Vstupní hodnoty musí být positivní.";
            }
            else
            {

            }
        }
    }
}