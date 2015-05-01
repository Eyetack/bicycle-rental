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
    /// Interaction logic for SearchUser.xaml
    /// </summary>
    public partial class SearchModifyUser : Window
    {
        public SearchModifyUser()
        {
            InitializeComponent();
        }

        //Cancel button goes back to main menu
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            this.Hide();
        }

        //Submit button gives ModifyUser screen the Banner ID and goes to ModifyUser screen
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            String banner = BannerBox.Text;
            ModifyUser m = new ModifyUser(banner);
            m.Show();
            this.Hide();
        }
    }
}
