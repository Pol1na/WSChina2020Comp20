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
using WSChina2020AppComp20.Entities;

namespace WSChina2020AppComp20.Pages
{
    /// <summary>
    /// Логика взаимодействия для CompetitorMenuPage.xaml
    /// </summary>
    public partial class CompetitorMenuPage : Page
    {
        public CompetitorMenuPage()
        {
            InitializeComponent();
            this.DataContext = AppData.currentUser;
            if (AppData.currentUser.gender == "Male")
            {
                HelloTB.Text = $"Hello, Mr. {AppData.currentUser.name}";

            }
            else if (AppData.currentUser.gender == "Female")
            {
                HelloTB.Text = $"Hello, Mrs. {AppData.currentUser.name}";

            }
            else if (AppData.currentUser.gender == "Attack Helicopter")
            {
                HelloTB.Text = $"Hello, DONT ATTACK. {AppData.currentUser.name}";

            }
            else
            {
                HelloTB.Text = $"Hello, {AppData.currentUser.name}";

            }
        }

        private void MySkillsBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MySkillsPage());
        }

        private void MyProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MyProfilePage());
        }

        private void MyResultsBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MyResultsPage());
        }
    }
}
