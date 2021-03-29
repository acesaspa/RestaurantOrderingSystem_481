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
    /// Interaction logic for ReviewOrderItem.xaml
    /// </summary>
    public partial class ReviewOrderItem : UserControl
    {

        /***************************

                    Variable Declarations:

                ***************************/

        public string review_item_name;
        public string review_item_quantity;
        public string review_item_price;


        /***************************

             Getters & Setters:

        ***************************/

        // Item Name (CheckoutItemName)

        public string Review_item_name
        {
            get { return review_item_name; }
            set
            {
                review_item_name = value;
                this.ReviewOrderItemName.Content = this.review_item_name;
            }
        }

        // Item Name (CheckoutItemQuantity)

        public string Review_item_quantity
        {
            get { return review_item_quantity; }
            set
            {
                review_item_quantity = value;
                this.ReviewOrderItemQuantity.Content = this.review_item_quantity;
            }
        }

        // Item Name (CheckoutItemPrice)

        public string Review_item_price
        {
            get { return review_item_price; }
            set
            {
                review_item_price = value;
                this.ReviewOrderItemPrice.Content = this.review_item_price;
            }
        }

        public ReviewOrderItem()
        {
            InitializeComponent();
        }
    }
}
