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
    /// Interaction logic for RentABicycle.xaml
    /// </summary>
    public partial class RentABicycle : Window
    {
        VehicleCollection ourVehicles;

        public RentABicycle()
        {
            InitializeComponent();
            ourVehicles = new VehicleCollection();
            foreach (Vehicle v in ourVehicles.Bikes)
            {
                ChooseBicycleBox.Items.Add(v.ID);
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainMenu ourMainMenu = new MainMenu();
            ourMainMenu.Show();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

    }
}
