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
    /// Interaction logic for DeleteBicycle.xaml
    /// </summary>
    public partial class DeleteBicycle : Window
    {
        Vehicle v;
        MainMenu myCaller;

         public DeleteBicycle(string i, MainMenu m)
        {
            myCaller = m;
            InitializeComponent();
            PhysicalConditionTextBox.Items.Add("Good");
            PhysicalConditionTextBox.Items.Add("Damaged");
            LocationTextBox.Items.Add("Benedict");
            LocationTextBox.Items.Add("Brockway");
            LocationTextBox.Items.Add("Harmon");
            LocationTextBox.Items.Add("McFarlane");
            LocationTextBox.Items.Add("Mortimer");
            LocationTextBox.Items.Add("Seymour College Union");
            LocationTextBox.Items.Add("Thompson");
            LocationTextBox.Items.Add("Townhomes");
            LocationTextBox.Items.Add("Tuttle");
            LocationTextBox.Items.Add("Welcome Center");
            StatusBox.Items.Add("Active");
            StatusBox.Items.Add("Inactive");
            int id = Convert.ToInt32(i);
            v = new Vehicle();
            v.populate(id);
            BikeMakeTextBox.Text = v.BikeMake;
            ModelNumberTextBox.Text = v.ModelNumber;
            SerialNumberTextBox.Text = v.SerialNumber;
            ColorTextBox.Text = v.Color;
            DescriptionTextBox.Text = v.Description;
            LocationTextBox.Text = v.Location;
        }

         private void SubmitButton_Click(object sender, RoutedEventArgs e)
         {
             v.delete();
             MessageBox.Show("Deleted Vehicle successfully.");
             this.Hide();
             myCaller.Show();
         }

         private void CancelButton_Click(object sender, RoutedEventArgs e)
         {
             SearchDeleteBicycle d = new SearchDeleteBicycle(myCaller);
             d.Show();
             this.Hide();
         }
    }
}
