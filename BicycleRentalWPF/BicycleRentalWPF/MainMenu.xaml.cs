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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {

        Worker w;

        public MainMenu(Worker work)
        {
            w = work;
            InitializeComponent();
        }

        public Worker getWorker()
        {
            return w;
        }

        //back button brings user back to log in screen
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();
        }

        //insert bicycle button brings user to insert bicycle window
        private void InsertBicycleButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            InsertBicycle ourInsertBicycle = new InsertBicycle(this);
            ourInsertBicycle.Show();
        }

        //insert worker button brings user to insert worker window
        private void InsertWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            InsertWorker ourInsertWorker = new InsertWorker(this);
            ourInsertWorker.Show();
        }

        //insert user button brings user to insert user window
        private void InsertUserButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            InsertUser ourInsertUser = new InsertUser(this);
            ourInsertUser.Show();
        }

        //modify user button brings user to search modify user window
        private void ModifyUserButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SearchModifyUser ourSearchModifyUser = new SearchModifyUser(this);
            ourSearchModifyUser.Show();
        }

        //modify worker button brings worker to search modify worker window 
        private void ModifyWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SearchModifyWorker ourSearchModifyWorker = new SearchModifyWorker(this);
            ourSearchModifyWorker.Show();
        }

        //delete user button brings user to search modify user window
        private void DeleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SearchDeleteUser ourSearchDeleteUser = new SearchDeleteUser(this);
            ourSearchDeleteUser.Show();
        }

        //delete worker button brings worker to search modify worker
        private void DeleteWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SearchDeleteWorker ourSearchDeleteWorker = new SearchDeleteWorker(this);
            ourSearchDeleteWorker.Show();
        }

        //rent a bicycle button brings user to rent a bicycle window
        private void RentABicycleButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RentABicycle ourRentaBicycle = new RentABicycle(this);
            ourRentaBicycle.Show();
        }

        //return a bicycle button brings user to return a bicycle window.
        private void ReturnABicycleButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ReturnABicycle ourReturnABicycle = new ReturnABicycle(this);
            ourReturnABicycle.Show();
        }

        //modify bicycle button brings user to search modify bicycle 
        private void ModifyBicycleButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SearchModifyBicycle ourSearchModifyBicycle = new SearchModifyBicycle(this);
            ourSearchModifyBicycle.Show();
        }

        //delete bicycle button brings user to search delete bicycle window
        private void DeleteBicycleButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SearchDeleteBicycle ourSearchDeleteBicycle = new SearchDeleteBicycle(this);
            ourSearchDeleteBicycle.Show();
        }


    }
}
