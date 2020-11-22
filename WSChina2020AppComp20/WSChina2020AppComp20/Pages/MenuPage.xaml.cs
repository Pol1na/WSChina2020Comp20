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

namespace WSChina2020AppComp20.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void AboutWSBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AboutWSPage());
        }

        private void AboutWSCNButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AboutWSCN());
        }

        private void AboutSHButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AboutSHPage());

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AuthPage());
        }
    }
}
