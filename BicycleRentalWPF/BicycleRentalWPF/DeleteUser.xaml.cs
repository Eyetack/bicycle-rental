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
    /// Interaction logic for DeleteUser.xaml
    /// </summary>
    public partial class DeleteUser : Window
    {
        User u;
        MainMenu myCaller;

        //Getting the data and filling in the text boxes
        public DeleteUser(String b, MainMenu m)
        {
            myCaller = m;
            InitializeComponent();
            UserTypeBox.Items.Add("Faculty/Staff");
            UserTypeBox.Items.Add("Student");
            StatusBox.Items.Add("Active");
            StatusBox.Items.Add("Inactive");

            int banner = Convert.ToInt32(b);
            u = new User(banner, "", "", "", "", "", "");
            u.populate(banner);
            BannerBox.Text = Convert.ToString(u.BannerID);
            FirstNameBox.Text = u.FirstName;
            LastNameBox.Text = u.LastName;
            PhoneBox.Text = u.PhoneNumber;
            EmailBox.Text = u.EmailAddress;
            UserTypeBox.Text = u.UserType;
            StatusBox.Text = u.Status;
            StatusUpdatedBox.Text = u.DateStatusUpdated;
            NotesBox.Text = u.Notes;

        }

        //Submit button deletes user
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            u.delete();
            MessageBox.Show("User deleted successfully.");
        }

        //Cancel button goes back to Search User
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            SearchDeleteUser d = new SearchDeleteUser(myCaller);
            d.Show();
            this.Hide();
        }
    }
}
