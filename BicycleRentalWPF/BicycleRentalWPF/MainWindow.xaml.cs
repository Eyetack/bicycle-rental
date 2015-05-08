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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BicycleRentalWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //initializes the login window
        public MainWindow()
        {
            InitializeComponent();
        }

        //Terminates the program
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        //Starts the login process to the application
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            //login workflow here
            Worker w = new Worker();
            String b = BannerBox.Text;
            String p = PasswordBox.Password;
            
            try
            {
                int banner = Convert.ToInt32(b); 
                w.populate(banner);
                if (w.BannerID.Equals(b) && w.WorkerPassword.Equals(p))
                {
                    MainMenu m = new MainMenu(w);
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter a valid ID and/or Password");
                    BannerBox.Clear();
                    PasswordBox.Clear();
                }
            }
            catch (Exception ex)
            {
                String et  = ex.Message;
                MessageBox.Show("Please enter valid id and/or password");
                BannerBox.Clear();
                PasswordBox.Clear();
            }
        }
    }
}
