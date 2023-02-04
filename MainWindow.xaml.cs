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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            string szin = $"{Convert.ToByte(sliPiros.Value)};{Convert.ToByte(sliZold.Value)};{Convert.ToByte(sliKek.Value)}";
            if (!lbSzinek.Items.Contains(szin))
            {
                lbSzinek.Items.Add(szin);
            }
            else
            {
                MessageBox.Show("Már van benne ilyen");
            }


        }

        private void btnTorol_Click(object sender, RoutedEventArgs e)
        {
            if (lbSzinek.SelectedIndex >= 0)
            {
                lbSzinek.Items.RemoveAt(lbSzinek.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Válassz ki egyet");
            }

        }

        private void btnUrit_Click(object sender, RoutedEventArgs e)
        {
            lbSzinek.Items.Clear();
        }

        private void SliChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rctTeglalap.Fill = new SolidColorBrush(Color.FromRgb(
                Convert.ToByte(sliPiros.Value), Convert.ToByte(sliZold.Value), Convert.ToByte(sliKek.Value)
                ));
            szamElso.Content = (Convert.ToByte(sliPiros.Value));
            szamMasodik.Content = (Convert.ToByte(sliZold.Value));
            szamHarmadik.Content = (Convert.ToByte(sliKek.Value));
        }

        private void lbSzinek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (lbSzinek.SelectedIndex >= 0)
            {
                string[] tagok = lbSzinek.SelectedItem.ToString().Split(';');
                sliPiros.Value = Convert.ToByte(tagok[0]);
                sliZold.Value = Convert.ToByte(tagok[1]);
                sliKek.Value = Convert.ToByte(tagok[2]);
            }
            

        }
    }
}