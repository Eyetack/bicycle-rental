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
    /// Interaction logic for InsertWorker.xaml
    /// </summary>
    public partial class InsertWorker : Window
    {
        MainMenu myCaller;
        //Filling in the combobox
        public InsertWorker(MainMenu m)
        {
            myCaller = m;
            InitializeComponent();
            CredentialBox.Items.Add("Administrator");
            CredentialBox.Items.Add("Ordinary");
        }


        //Submit button inserts worker
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String banner = BannerBox.Text;
            String first = FirstNameBox.Text;
            String last = LastNameBox.Text;
            String phone = PhoneNumberBox.Text;
            String email = EmailBox.Text;
            String credential = CredentialBox.Text;
            String initialReg = InitialRegBox.Text;
            String password = PasswordBox.Password;
            String notes = NotesBox.Text;
            Worker w = new Worker(banner, first, last, phone, email, credential, initialReg, password, notes);
            w.insert();
            MessageBox.Show("Worker inserted successfully.");
            this.Hide();
            myCaller.Show();
        }

        //Cancel button goes back to main menu
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            myCaller.Show();
            this.Hide();
        }

        private void CredentialBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
