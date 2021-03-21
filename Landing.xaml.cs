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
    /// Interaction logic for Landing.xaml
    /// </summary>
    public partial class Landing : UserControl
    {

        public Landing()
        {
            InitializeComponent();
        }
        //Button to Open up Menu
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Menu());
            //MessageBox.Show("Hello, world!");
        }
    }
}
