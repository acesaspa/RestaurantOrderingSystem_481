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
    /// Interaction logic for Cart.xaml
    /// </summary>
    public partial class Cart : UserControl
    {
        public Cart()
        {
            InitializeComponent();
        }
        private void Open_Checkout(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Switcher.GetCheckout());
        }
        private void Open_Menu(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Switcher.GetNewMenu());
        }
        private void Open_ChangeTable(object sender, RoutedEventArgs e)
        {
            Window window = new Window
            {
                Title = "Change Table",
                Content = Switcher.GetChangeTable(),
                Height = 200,
                Width = 200
            };

            window.ShowDialog();

        }
        private void Open_ReviewOrder(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Switcher.GetFinalize());
        }
    }
}
