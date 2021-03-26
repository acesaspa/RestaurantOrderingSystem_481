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
using System.Windows.Shapes;

namespace RestaurantOrderingSystem_481
{
    /// <summary>
    /// Interaction logic for FinalizePage.xaml
    /// </summary>
    public partial class FinalizePage : UserControl
    {
        public FinalizePage()
        {
            InitializeComponent();
        }

        private void ReviewOrder(object sender, RoutedEventArgs e)
        {
            Window window = new Window
            {
                Title = "Review Order",
                Content = Switcher.GetReviewOrder()
            };

            window.ShowDialog();
        }

        private void OrderMore(object sender, RoutedEventArgs e)
        {
            
            
            Switcher.Switch(Switcher.GetMenu());
        }

        private void Takeout(object sender, RoutedEventArgs e)
        {

        }

        private void Condiments(object sender, RoutedEventArgs e)
        {

        }

        private void Review(object sender, RoutedEventArgs e)
        {

        }



    }
}
