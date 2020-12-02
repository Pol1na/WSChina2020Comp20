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
        public CompetitorMenuPage(Users user)
        {
            InitializeComponent();
            this.DataContext = user;
            if (user.gender == "Male")
            {
                HelloTB.Text = $"Hello, Mr. {user.name}";

            }
            else if (user.gender == "Female")
            {
                HelloTB.Text = $"Hello, Mrs. {user.name}";

            }
            else if (user.gender == "Attack Helicopter")
            {
                HelloTB.Text = $"Hello, DONT ATTACK. {user.name}";

            }
            else
            {
                HelloTB.Text = $"Hello, {user.name}";

            }
        }

        private void MySkillsBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MySkillsPage());
        }

        private void MyProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функционал в разработке, и вообще это не в этой сессии", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void MyResultsBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функционал в разработке, и вообще это не в этой сессии", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

        }
    }
}
