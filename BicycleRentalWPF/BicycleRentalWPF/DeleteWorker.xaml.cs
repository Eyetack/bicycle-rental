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
    /// Interaction logic for DeleteWorker.xaml
    /// </summary>
    public partial class DeleteWorker : Window
    {
        Worker w;
        MainMenu myCaller;

        //Getting the data and filling the text boxes 
        public DeleteWorker(String b, MainMenu m)
        {
            myCaller = m;
            InitializeComponent();

            CredentialBox.Items.Add("Administrator");
            CredentialBox.Items.Add("Ordinary");
            StatusBox.Items.Add("Active");
            StatusBox.Items.Add("Inactive");

            int banner = Convert.ToInt32(b);
            w = new Worker(b, "", "", "", "", "", "", "");
            w.populate(banner);
            BannerBox.Text = w.BannerID;
            FirstNameBox.Text = w.FirstName;
            LastNameBox.Text = w.LastName;
            PhoneBox.Text = w.PhoneNumber;
            EmailBox.Text = w.EmailAddress;
            CredentialBox.Text = w.Credential;
            InitialRegBox.Text = w.InitialRegistrationDate;
            PasswordBox.Password = w.WorkerPassword;
            StatusBox.Text = w.Status;
            StatusUpdatedBox.Text = w.DateStatusUpdated;
            NotesBox.Text = w.Notes;
        }

        //Submit button deletes worker
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            
            w.delete();
            MessageBox.Show("Worker deleted successfully.");
        }

        //Cancel button goes back to Search Worker 
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            SearchDeleteWorker d = new SearchDeleteWorker(myCaller);
            d.Show();
            this.Hide();
        }
    }
}
