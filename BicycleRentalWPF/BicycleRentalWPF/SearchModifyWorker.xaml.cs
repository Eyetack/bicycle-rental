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
    /// Interaction logic for SearchModifyWorker.xaml
    /// </summary>
    public partial class SearchModifyWorker : Window
    {
        MainMenu myCaller;
        public SearchModifyWorker(MainMenu m)
        {
            myCaller = m;
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            String banner = BannerBox.Text;
            ModifyWorker m = new ModifyWorker(banner, myCaller);
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
