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
    /// Interaction logic for AddingItem.xaml
    /// </summary>
    public partial class ItemAddition : UserControl
    {

        // Item Name
        public string ia_item_name;

        // Item Description
        public string ia_item_description;

        // Item Price
        public float ia_item_price;

        //Increase Quantity
        private void IncreaseQuantity(object sender, RoutedEventArgs e)
        {
            try
            {
                int current = Int32.Parse(DisplayItemQuantity.Text);
                DisplayItemQuantity.Text = (current + 1).ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("broken");
            }
        }

        //Increase Quantity
        private void DecreaseQuantity(object sender, RoutedEventArgs e)
        {
            try
            {

                int current = Int32.Parse(DisplayItemQuantity.Text);
                if(current != 1)
                {
                    DisplayItemQuantity.Text = (current - 1).ToString();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("broken");
            }
        }

        private void AddToCart(object sender, RoutedEventArgs e)
        {
            CartItem cartItem = new CartItem();
            cartItem.cart_item_counter = MainWindow.GlobalCounter;
            MainWindow.GlobalCounter++;
            cartItem.ItemName.Text = DisplayItemName.Text;
            cartItem.ItemPrice.Text = DisplayItemPrice.Text;
            cartItem.ItemQuantity.Text = DisplayItemQuantity.Text;


            Switcher.GetCart().CartItemList.Children.Add(cartItem);
            AddToCheckout(sender, e, cartItem);
            string tempPrice = cartItem.ItemPrice.Text.Substring(1);
            float price = float.Parse(tempPrice);
            float total = price * (float.Parse(cartItem.ItemQuantity.Text));
            MainWindow.GlobalSubtotal += total;

            string test = MainWindow.GlobalSubtotal.ToString("0.00");

            //Prices
            Switcher.GetCart().CartMenuTotal.Text = "$" + test;
            Switcher.GetCheckout().Subtotal.Text = ("$" + test);
            Switcher.GetNewMenu().MenuTotal.Text = ("$" + test);
            Switcher.GetCheckout().GST.Text = "$" + (MainWindow.GlobalSubtotal * 0.1).ToString("0.00");
            float gst = float.Parse(Switcher.GetCheckout().GST.Text.Substring(1));
            float subtotal = float.Parse(Switcher.GetCheckout().Subtotal.Text.Substring(1));
            Switcher.GetCheckout().Total.Text = "$" + (gst + subtotal).ToString("0.00");

            Close_ItemAddition(sender, e);
        }

        private void AddToCheckout(object sender, RoutedEventArgs e, CartItem cartItem)
        {
            CheckoutItem checkoutItem = new CheckoutItem();
            checkoutItem.checkout_item_counter = cartItem.cart_item_counter;
            checkoutItem.CheckoutItemName.Text = cartItem.ItemName.Text;
            checkoutItem.CheckoutItemQuantity.Text = cartItem.ItemQuantity.Text;
            checkoutItem.CheckoutItemPrice.Text = cartItem.ItemPrice.Text;

            Switcher.GetCheckout().CheckoutItemList.Children.Add(checkoutItem);
        }

        public void Close_ItemAddition(object sender, RoutedEventArgs e)
        {
            var parent = this.Parent as Window;
            if (parent != null)
            {
                parent.DialogResult = true;
                parent.Close();
            }
        }

        //public ItemAddition(MenuItem menuItem)
        //{
        //    this.ia_item_name = menuItem.ItemName.Text;
        //    this.ia_item_description = menuItem.ItemDescription.Text;
        //    this.ia_item_price = float.Parse(menuItem.ItemPrice.Text);
        //    ItemAddition showItem = new ItemAddition(this);
        //    showItem.DisplayItemName.Text = this.ItemName.Text;
        //    showItem.DisplayItemDescription.Text = this.ItemDescription.Text;
        //    showItem.DisplayItemPrice.Text = this.ItemPrice.Text;
        //}

        public ItemAddition()
        {
            InitializeComponent();
        }
    }
}
