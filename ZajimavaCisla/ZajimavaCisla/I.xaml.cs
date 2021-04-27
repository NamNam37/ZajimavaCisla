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
    /// Interaction logic for I.xaml
    /// </summary>
    public partial class I : Page
    {
        public I()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            bool ValidniINP0 = long.TryParse(Input0.Text, out long vstupniHodnota0);
            bool ValidniINP1 = long.TryParse(Input1.Text, out long vstupniHodnota1);

            if (ValidniINP0 == false || ValidniINP1 == false)
            {
                OutputField.Text = "Vstupní hodnoty musí být pouze numerické.";
            }
            else if (vstupniHodnota0 <= 0 || vstupniHodnota1 <= 0)
            {
                OutputField.Text = "Vstupní hodnoty musí být positivní.";
            }
            else
            {

                long nejvetsiSpolecnyNasobek = NejvetsiSpolecnyNasobek(vstupniHodnota0, vstupniHodnota1);
                string spolecneNasobky = "";

                foreach (long item in SpolecneNasobky(vstupniHodnota0, vstupniHodnota1))
                {
                    spolecneNasobky += ($"{item}, ");
                }
                OutputField.Text = spolecneNasobky;
                OutputField2.Text = nejvetsiSpolecnyNasobek + "";
            }
        }
        static long NejvetsiSpolecnyNasobek(long vstupniHodnota0, long vstupniHodnota1) //Eukliduv algoritmus, https://cs.wikipedia.org/wiki/Eukleid%C5%AFv_algoritmus
        {
            while (vstupniHodnota1 != 0)
            {
                long zbytek = vstupniHodnota0 % vstupniHodnota1;
                vstupniHodnota0 = vstupniHodnota1;
                vstupniHodnota1 = zbytek;
            }
            return vstupniHodnota0;
        }
        static List<long> SpolecneNasobky(long vstupniHodnota0, long vstupniHodnota1)
        {
            long nejvetsiSpolecnyNasobek = NejvetsiSpolecnyNasobek(vstupniHodnota0, vstupniHodnota1);
            List<long> spolecneNasobkyList = new List<long>(); //List bude výkonnější než HashSet v menším množštví https://stackoverflow.com/questions/150750/hashset-vs-list-performance
            for (long i = 1; i < nejvetsiSpolecnyNasobek; i++)
            {
                if (nejvetsiSpolecnyNasobek % i == 0)
                {
                    spolecneNasobkyList.Add(i);
                }
            }
            return spolecneNasobkyList;
        }
    }
}
