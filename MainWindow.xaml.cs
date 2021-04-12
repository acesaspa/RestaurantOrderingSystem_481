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
        public static float GlobalSubtotal = 0;
        public static int GlobalCounter = 0;
        public static float GST = 0.1f; //10%
        public static bool hasAlcohol = false;
        public static bool checkoutEmpty = true;

        public MainWindow()
        {

            InitializeComponent();

            /***************************
                Big Data: 15 Items
            ***************************/

            /* 
             * Items from:
             * https://littlecaesars.ca/en-ca/order/pickup/stores/4047/menu
             * https://orderve.menu/menu/una-pizza-17th-1607978767006x175589733865881600?view=cat&menu=1607979445096x703551211714641900
             * https://earls.ca/locations/16th-ave/menu/
             */

            // Spicy, Peanut, Gluten, Vegetarian
            //MenuItem cowboyBurgerItem = new MenuItem("", "", 17.99f, "", false, false, false, false, false); spice, peanut, gluten, veggie, alcohol

            MenuItem prawnGyozaItem = new MenuItem("Prawn Gyoza", "Tender prawns, spring onion, ginger, citrus soy", 17.99f, "/Resources/PrawnGyoza.png", false, false, true, false, false);
            MenuItem crazybreadItem = new MenuItem("Crazy Bread", "Eight bread sticks with flavours of butter and garlic, then sprinkled with parmesan style cheese", 5.99f, "/Resources/crazybread.jpg", false, false, false, false, true);
            MenuItem stuffedcrazybreadItem = new MenuItem("Stuffed Crazy Bread", "4 bread sticks stuffed with mozzarella cheese and topped with flavours of butter and garlic then sprinkled with parmesan style cheese", 6.99f, "/Resources/stuffedcrazybread.jpg", false, false, false, false, false);

            MenuItem canadianPrimeSirloinItem = new MenuItem("Canadian Prime Sirloin", "Served with buttery garlic mashed potatoes and seasonal vegetables", 30.99f, "/Resources/CanadianPrimeSirloin.png", false, true, true, false, false);
            MenuItem cowboyBurgerItem = new MenuItem("Cowboy Burger", "Tomatoes, onion, lettuce, pickles, mayonnaise and mustard, on a toasted bun", 17.99f, "/Resources/CowboyBurger.png", false, true, false, false, false);
            MenuItem salmonFetaCaperAioliItem = new MenuItem("Salmon + Feta Caper Aioli", "Oven roasted salmon, jasmine rice and seasonal vegetables", 25.99f, "/Resources/SalmonFetaCaperAioli.png", false, true, true, false, false);
            MenuItem blackenedChickenItem = new MenuItem("Blackened Chicken", "Blackened full breast of chicken, garlic butter, warm potato salad, smoky bacon, coleslaw", 27.99f, "/Resources/BlackenedChicken.png", false, false, true, false, false);
            //MenuItem hawaiianItem = new MenuItem("Hawaiian Pizza", "Round pizza with Ham and Pineapple", 11.99f, "/Resources/hawaiian.jpg", false, false, false, false, false);
            //MenuItem bbqChickenItem = new MenuItem("BBQ Chicken Pizza", "Round pizza with BBQ Sauce, Chicken, Red Onions and Oregano", 14.99f, "/Resources/bbqchicken.jpg", false, false, false, false, false);
            //MenuItem meat3Item = new MenuItem("3 Meat Pizza", "Round pizza with Pepperoni, Italian Sausage and Bacon", 14.99f, "/Resources/3meat.jpg", false, false, false, false, false);
            //MenuItem canadianItem = new MenuItem("Canadian Pizza", "Round pizza with Pepperoni, Bacon and Mushrooms", 13.99f, "/Resources/canadian.jpg", false, false, false, false, false);
            MenuItem ultimateItem = new MenuItem("Ultimate Supreme Pizza", "Round pizza with Pepperoni, Italian Sausage, Mushrooms, Green Peppers and Onions", 199.99f, "/Resources/ultimatesupreme.jpg", false, false, false, false, false);
            //MenuItem veggieItem = new MenuItem("Veggie Pizza", "Round pizza with Pepperoni, Italian Sausage, Mushrooms, Green Peppers and Onions", 1.99f, "/Resources/veggie.jpg", false, false, false, true, false);
            MenuItem pepperoniItem = new MenuItem("Classic Pepperoni Pizza", "Round pizza with Pepperoni.", 12.99f, "/Resources/pepperoni.jpg", false, false, false, false, false);
            //MenuItem cheeseItem = new MenuItem("Classic Cheese Pizza", "Round pizza with just cheese", 10.99f, " /Resources/cheese.jpg", false, false, true, true, false);

            MenuItem pottedvanillacheesecakeItem = new MenuItem("Potted Vanilla Cheesecake", "Coconut sponge toffee + seed crust, raspberry compote", 9.99f, "/Resources/pottedvanillacheesecake.png", false, true, false, false, false);
            MenuItem stickyToffeeChocolatePuddingItem = new MenuItem("Sticky Toffee Chocolate Pudding", "Warm pudding cake, chocolate and toffee sauces, vanilla ice cream, maple crumble", 10.99f, "/Resources/StickyToffeeChocolatePudding.png", false, false, false, true, false);

            MenuItem waterItem = new MenuItem("Water", "Water", 0.99f, "Resources/water.jpg", false, false, false, false, false);
            MenuItem follyOfTheBeastPinotNoir5Item = new MenuItem("Folly of the Beast Pinot Noir 5oz.", "Sonoma Coast, USA", 12.99f, "/Resources/FollyOfTheBeastPinotNoir.png", false, false, false, false, true);
            MenuItem follyOfTheBeastPinotNoir7Item = new MenuItem("Folly of the Beast Pinot Noir 7oz.", "Sonoma Coast, USA", 16.99f, "/Resources/FollyOfTheBeastPinotNoir.png", false, false, false, false, true);

            MenuItem quinoaAvocadoPowerbowlItem = new MenuItem("Quinoa + Avocado Powerbowl", "Roasted squash, beets, green goddess dressing, toasted pumpkin seeds, crispy chickpeas", 15.99f, "/Resources/QuinoaAvocadoPowerbowl.png", false, false, true, true, false);
            MenuItem crispyPrawnRollItem = new MenuItem("Crispy Prawn Roll", "Avocado, prawn, cucumber, mango, soy paper, unagi sauce, sriracha mayo", 17.99f, "/Resources/CrispyPawnRoll.png", true, false, true, false, false);
            //MenuItem spicycheddardipItem = new MenuItem("Spicy Cheddar Dip", "", 1.99f, "/Resources/spicycheddardip.jpg", true, false, false, false, false);
            MenuItem bbqranchdipItem = new MenuItem("BBQ Ranch Dip", "", 1.99f, "/Resources/bbqranchdip.jpg", false, false, false, false, false);
            //MenuItem creamygarlicdipItem = new MenuItem("Creamy Garlic Dip", "", 1.99f, "/Resources/creamygarlicdip.jpg", false, false, false, false, false);
            MenuItem ranchDipItem = new MenuItem("Ranch Dip", "", 1.99f, "/Resources/ranchdip.jpg", false, false, false, false, false);

            //Working Menu
            Switcher.GetNewMenu().AppetisersList.Children.Add(prawnGyozaItem);
            Switcher.GetNewMenu().AppetisersList.Children.Add(crazybreadItem);
            Switcher.GetNewMenu().AppetisersList.Children.Add(stuffedcrazybreadItem);

            Switcher.GetNewMenu().EntreesList.Children.Add(canadianPrimeSirloinItem);
            Switcher.GetNewMenu().EntreesList.Children.Add(cowboyBurgerItem);
            Switcher.GetNewMenu().EntreesList.Children.Add(salmonFetaCaperAioliItem);
            Switcher.GetNewMenu().EntreesList.Children.Add(blackenedChickenItem);
            //Switcher.GetNewMenu().EntreesList.Children.Add(hawaiianItem);
            //Switcher.GetNewMenu().EntreesList.Children.Add(bbqChickenItem);
            //Switcher.GetNewMenu().EntreesList.Children.Add(meat3Item);
            //Switcher.GetNewMenu().EntreesList.Children.Add(canadianItem);
            Switcher.GetNewMenu().EntreesList.Children.Add(ultimateItem);
            //Switcher.GetNewMenu().EntreesList.Children.Add(veggieItem);
            Switcher.GetNewMenu().EntreesList.Children.Add(pepperoniItem);
            //Switcher.GetNewMenu().EntreesList.Children.Add(cheeseItem);

            Switcher.GetNewMenu().DessertsList.Children.Add(pottedvanillacheesecakeItem);
            Switcher.GetNewMenu().DessertsList.Children.Add(stickyToffeeChocolatePuddingItem);

            Switcher.GetNewMenu().DrinksList.Children.Add(waterItem);
            Switcher.GetNewMenu().DrinksList.Children.Add(follyOfTheBeastPinotNoir5Item);
            Switcher.GetNewMenu().DrinksList.Children.Add(follyOfTheBeastPinotNoir7Item);

            Switcher.GetNewMenu().SidesList.Children.Add(quinoaAvocadoPowerbowlItem);
            Switcher.GetNewMenu().SidesList.Children.Add(crispyPrawnRollItem);
            //Switcher.GetNewMenu().SidesList.Children.Add(spicycheddardipItem);
            Switcher.GetNewMenu().SidesList.Children.Add(bbqranchdipItem);
            //Switcher.GetNewMenu().SidesList.Children.Add(creamygarlicdipItem);
            Switcher.GetNewMenu().SidesList.Children.Add(ranchDipItem);

            //Checkout Items
            List<CheckoutItem> FullCheckout = new List<CheckoutItem>();

            //Cart Items
            List<CartItem> FullCart = new List<CartItem>();

            //Review Order Items
            List<ReviewOrderItem> FullReview = new List<ReviewOrderItem>();
            ReviewOrderItem testRO = new ReviewOrderItem();
            FullReview.Add(testRO);

            Switcher.pageSwitcher = this;
            Switcher.Switch(Switcher.GetLanding());

        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

    }
}
