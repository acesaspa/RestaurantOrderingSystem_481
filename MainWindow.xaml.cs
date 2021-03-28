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

        public MainWindow()
        {
            InitializeComponent();

            CategoryDivider divider = new CategoryDivider();
            divider.Name.Content = "~ Appetizer ~";
            Switcher.GetMenu().MenuItemList.Children.Add(divider);

            //All our menu items
            List<MenuItem> FullMenu = new List<MenuItem>();
            MenuItem test = new MenuItem();
            FullMenu.Add(test);

            //Adding Our Items
            for(int i = 0; i < 15; i++)
            {
                MenuItem menuItem = new MenuItem();
                menuItem.ItemName.Content = "Item: " + i.ToString();
                menuItem.ItemDescription.Content = "ItemDescription: " + i.ToString();
                Switcher.GetMenu().MenuItemList.Children.Add(menuItem);
            }


            //Checkout Items
            List<CheckoutItem> FullCheckout = new List<CheckoutItem>();
            CheckoutItem testCO = new CheckoutItem();
            FullCheckout.Add(testCO);

            //Testing adding to checkout
            for (int i = 0; i < 4; i++)
            {
                CheckoutItem checkoutItem = new CheckoutItem();
                checkoutItem.CheckoutItemName.Content = "Spaghetti Rigatoni Davinci " + i.ToString();
                checkoutItem.CheckoutItemQuantity.Content = "1";
                checkoutItem.CheckoutItemPrice.Content = "$5.99";
                Switcher.GetCheckout().CheckoutItemList.Children.Add(checkoutItem);


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
