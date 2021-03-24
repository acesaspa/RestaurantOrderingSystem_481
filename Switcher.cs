using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace RestaurantOrderingSystem_481
{
    class Switcher
    {
        public static MainWindow pageSwitcher;

        //Initialize User Controls
        static Landing _landing = new Landing();
        static Menu _menu = new Menu();
        static Cart _cart = new Cart();
        static Checkout _checkout = new Checkout();
        static FinalizePage _finalize = new FinalizePage();
        static ChangeTable _changeTable = new ChangeTable();

        public static Landing GetLanding()
        {
            return _landing;
        }

        public static Menu GetMenu()
        {
            return _menu;
        }

        public static Cart GetCart()
        {
            return _cart;
        }

        public static Checkout getCheckout()
        {
            return _checkout;
        }

        public static FinalizePage GetFinalize()
        {
            return _finalize;
        }

        public static ChangeTable GetChangeTable()
        {
            return _changeTable;
        }

        public static void Switch(UserControl newPage)
        {
            pageSwitcher.Navigate(newPage);
        }
    }
}
