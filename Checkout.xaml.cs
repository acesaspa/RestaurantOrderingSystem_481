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
            if (MainWindow.GlobalSubtotal != 0)
            {
                //Check if Order has Alcohol
                foreach (CheckoutItem child in Switcher.GetCheckout().CheckoutItemList.Children)
                {
                    if (child.checkout_item_alcohol == true)
                    {
                        MainWindow.hasAlcohol = true;
                    }
                }

                //Order has Alcohol
                if (MainWindow.hasAlcohol == true)
                {
                    Switcher.GetConfirmCheckout().OrderConfirmVerify.Text = "Enter Verification No. :";
                    Switcher.GetConfirmCheckout().VerifyNo.Visibility = Visibility.Visible;
                    Switcher.GetConfirmCheckout().VerifyBorder.Visibility = Visibility.Visible;
                    Switcher.GetConfirmCheckout().VerifyNo.Text = "";
                }
                else
                {
                    Switcher.GetConfirmCheckout().OrderConfirmVerify.Text = "";
                    Switcher.GetConfirmCheckout().VerifyNo.Visibility = Visibility.Hidden;
                    Switcher.GetConfirmCheckout().VerifyBorder.Visibility = Visibility.Hidden;
                    Switcher.GetConfirmCheckout().VerifyNo.Text = "1234";
                }

                Window window = new Window
                {
                    Title = "Confirm Checkout",
                    Content = Switcher.GetConfirmCheckout(),
                    Height = 400,
                    Width = 300
                };

                MainWindow.hasAlcohol = false;

                window.ShowDialog();
            }
            else {
                MessageBox.Show("Please order select our food items!");
            }

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

    }
}
