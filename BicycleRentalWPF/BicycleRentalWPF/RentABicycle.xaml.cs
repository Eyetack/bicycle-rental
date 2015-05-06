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
        MainMenu myCaller;

        public RentABicycle(MainMenu m)
        {
            myCaller = m;
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
            myCaller.Show();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            int r = Convert.ToInt32(RenterTextBox.Text);
            int c = Convert.ToInt32(ChooseBicycleBox.Text);
            Rental rent = new Rental(c, r, DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("HH-mm-ss tt"), DateTime.Now.AddDays(7).ToString("yyyy-MM-dd"), DateTime.Now.ToString("HH-mm-ss tt"), "", "", 0, Convert.ToInt32(myCaller.getWorker().BannerID));
            rent.insert();
            MessageBox.Show("Rental inserted successfully");
            String id = ChooseBicycleBox.Text;
            Vehicle v = new Vehicle("", "", "", "", "", "", "", "");
            int vid = Convert.ToInt32(id);
            v.populate(vid);
            v.Status = "Rented";
            v.update();
            this.Hide();
            myCaller.Show();
        }

    }
}
