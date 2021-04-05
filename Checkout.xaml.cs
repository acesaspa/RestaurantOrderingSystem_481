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
            Confirm_Order(sender, e);
            Switcher.Switch(Switcher.GetFinalize());
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

        private void Confirm_Order(object sender, RoutedEventArgs e)
        {
            foreach (CheckoutItem child in Switcher.GetCheckout().CheckoutItemList.Children)
            {
                ReviewOrderItem reviewOrderItem = new ReviewOrderItem();
                reviewOrderItem.ReviewOrderItemName.Text = child.CheckoutItemName.Text;
                reviewOrderItem.ReviewOrderItemPrice.Text = child.CheckoutItemPrice.Text;
                reviewOrderItem.ReviewOrderItemQuantity.Text = child.CheckoutItemQuantity.Text;

                Switcher.GetReviewOrder().ReviewItemList.Children.Add(reviewOrderItem);
            }

            //Clear Checkout and Cart
            Switcher.GetCheckout().CheckoutItemList.Children.Clear();
            Switcher.GetCart().CartItemList.Children.Clear();
        }

    }
}
