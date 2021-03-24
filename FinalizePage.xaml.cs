using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RestaurantOrderingSystem_481
{
    /// <summary>
    /// Interaction logic for FinalizePage.xaml
    /// </summary>
    public partial class FinalizePage : UserControl
    {
        public FinalizePage()
        {
            InitializeComponent();
        }

        private void OrderMore(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Switcher.GetMenu());
        }



    }
}
