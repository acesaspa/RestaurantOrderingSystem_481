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
        //Initialize User Controls
        Landing _landing = new Landing();
        Menu _menu = new Menu();

        public MainWindow()
        {
            InitializeComponent();
            Switcher.pageSwitcher = this;
            Switcher.Switch(new Landing());
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        //Button to Open up Menu
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Menu());
        }
    }
}
