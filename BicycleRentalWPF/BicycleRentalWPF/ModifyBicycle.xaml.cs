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
    /// Interaction logic for ModifyBicycle.xaml
    /// </summary>
    public partial class ModifyBicycle : Window
    {
        Vehicle v;
        MainMenu myCaller;

        public ModifyBicycle(string i, MainMenu m)
        {
            myCaller = m;
            InitializeComponent();
            //populates our comboboxes
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
            //populates the vehicle instance with the corresponding bicycle data with the id provided as input
            v.populate(id);
            BikeMakeTextBox.Text = v.BikeMake;
            ModelNumberTextBox.Text = v.ModelNumber;
            SerialNumberTextBox.Text = v.SerialNumber;
            ColorTextBox.Text = v.Color;
            DescriptionTextBox.Text = v.Description;
            LocationTextBox.Text = v.Location;
            PhysicalConditionTextBox.Text = v.PhysicalCondition;
            NotesTextBox.Text = v.Notes;
            StatusBox.Text = v.Status;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            //extracts bicycle data from the textboxes
            String bm = BikeMakeTextBox.Text;
            String mn = ModelNumberTextBox.Text;
            String sn = SerialNumberTextBox.Text;
            String c = ColorTextBox.Text;
            String d = DescriptionTextBox.Text;
            String l = LocationTextBox.Text;
            String pc = PhysicalConditionTextBox.Text;
            String n = NotesTextBox.Text;
            String st = StatusBox.Text;

            //populates our bicycle instance with the extracted data
            v.BikeMake = bm;
            v.ModelNumber = mn;
            v.SerialNumber = sn;
            v.Color = c;
            v.Description = d;
            v.Location = l;
            v.PhysicalCondition = pc;
            v.Notes = n;
            v.Status = st;
            //updates the backend
            v.update();
            MessageBox.Show("Modified Vehicle successfully.");
            this.Hide();
            myCaller.Show();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SearchModifyBicycle d = new SearchModifyBicycle(myCaller);
            d.Show();
        }
    }
}
