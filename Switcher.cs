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

        public static Landing GetLanding()
        {
            return _landing;
        }

        public static Menu GetMenu()
        {
            return _menu;
        }

        public static void Switch(UserControl newPage)
        {
            pageSwitcher.Navigate(newPage);
        }
    }
}
