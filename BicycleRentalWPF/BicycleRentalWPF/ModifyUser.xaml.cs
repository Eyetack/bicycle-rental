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
    /// Interaction logic for ModifyUser.xaml
    /// </summary>
    public partial class ModifyUser : Window
    {
        MainMenu myCaller;
        User u;
        //Getting the data and filling in the text boxes
        public ModifyUser(String b, MainMenu m)
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
            NotesBox.Text = u.Notes;
        }

        //Submit button modifies user
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            String banner = BannerBox.Text;
            String first = FirstNameBox.Text;
            String last = LastNameBox.Text;
            String phone = PhoneBox.Text;
            String email = EmailBox.Text;
            String userType = UserTypeBox.Text;
            String status = StatusBox.Text;
            String notes = NotesBox.Text;

            u.BannerID = Convert.ToInt32(banner);
            u.FirstName = first;
            u.LastName = last;
            u.PhoneNumber = phone;
            u.EmailAddress = email;
            u.UserType = userType;
            u.Status = status;
            u.DateStatusUpdated = DateTime.Now.ToString("yyyy-MM-dd");
            u.Notes = notes;
            u.update();
            MessageBox.Show("Modified User successfully.");
            this.Hide();
            myCaller.Show();
        }

        //Cancel button goes back to Search User
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            SearchModifyUser s = new SearchModifyUser(myCaller);
            s.Show();
            this.Hide();
        }
    }
}
