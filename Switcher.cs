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
        static MenuFilter _menuFilter = new MenuFilter();
        static MenuFilter2 _menuFilter2 = new MenuFilter2();
        static OrderConfirm _orderConfirm = new OrderConfirm();
        static SuccessNotification _successNotification = new SuccessNotification();
        static ItemDelete _itemDelete = new ItemDelete();
        static ItemSubstitution _itemSubstitution = new ItemSubstitution();

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

        public static Checkout GetCheckout()
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

        public static MenuFilter GetMenuFilter()
        {
            return _menuFilter;
        }

        public static MenuFilter2 GetMenuFilter2()
        {
            return _menuFilter2;
        }

        public static OrderConfirm GetOrderConfirm()
        {
            return _orderConfirm;
        }

        public static SuccessNotification GetSuccessNotification()
        {
            return _successNotification;
        }

        public static ItemDelete GetItemDelete()
        {
            return _itemDelete;
        }

        public static ItemSubstitution GetItemSubstitution()
        {
            return _itemSubstitution;
        }

        public static void Switch(UserControl newPage)
        {
            pageSwitcher.Navigate(newPage);
        }
    }
}
