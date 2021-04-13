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
    /// Interaction logic for CheckoutItem.xaml
    /// </summary>
    public partial class CheckoutItem : UserControl
    {

        /***************************
         
            Variable Declarations:
         
        ***************************/

        public int checkout_item_counter;

        public string checkout_special_request;

        public string checkout_item_name;
        public string checkout_item_quantity;
        public string checkout_item_price;

        public bool checkout_item_alcohol;


        /***************************

             Getters & Setters:

        ***************************/

        // Item Name (CheckoutItemName)

        public string Checkout_item_name
        {
            get { return checkout_item_name; }
            set
            {
                checkout_item_name = value;
                this.CheckoutItemName.Text = this.checkout_item_name;
            }
        }

        // Item Name (CheckoutItemQuantity)

        public string Checkout_item_quantity
        {
            get { return checkout_item_quantity; }
            set
            {
                checkout_item_quantity = value;
                this.CheckoutItemQuantity.Text = this.checkout_item_quantity;
            }
        }

        // Item Name (CheckoutItemPrice)

        public string Checkout_item_price
        {
            get { return checkout_item_price; }
            set
            {
                checkout_item_price = value;
                this.CheckoutItemPrice.Text = this.checkout_item_price;
            }
        }

        public void RemoveItemCheckout(object sender, RoutedEventArgs e)
        {
            //var cartChildren = Switcher.GetCart().CartItemList.Children;
            foreach (CartItem child in Switcher.GetCart().CartItemList.Children)
            {
                if(child.cart_item_counter == this.checkout_item_counter)
                {
                    //Modify Prices
                    float price = float.Parse(this.CheckoutItemPrice.Text.Substring(1));
                    float priceTotal = price * float.Parse(this.CheckoutItemQuantity.Text);
                    MainWindow.GlobalSubtotal -= priceTotal;
                    string test = MainWindow.GlobalSubtotal.ToString("0.00");

                    Switcher.GetCart().CartMenuTotal.Text = ("$" + test);
                    Switcher.GetCheckout().Subtotal.Text = ("$" + test);
                    Switcher.GetNewMenu().MenuTotal.Text = ("$" + test);
                    Switcher.GetCheckout().GST.Text = "$" + (MainWindow.GlobalSubtotal * 0.1).ToString("0.00");
                    float gst = float.Parse(Switcher.GetCheckout().GST.Text.Substring(1));
                    float subtotal = float.Parse(Switcher.GetCheckout().Subtotal.Text.Substring(1));
                    Switcher.GetCheckout().Total.Text = "$" + (gst + subtotal).ToString("0.00");


                    Switcher.GetCart().CartItemList.Children.Remove(child);
                    Switcher.GetCheckout().CheckoutItemList.Children.Remove(this);
                    break;  //If we do not break, causes problems with enumerator since we are changing the list we are iterating over
                }
            }


        }

        //Increase Quantity
        private void IncreaseQuantityCheckout(object sender, RoutedEventArgs e)
        {
            try
            {
                int current = Int32.Parse(this.CheckoutItemQuantity.Text);

                current += 1;
                if (current > 1)
                {
                    DecreaseButton.Opacity = 100;
                }

                this.CheckoutItemQuantity.Text = (current).ToString();

                float price = float.Parse(this.CheckoutItemPrice.Text.Substring(1));
                MainWindow.GlobalSubtotal += price;

                string test = MainWindow.GlobalSubtotal.ToString("0.00");

                //Prices
                Switcher.GetCart().CartMenuTotal.Text = ("$" + test);
                Switcher.GetCheckout().Subtotal.Text = ("$" + test);
                Switcher.GetNewMenu().MenuTotal.Text = ("$" + test);
                Switcher.GetCheckout().GST.Text = "$" + (MainWindow.GlobalSubtotal * 0.1).ToString("0.00");
                float gst = float.Parse(Switcher.GetCheckout().GST.Text.Substring(1));
                float subtotal = float.Parse(Switcher.GetCheckout().Subtotal.Text.Substring(1));
                Switcher.GetCheckout().Total.Text = "$" + (gst + subtotal).ToString("0.00");

                foreach (CartItem child in Switcher.GetCart().CartItemList.Children)
                {
                    if (child.cart_item_counter == this.checkout_item_counter)
                    {
                        child.ItemQuantity.Text = (current).ToString();
                        if (child.ItemQuantity.Text == "1")
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

        //Increase Quantity
        private void DecreaseQuantityCheckout(object sender, RoutedEventArgs e)
        {
            try
            {
                int current = Int32.Parse(this.CheckoutItemQuantity.Text);
                if (current != 1)
                {
                    current -= 1;
                    this.CheckoutItemQuantity.Text = (current).ToString();

                    float price = float.Parse(this.CheckoutItemPrice.Text.Substring(1));
                    MainWindow.GlobalSubtotal -= price;

                    string test = MainWindow.GlobalSubtotal.ToString("0.00");

                    Switcher.GetCart().CartMenuTotal.Text = ("$" + test);
                    Switcher.GetCheckout().Subtotal.Text = ("$" + test);
                    Switcher.GetNewMenu().MenuTotal.Text = ("$" + test);
                    Switcher.GetCheckout().GST.Text = "$" + (MainWindow.GlobalSubtotal * 0.1).ToString("0.00");
                    float gst = float.Parse(Switcher.GetCheckout().GST.Text.Substring(1));
                    float subtotal = float.Parse(Switcher.GetCheckout().Subtotal.Text.Substring(1));
                    Switcher.GetCheckout().Total.Text = "$" + (gst + subtotal).ToString("0.00");

                    foreach (CartItem child in Switcher.GetCart().CartItemList.Children)
                    {
                        if (child.cart_item_counter == this.checkout_item_counter)
                        {
                            child.ItemQuantity.Text = (current).ToString();
                            if (child.ItemQuantity.Text == "1")
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

        public CheckoutItem()
        {
            InitializeComponent();
        }
    }
}
