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

namespace Uppgift1
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

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            int numberOfSeats = 16;
            int seatNumber = int.Parse(txtBox.Text);
            if (radioBtnAway.IsChecked == true & seatNumber > 0 & seatNumber <= (numberOfSeats / 2))
            {
                MessageBox.Show($"Sittplats nr {seatNumber} gör att du får åka framlänges");
            }
            if (radioBtnAway.IsChecked == true & seatNumber > (numberOfSeats / 2) & seatNumber <= numberOfSeats)
            {
                MessageBox.Show($"Sittplats nr {seatNumber} gör att du får åka baklänges");
            }
            if (radioBtHome.IsChecked == true & seatNumber > 0 & seatNumber <= (numberOfSeats / 2))
            {
                MessageBox.Show($"Sittplats nr {seatNumber} gör att du får åka baklänges");
            }
            if (radioBtHome.IsChecked == true & seatNumber > (numberOfSeats / 2) & seatNumber <= numberOfSeats)
            {
                MessageBox.Show($"Sittplats nr {seatNumber} gör att du får åka framlänges");
            }

        }
    }
}
