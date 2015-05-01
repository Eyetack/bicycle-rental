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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();
        }

        private void InsertBicycleButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            InsertBicycle ourInsertBicycle = new InsertBicycle();
            ourInsertBicycle.Show();
        }

        private void InsertWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            InsertWorker ourInsertWorker = new InsertWorker();
            ourInsertWorker.Show();
        }

        private void InsertUserButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            InsertUser ourInsertUser = new InsertUser();
            ourInsertUser.Show();
        }

        private void ModifyUserButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SearchModifyUser ourSearchModifyUser = new SearchModifyUser();
            ourSearchModifyUser.Show();
        }

        private void ModifyWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SearchModifyWorker ourSearchModifyWorker = new SearchModifyWorker();
            ourSearchModifyWorker.Show();
        }

        private void DeleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SearchDeleteUser ourSearchDeleteUser = new SearchDeleteUser();
            ourSearchDeleteUser.Show();
        }

        private void DeleteWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SearchDeleteWorker ourSearchDeleteWorker = new SearchDeleteWorker();
            ourSearchDeleteWorker.Show();
        }

        private void RentABicycleButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RentABicycle ourRentaBicycle = new RentABicycle();
            ourRentaBicycle.Show();
        }

        private void ReturnABicycleButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ReturnABicycle ourReturnABicycle = new ReturnABicycle();
            ourReturnABicycle.Show();
        }

        private void ModifyBicycleButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SearchModifyBicycle ourSearchModifyBicycle = new SearchModifyBicycle();
            ourSearchModifyBicycle.Show();
        }


    }
}
