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
using System.Windows.Threading;

namespace RestaurantOrderingSystem_481
{
    /// <summary>
    /// Interaction logic for Takeout.xaml
    /// </summary>
    public partial class Takeout : UserControl
    {
        public Takeout()
        {
            InitializeComponent();
        }

        private void SuccessNotification(object sender, RoutedEventArgs e)
        {

            Window window = new Window
            {
                Title = "Success",
                Content = Switcher.GetSuccessNotification(),
                Height = 100,
                Width = 200
            };
            window.ShowDialog();
        }

        private void CloseTakeout(object sender, RoutedEventArgs e)
        {
            var parent = this.Parent as Window;
            if (parent != null)
            {
                parent.DialogResult = true;
                parent.Close();
            }
        }
    }
}
