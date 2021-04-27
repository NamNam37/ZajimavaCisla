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
    /// Interaction logic for IV.xaml
    /// </summary>
    public partial class IV : Page
    {
        public IV()
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
                long vstupniHodnota0 = input0;
                long vstupniHodnota1 = input1;
                HashSet<long> hashSetPrvocisla = new HashSet<long>();

                if (vstupniHodnota0 <= 2)
                {
                    hashSetPrvocisla.Add(2);
                }
                if (vstupniHodnota0 == 1)
                {
                    vstupniHodnota0 += 2;
                }
                if (vstupniHodnota0 % 2 == 0) //ze sudého na liché
                {
                    vstupniHodnota0++;
                }

                for (long g = vstupniHodnota0; g <= vstupniHodnota1; g += 2) //přičítáním 2 namísto 1, přeskočíme sudá čísla, za předpokladu, že počáteční číslo bude liché
                {
                    long m = 0;
                    double cisloMaximalni = Math.Round(Math.Sqrt(g));       //Není potřeba zkoušet dělit číslo, číslem větším než je jeho odmocnina
                    long cisloMax = Convert.ToInt64(cisloMaximalni);      //
                    for (long f = 1; f <= cisloMax; f += 2)
                    {
                        if (g % f == 0)
                        {
                            m++;


                        }
                    }
                    if (m == 1)
                    {
                        hashSetPrvocisla.Add(g);
                    }
                }
                string output = "";
                foreach (long c in hashSetPrvocisla)
                {
                    output += c + ", ";
                }
                OutputField.Text = output;
            }
        }
    }
}
