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
    /// Interaction logic for Landing.xaml
    /// </summary>
    public partial class Landing : UserControl
    {

        public Landing()
        {
            InitializeComponent();
        }
        //Button to Open up Menu
        private void Open_Menu(object sender, RoutedEventArgs e)
        {
            string changedNumber = Switcher.GetLanding().tableNumber.Text;
            if (changedNumber != null)
            {
                try
                {
                    int result = Int32.Parse(changedNumber);
                    if (result < 0 || result > 100)
                    {
                        MessageBox.Show("Invalid input.");
                    }
                    else
                    {
                        MainWindow.TableNumber = result;
                        Switcher.GetNewMenu().DisplayTableNumber.Text = "Table: " + result.ToString();
                        Switcher.GetCart().DisplayTableNumber.Text = "Table: " + result.ToString();
                        Switcher.GetCheckout().DisplayTableNumber.Text = "Table " + result.ToString();
                        Switcher.Switch(Switcher.GetNewMenu());
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Cannot Parse, not a number!");
                    MessageBox.Show("Invald input!");
                }
            }
        }

        //Change Language
        private void Change_Language_EN(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You changed your Language!");
        }

        private void Change_Language_ES(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("¡Cambiaste tu idioma!");
        }
    }
}
