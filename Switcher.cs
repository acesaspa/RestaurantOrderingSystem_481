using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace RestaurantOrderingSystem_481
{
    class Switcher
    {
        public static MainWindow pageSwitcher;

        public static void Switch(UserControl newPage)
        {
            pageSwitcher.Navigate(newPage);
        }
    }
}
