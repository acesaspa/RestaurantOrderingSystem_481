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

        public string checkout_item_name;
        public string checkout_item_quantity;
        public string checkout_item_price;


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

        public CheckoutItem(CartItem cartItem)
        {

        }

        public CheckoutItem()
        {
            InitializeComponent();
        }
    }
}
