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
    /// Interaction logic for II.xaml
    /// </summary>
    public partial class II : Page
    {
        public II()
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
                long[] inp = {input0, input1 };
                Array.Sort(inp);
                long NSN;
                for (long i = 1; true ; i++)
                {
                    NSN = inp[1] * i;
                    if(NSN%inp[0]==0)
                    {
                        OutputField.Text = NSN + "";
                        break;
                    }
                }
            }
        }
    }
}
