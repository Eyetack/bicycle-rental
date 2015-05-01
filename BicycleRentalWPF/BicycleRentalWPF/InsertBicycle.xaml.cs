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
        public InsertBicycle()
        {
            InitializeComponent();
        }

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
            LocationTextBox.Clear();
            PhysicalConditionTextBox.Clear();
            NotesTextBox.Clear();
            MessageBox.Show("Vehicle inserted successfully!");
            this.Hide();
            MainMenu ourMainMenu = new MainMenu();
            ourMainMenu.Show();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            this.Hide();
        }
    }
}
