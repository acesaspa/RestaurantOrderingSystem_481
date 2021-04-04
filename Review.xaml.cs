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

namespace RestaurantOrderingSystem_481
{
    /// <summary>
    /// Interaction logic for Review.xaml
    /// </summary>
    public partial class Review : UserControl
    {
        public Review()
        {
            InitializeComponent();
        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            var parent = this.Parent as Window;
            if (parent != null)
            {
                parent.DialogResult = true;
                parent.Close();
            }
        }
        private void Exit_Review(object sender, RoutedEventArgs e)
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
