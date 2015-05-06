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
    /// Interaction logic for ReturnABicycle.xaml
    /// </summary>
    public partial class ReturnABicycle : Window
    {
        MainMenu myCaller;
        RentalCollection rc = new RentalCollection();
        public ReturnABicycle(MainMenu m)
        {
            InitializeComponent();
            myCaller = m;
            rc.populateWithRentedOutBikes();
            List<Rental> ourList = rc.RentalsOut;
            foreach (Rental r in ourList)
            {
                int vehicle_id = r.VehicleID;
                BicycleReturnBox.Items.Add(vehicle_id);
            }

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            myCaller.Show();
            this.Hide();
        }

        private void BicycleReturnBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           /* rc.populateWithRentedOutBikes();
            List<Rental> ourList = rc.RentalsOut;
            foreach (Rental r in ourList)
            {
                int vehicle_id = r.VehicleID;
                BicycleReturnBox.Items.Add(vehicle_id);
            } */
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(BicycleReturnBox.Text);
            Vehicle v = new Vehicle("", "", "", "", "", "", "", "");
            v.populate(id);
            v.Status = "Active";
            v.update();
            Rental r = rc.getRental(id);
            r.DateReturned = DateTime.Now.ToString("yyyy-MM-dd");
            r.TimeReturned = DateTime.Now.ToString("HH-mm-ss tt");
            r.CheckInWorkerID = Convert.ToInt32(myCaller.getWorker().BannerID);
            r.update();
            MessageBox.Show("Bicycle returned successfully.");


        } 
    }
}
