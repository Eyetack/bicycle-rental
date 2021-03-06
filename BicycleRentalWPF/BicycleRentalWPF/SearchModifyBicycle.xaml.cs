﻿using System;
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
    /// Interaction logic for SearchModifyBicycle.xaml
    /// </summary>
    public partial class SearchModifyBicycle : Window
    {
        MainMenu myCaller;
        public SearchModifyBicycle( MainMenu m)
        {
            myCaller = m;
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            String id = IdBox.Text;
            ModifyBicycle m = new ModifyBicycle(id, myCaller);
            m.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            myCaller.Show();
            this.Hide();
        }
    }
}
