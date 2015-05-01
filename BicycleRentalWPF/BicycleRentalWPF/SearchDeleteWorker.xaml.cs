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
    /// Interaction logic for SearchDeleteWorker.xaml
    /// </summary>
    public partial class SearchDeleteWorker : Window
    {
        public SearchDeleteWorker()
        {
            InitializeComponent();
        }

        //Submit button gives DeleteWorker screen the Banner ID and goes to DeleteWorker screen
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            String banner = BannerBox.Text;
            DeleteWorker d = new DeleteWorker(banner);
            d.Show();
            this.Hide();
        }

        //Cancel button goes back to main menu
        private void CancelButton_Click_1(object sender, RoutedEventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            this.Hide();
        }


    }
}
