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
    /// Interaction logic for InsertUser.xaml
    /// </summary>
    public partial class InsertUser : Window
    {
        //Filling in the ComboBox
        public InsertUser()
        {
            InitializeComponent();
            UserTypeBox.Items.Add("Faculty/Staff");
            UserTypeBox.Items.Add("Student");
        }

        //Submit button inserts User
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            int banner = Convert.ToInt32(BannerBox.Text);
            String first = FirstNameBox.Text;
            String last = LastNameBox.Text;
            String phone = PhoneNumberBox.Text;
            String email = EmailBox.Text;
            String userType = UserTypeBox.Text;
            String notes = NotesBox.Text;
            User u = new User(banner, first, last, phone, email, userType, notes);
            u.insert();
            MessageBox.Show("User inserted successfully.");
            this.Hide();
            MainMenu ourMainMenu = new MainMenu();
            ourMainMenu.Show();
        }

        //Cancel button goes to main menu
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            this.Hide();
        }
    }
}
