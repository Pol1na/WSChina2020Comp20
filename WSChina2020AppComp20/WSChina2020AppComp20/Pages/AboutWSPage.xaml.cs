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
    /// Логика взаимодействия для AboutWSPage.xaml
    /// </summary>
    public partial class AboutWSPage : Page
    {
        public AboutWSPage()
        {
            InitializeComponent();
        }

        private void HistoryWSBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.HistoryOfWSPage());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CompetitionSkillsBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.CompetitionSkillsPage());
        }

        private void PreviousCompBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.PreviousCompPage());

        }
    }
}
