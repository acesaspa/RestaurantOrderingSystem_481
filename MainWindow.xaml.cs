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

            /***************************
                Big Data: 15 Items
            ***************************/

            /* 
             * Items from:
             * https://littlecaesars.ca/en-ca/order/pickup/stores/4047/menu
             * https://orderve.menu/menu/una-pizza-17th-1607978767006x175589733865881600?view=cat&menu=1607979445096x703551211714641900
             */

            MenuItem crazybreadItem = new MenuItem("Crazy Bread", "Greasy Bread", 5.99f, "/Resources/crazybread.jpg");
            MenuItem stuffedcrazybreadItem = new MenuItem("Stuffed Crazy Bread", "", 6.99f, "/Resources/stuffedcrazybread.jpg");

            MenuItem hawaiianItem = new MenuItem("Hawaiian Pizza", "Pineapple, Cheese, Tomato Sauce", 11.99f, "/Resources/hawaiian.jpg");
            MenuItem bbqChickenItem = new MenuItem("BBQ Chicken Pizza", "Chicken, Cheese, Tomato Sauce", 14.99f, "/Resources/bbqchicken.jpg");
            MenuItem meat3Item = new MenuItem("3 Meat Pizza", "Meat", 14.99f, "/Resources/3meat.jpg");
            MenuItem canadianItem = new MenuItem("Canadian Pizza", "Mushrooms", 13.99f, "/Resources/canadian.jpg");
            MenuItem ultimateItem = new MenuItem("Ultimate Supreme Pizza", "Supreme.. enough said", 199.99f, "/Resources/ultimatesupreme.jpg");
            MenuItem veggieItem = new MenuItem("Veggie Pizza", "Cow Food", 1.99f, "/Resources/veggie.jpg");
            MenuItem pepperoniItem = new MenuItem("Pepperoni Pizza", "Pepperoni", 12.99f, "/Resources/pepperoni.jpg");
            MenuItem cheeseItem = new MenuItem("Cheese Pizza", "Cheese", 10.99f, "/Resources/cheese.jpg");

            MenuItem pottedvanillacheesecakeItem = new MenuItem("Potted Vanilla Cheesecake", "Coconut sponge toffee + seed crust, raspberry compote", 9.99f, "/Resources/pottedvanillacheesecake.png");

            MenuItem waterItem = new MenuItem("Water", "Water", 0.99f, "Resources/water.jpg");

            MenuItem spicycheddardipItem = new MenuItem("Spicy Cheddar Dip", "", 1.99f, "/Resources/spicycheddardip.jpg");
            MenuItem bbqranchdipItem = new MenuItem("BBQ Ranch Dip", "", 1.99f, "/Resources/bbqranchdip.jpg");
            MenuItem creamygarlicdipItem = new MenuItem("Creamy Garlic Dip", "", 1.99f, "/Resources/creamygarlicdip.jpg");
            MenuItem ranchDipItem = new MenuItem("Ranch Dip", "", 1.99f, "/Resources/ranchdip.jpg");

            //Working Menu
            Switcher.GetNewMenu().AppetisersList.Children.Add(crazybreadItem);
            Switcher.GetNewMenu().AppetisersList.Children.Add(stuffedcrazybreadItem);

            Switcher.GetNewMenu().EntreesList.Children.Add(hawaiianItem);
            Switcher.GetNewMenu().EntreesList.Children.Add(bbqChickenItem);
            Switcher.GetNewMenu().EntreesList.Children.Add(meat3Item);
            Switcher.GetNewMenu().EntreesList.Children.Add(canadianItem);
            Switcher.GetNewMenu().EntreesList.Children.Add(ultimateItem);
            Switcher.GetNewMenu().EntreesList.Children.Add(veggieItem);
            Switcher.GetNewMenu().EntreesList.Children.Add(pepperoniItem);
            Switcher.GetNewMenu().EntreesList.Children.Add(cheeseItem);

            Switcher.GetNewMenu().DessertsList.Children.Add(pottedvanillacheesecakeItem);

            Switcher.GetNewMenu().DrinksList.Children.Add(waterItem);

            Switcher.GetNewMenu().SidesList.Children.Add(spicycheddardipItem);
            Switcher.GetNewMenu().SidesList.Children.Add(bbqranchdipItem);
            Switcher.GetNewMenu().SidesList.Children.Add(creamygarlicdipItem);
            Switcher.GetNewMenu().SidesList.Children.Add(ranchDipItem);

            //Checkout Items
            List<CheckoutItem> FullCheckout = new List<CheckoutItem>();

            //Cart Items
            List<CartItem> FullCart = new List<CartItem>();

            //Testing adding to checkout
            //for (int i = 0; i < 4; i++)
            //{
            //    CheckoutItem checkoutItem = new CheckoutItem();
            //    checkoutItem.CheckoutItemName.Content = "Spaghetti Rigatoni Davinci " + i.ToString();
            //    checkoutItem.CheckoutItemQuantity.Content = "1";
            //    checkoutItem.CheckoutItemPrice.Content = "$5.99";
            //    Switcher.GetCheckout().CheckoutItemList.Children.Add(checkoutItem);
            //}

            //Testing adding to Cart
            //for (int i = 0; i < 4; i++)
            //{
            //    CartItem cartItem = new CartItem();
            //    cartItem.ItemName.Content = "Spaghetti Rigatoni Davinci " + i.ToString();
            //    cartItem.ItemQuantity.Content = "1";
            //    cartItem.ItemPrice.Content = "$5.99";
            //    Switcher.GetCart().CartItemList.Children.Add(cartItem);
            //}

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
