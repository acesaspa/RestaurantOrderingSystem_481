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
    /// Interaction logic for ChangeTable.xaml
    /// </summary>
    public partial class ChangeTable : UserControl
    {

        //Button to Close ChangeTable
        private void Close_ChangeTable(object sender, RoutedEventArgs e)
        {
            var parent = this.Parent as Window;
            if (parent != null)
            {
                parent.DialogResult = true;
                parent.Close();
            }
        }

        //Button to Change Table Number
        private void Change_TableNumber(object sender, RoutedEventArgs e)
        {
            string changedNumber = Switcher.GetChangeTable().ChangeTableTextBox.Text;
            if(changedNumber != null)
            {
                try
                {
                    int result = Int32.Parse(changedNumber);
                    if(result < 0 || result > 100)
                    {
                        MessageBox.Show("Invalid Input");
                    }
                    else
                    {
                        MainWindow.TableNumber = result;
                        Switcher.GetCart().DisplayTableNumber.Text = "Table: " + result.ToString();
                        Switcher.GetNewMenu().DisplayTableNumber.Text = "Table: " + result.ToString();
                        Switcher.GetCheckout().DisplayTableNumber.Text = "Table " + result.ToString();
                        Close_ChangeTable(sender, e);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Cannot Parse, not a number!");
                    MessageBox.Show("Invald input!");
                }
            }

            
        }

        public ChangeTable()
        {
            InitializeComponent();
        }
    }
}
