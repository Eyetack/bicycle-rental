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

namespace BicycleRentalWPF
{
    /// <summary>
    /// Interaction logic for SearchDeleteBicycle.xaml
    /// </summary>
    public partial class SearchDeleteBicycle : Window
    {
        MainMenu myCaller;
        public SearchDeleteBicycle(MainMenu m)
        {
            myCaller = m;
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            String b = BannerBox.Text;
            DeleteBicycle d = new DeleteBicycle(b, myCaller);
            d.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            myCaller.Show();
        }
    }
}
