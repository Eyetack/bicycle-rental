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

        public ModifyBicycle(string i)
        {
            InitializeComponent();
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
    }
}
