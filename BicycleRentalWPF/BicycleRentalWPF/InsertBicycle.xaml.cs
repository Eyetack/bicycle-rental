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
    /// Interaction logic for InsertBicycle.xaml
    /// </summary>
    public partial class InsertBicycle : Window
    {
        MainMenu myCaller;

        //populates the Physical Condition and Location Comboboxes
        public InsertBicycle(MainMenu m)
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
        }

        //Submit button inserts Bicycle
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string bikeMakeText = BikeMakeTextBox.Text;
            string modelNumberText = ModelNumberTextBox.Text;
            string serialNumberText = SerialNumberTextBox.Text;
            string colorText = ColorTextBox.Text;
            string descriptionText = DescriptionTextBox.Text;
            string locationText = LocationTextBox.Text;
            string physicalConditionText = PhysicalConditionTextBox.Text;
            string notesText = NotesTextBox.Text;
            Vehicle newVehicle = new Vehicle(bikeMakeText, modelNumberText, serialNumberText, colorText,
                descriptionText, locationText, physicalConditionText, notesText);
            newVehicle.insert();
            BikeMakeTextBox.Clear();
            ModelNumberTextBox.Clear();
            SerialNumberTextBox.Clear();
            ColorTextBox.Clear();
            DescriptionTextBox.Clear();
            NotesTextBox.Clear();
            MessageBox.Show("Vehicle inserted successfully!");
            this.Hide();
            myCaller.Show();
        }

        //back button goes to main menu
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            myCaller.Show();
            this.Hide();
        }
    }
}
