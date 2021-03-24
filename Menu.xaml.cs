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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        //Button to Open up Cart
        private void Open_Cart(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Switcher.GetCart());
        }

        //Button to Open up Checkout
        private void Open_Checkout(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Switcher.GetCheckout());
        }

        //Button to Review Order
        private void Open_ReviewOrder(object sender, RoutedEventArgs e)
        {
            
        }

        //Button to Change Table Number
        private void Open_ChangeTable(object sender, RoutedEventArgs e)
        {

        }

        public Menu()
        {
            InitializeComponent();
        }
    }
}
