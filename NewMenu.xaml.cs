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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading.Tasks;
using System.Threading;

namespace RestaurantOrderingSystem_481
{
    /// <summary>
    /// Interaction logic for NewMenu.xaml
    /// </summary>
    public partial class NewMenu : UserControl
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
            Switcher.Switch(Switcher.GetFinalize());
        }

        //Button to Change Table Number
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

        // Button to call server
        async public void Open_CallServer(object sender, RoutedEventArgs e)
        {

            Window window = new Window
            {
                Title = "Call Server",
                Content = Switcher.GetSuccessServer(),
                Height = 200,
                Width = 200
            };

            //this.IsEnabled = false;

            window.Show();

            await Task.Run(() =>
            {

                Thread.Sleep(4000);

            });

            window.Close();
            //this.IsEnabled = true;

        }


        public NewMenu()
        {
            InitializeComponent();
        }
    }
}
