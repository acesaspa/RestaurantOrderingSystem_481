using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /***************************
            Variable Declarations:
        ***************************/

        public static int TableNumber;

        /***************************
            Big Data: 15 Items
        ***************************/

        MenuItem item1 = new MenuItem( "Spaghetti", "Pasta with sauce", 2.99f);
        MenuItem item2 = new MenuItem( "Sandwhich", "Bacon, Eggs, Lettuce", 5.99f);
        MenuItem item3 = new MenuItem( "Fries", "No Sauce", 1.99f);

        public MainWindow()
        {

            InitializeComponent();

            //CategoryDivider divider = new CategoryDivider();
            //divider.TabName.Content = "~ Appetizer ~";
            //Switcher.GetMenu().MenuItemList.Children.Add(divider);

            //All our menu items
            //List<MenuItem> FullMenu = new List<MenuItem>();
            //MenuItem test = new MenuItem();
            //FullMenu.Add(test);

            //New Menu Appetisers
            //for (int i = 0; i < 15; i++)
            //{
                //Switcher.GetNewMenu().AppetisersList.Children.Add(menuItem);
            //}

            //Working Menu
            //for ()


            //Checkout Items
            //List<CheckoutItem> FullCheckout = new List<CheckoutItem>();
            CheckoutItem testCO = new CheckoutItem();
            //FullCheckout.Add(testCO);

            //Testing adding to checkout
            for (int i = 0; i < 4; i++)
            {
                CheckoutItem checkoutItem = new CheckoutItem();
                checkoutItem.CheckoutItemName.Content = "Spaghetti Rigatoni Davinci " + i.ToString();
                checkoutItem.CheckoutItemQuantity.Content = "1";
                checkoutItem.CheckoutItemPrice.Content = "$5.99";
                Switcher.GetCheckout().CheckoutItemList.Children.Add(checkoutItem);
            }

            //Cart Items
            List<CartItem> FullCart = new List<CartItem>();
            CartItem testCI = new CartItem();
            FullCart.Add(testCI);

            //Testing adding to Cart
            for (int i = 0; i < 4; i++)
            {
                CartItem cartItem = new CartItem();
                cartItem.ItemName.Content = "Spaghetti Rigatoni Davinci " + i.ToString();
                cartItem.ItemQuantity.Content = "1";
                cartItem.ItemPrice.Content = "$5.99";
                Switcher.GetCart().CartItemList.Children.Add(cartItem);
            }

            //Review Order Items
            List<ReviewOrderItem> FullReview = new List<ReviewOrderItem>();
            ReviewOrderItem testRO = new ReviewOrderItem();
            FullReview.Add(testRO);

            //Testing adding to Review Order
            for (int i = 0; i < 4; i++)
            {
                ReviewOrderItem reviewOrderItem = new ReviewOrderItem();
                reviewOrderItem.ReviewOrderItemName.Content = "Spaghetti Rigatoni Davinci " + i.ToString();
                reviewOrderItem.ReviewOrderItemQuantity.Content = "1";
                reviewOrderItem.ReviewOrderItemPrice.Content = "$5.99";
                Switcher.GetReviewOrder().ReviewItemList.Children.Add(reviewOrderItem);
            }

            Switcher.pageSwitcher = this;
            Switcher.Switch(Switcher.GetLanding());

        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

    }
}
