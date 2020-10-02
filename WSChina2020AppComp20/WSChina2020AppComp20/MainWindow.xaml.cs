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

namespace WSChina2020AppComp20
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Pages.MenuPage());
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void AboutWSBtn_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
                MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            var page = (sender as Frame).Content as Page;
            if (page is Pages.MenuPage)
            {
                BackBtn.Visibility = Visibility.Hidden;
            }
            else
            {
                BackBtn.Visibility = Visibility.Visible;
            }
        }
    }
}
