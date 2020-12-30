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

namespace Uppgift2
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

        Waggon waggon = new Waggon(32);

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            
            waggon.FillSeats();
            // Tågtenta lösningsförslag
            lstBox.ItemsSource = null;
            lstBox.ItemsSource = waggon.Seats;

            lstBoxFreePair.ItemsSource = null;
            lstBoxFreePair.ItemsSource = waggon.GetFreeSeatPair();

            //lstBox.ItemsSource = waggon.GetFreeSeats(3);

        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            
            int[] seatNumber = {1, 2, 3, 4};
            waggon.Return(seatNumber);
            lstBox.ItemsSource = null;
            lstBox.ItemsSource = waggon.Seats;
        }
    }
}
