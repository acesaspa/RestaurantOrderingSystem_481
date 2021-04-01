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
    /// Interaction logic for Checkout.xaml
    /// </summary>
    public partial class Checkout : UserControl
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void Open_Menu(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Switcher.GetNewMenu());
        }
        private void Open_Finalized(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Switcher.GetFinalize());
        }

        private void Update_Values(object sender, RoutedEventArgs e)
        {
            //var subtotal = 0;
            foreach(object child in CheckoutItemList.Children)
            {
                string childname = null;
                if (child is FrameworkElement)
                {
                    childname = (child as FrameworkElement).Name;
                }

                if(childname != null)
                {

                }
            }
        }
    }
}
