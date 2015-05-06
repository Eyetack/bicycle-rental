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
    /// Interaction logic for SearchDeleteUser.xaml
    /// </summary>
    public partial class SearchDeleteUser : Window
    {
        MainMenu myCaller;
        public SearchDeleteUser(MainMenu m)
        {
            myCaller = m;
            InitializeComponent();
        }

        //Submit button gives DeleteUser screen the Banner ID and goes to DeleteUser screen
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            String banner = BannerBox.Text;
            DeleteUser d = new DeleteUser(banner, myCaller);
            d.Show();
            this.Hide();
        }

        //Cancel button goes back to main menu
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            myCaller.Show();
            this.Hide();
        }
    }
}
