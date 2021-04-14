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

namespace RestaurantOrderingSystem_481
{
    /// <summary>
    /// Interaction logic for CartItem.xaml
    /// </summary>
    public partial class CartItem : UserControl
    {
        public int cart_item_counter;

        public string cart_special_request;

        public bool cart_alcohol;

        public bool SRLabel;

        public void RemoveItemCart(object sender, RoutedEventArgs e)
        {
            //var cartChildren = Switcher.GetCart().CartItemList.Children;

            foreach (CheckoutItem child in Switcher.GetCheckout().CheckoutItemList.Children)
            {
                if (child.checkout_item_counter == this.cart_item_counter)
                {
                    //Modify Prices
                    float price = float.Parse(this.ItemPrice.Text.Substring(1));
                    float priceTotal = price * float.Parse(this.ItemQuantity.Text);
                    MainWindow.GlobalSubtotal -= priceTotal;
                    string test = MainWindow.GlobalSubtotal.ToString("0.00");

                    Switcher.GetCart().CartMenuTotal.Text = ("$" + test);
                    Switcher.GetCheckout().Subtotal.Text = ("$" + test);
                    Switcher.GetNewMenu().MenuTotal.Text = ("$" + test);
                    Switcher.GetCheckout().GST.Text = "$" + (MainWindow.GlobalSubtotal * 0.1).ToString("0.00");
                    float gst = float.Parse(Switcher.GetCheckout().GST.Text.Substring(1));
                    float subtotal = float.Parse(Switcher.GetCheckout().Subtotal.Text.Substring(1));
                    Switcher.GetCheckout().Total.Text = "$" + (gst + subtotal).ToString("0.00");


                    Switcher.GetCheckout().CheckoutItemList.Children.Remove(child);
                    Switcher.GetCart().CartItemList.Children.Remove(this);
                    break;  //If we do not break, causes problems with enumerator since we are changing the list we are iterating over
                }
            }

        }

        //Increase Quantity
        private void IncreaseQuantityCart(object sender, RoutedEventArgs e)
        {
            try
            {
                int current = Int32.Parse(this.ItemQuantity.Text);
                current += 1;
                if (current > 1)
                {
                    DecreaseButton.Opacity = 100;
                }
                this.ItemQuantity.Text = (current).ToString();
                
                float price = float.Parse(this.ItemPrice.Text.Substring(1));
                MainWindow.GlobalSubtotal += price;

                string test = MainWindow.GlobalSubtotal.ToString("0.00");

                //Prices
                Switcher.GetCart().CartMenuTotal.Text = ("$" + test);
                Switcher.GetCheckout().Subtotal.Text = ("$" + test);
                Switcher.GetNewMenu().MenuTotal.Text = ("$" + test);
                Switcher.GetCheckout().GST.Text = "$" + (MainWindow.GlobalSubtotal * 0.1).ToString("0.00");
                float gst = float.Parse(Switcher.GetCheckout().GST.Text.Substring(1));
                float subtotal = float.Parse(Switcher.GetCheckout().Subtotal.Text.Substring(1));
                Switcher.GetCheckout().Total.Text = "$" + (gst+subtotal).ToString("0.00");

                foreach (CheckoutItem child in Switcher.GetCheckout().CheckoutItemList.Children)
                {
                    if (child.checkout_item_counter == this.cart_item_counter)
                    {
                        child.checkout_item_quantity = (current).ToString();
                        child.CheckoutItemQuantity.Text = (current).ToString();
                        if (child.CheckoutItemQuantity.Text == "1")
                        {
                            child.DecreaseButton.Opacity = 0;
                        }
                        else
                        {
                            child.DecreaseButton.Opacity = 1;
                        }
                        break;  //If we do not break, causes problems with enumerator since we are changing the list we are iterating over
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("broken");
            }
        }

        private void DecreaseQuantityCart(object sender, RoutedEventArgs e)
        {
            try
            {
                int current = Int32.Parse(this.ItemQuantity.Text);

                if (current != 1)
                {

                    current -= 1;

                    this.ItemQuantity.Text = (current).ToString();

                    float price = float.Parse(this.ItemPrice.Text.Substring(1));
                    MainWindow.GlobalSubtotal -= price;

                    string test = MainWindow.GlobalSubtotal.ToString("0.00");

                    Switcher.GetCart().CartMenuTotal.Text = ("$" + test);
                    Switcher.GetCheckout().Subtotal.Text = ("$" + test);
                    Switcher.GetNewMenu().MenuTotal.Text = ("$" + test);
                    Switcher.GetCheckout().GST.Text = "$" + (MainWindow.GlobalSubtotal * 0.1).ToString("0.00");
                    float gst = float.Parse(Switcher.GetCheckout().GST.Text.Substring(1));
                    float subtotal = float.Parse(Switcher.GetCheckout().Subtotal.Text.Substring(1));
                    Switcher.GetCheckout().Total.Text = "$" + (gst + subtotal).ToString("0.00");

                    foreach (CheckoutItem child in Switcher.GetCheckout().CheckoutItemList.Children)
                    {
                        if (child.checkout_item_counter == this.cart_item_counter)
                        {
                            child.checkout_item_quantity = (current).ToString();
                            child.CheckoutItemQuantity.Text = (current).ToString();
                            if (child.CheckoutItemQuantity.Text == "1")
                            {
                                child.DecreaseButton.Opacity = 0;
                            }
                            else
                            {
                                child.DecreaseButton.Opacity = 1;
                            }
                            break;  //If we do not break, causes problems with enumerator since we are changing the list we are iterating over
                        }
                    }
                }
                else
                {
                    current = 1;
                }

                if (current == 1)
                {
                    DecreaseButton.Opacity = 0;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("broken");
            }
        }

        public CartItem()
        {
            InitializeComponent();
        }
    }
}
