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
    /// Interaction logic for ModifyWorker.xaml
    /// </summary>
    public partial class ModifyWorker : Window
    {
        Worker w;

        //Getting the data and filling in the text boxes
        public ModifyWorker(String b)
        {
            InitializeComponent();
            CredentialBox.Items.Add("Administrator");
            CredentialBox.Items.Add("Ordinary");
            StatusBox.Items.Add("Active");
            StatusBox.Items.Add("Inactive");
            int banner = Convert.ToInt32(b);
            w = new Worker(b, "", "", "", "", "", "", "", "");
            w.populate(banner);
            BannerBox.Text = Convert.ToString(w.BannerID);
            FirstNameBox.Text = w.FirstName;
            LastNameBox.Text = w.LastName;
            PhoneBox.Text = w.PhoneNumber;
            EmailBox.Text = w.EmailAddress;
            CredentialBox.Text = w.Credential;
            InitialRegBox.Text = w.InitialRegistrationDate;
            PasswordBox.Text = w.WorkerPassword;
            NotesBox.Text = w.Notes;
            StatusBox.Text = w.Status;
        }

        //Submit button modifies worker
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            String banner = BannerBox.Text;
            String first = FirstNameBox.Text;
            String last = LastNameBox.Text;
            String phone = PhoneBox.Text;
            String email = EmailBox.Text;
            String credential = CredentialBox.Text;
            String initialReg = InitialRegBox.Text;
            String password = PasswordBox.Text;
            String status = StatusBox.Text;
            String notes = NotesBox.Text;

            w.BannerID = banner;
            w.FirstName = first;
            w.LastName = last;
            w.PhoneNumber = phone;
            w.EmailAddress = email;
            w.Credential = credential;
            w.InitialRegistrationDate = initialReg;
            w.WorkerPassword = password;
            w.Status = status;
            w.DateStatusUpdated = DateTime.Now.ToString("yyyy-MM-dd");
            w.Notes = notes;
            w.update();
            MessageBox.Show("Modified Worker successfully.");
            this.Hide();
            MainMenu ourMainMenu = new MainMenu();
            ourMainMenu.Show();
        }

        //Cancel button goes back to Search Worker
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            SearchModifyWorker s = new SearchModifyWorker();
            s.Show();
            this.Hide();
        }

    }
}
