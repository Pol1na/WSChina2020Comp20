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
    /// Interaction logic for EventManagmentPage.xaml
    /// </summary>
    public partial class EventManagmentPage : Page
    {
        public EventManagmentPage()
        {
            InitializeComponent();
        }

        private void EventBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CompetitionEventPage());
        }

        private void SkillsBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("я и так нифига не делаю, а этой страницы ваще в тз не было", "в 3.1 такого не было", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
