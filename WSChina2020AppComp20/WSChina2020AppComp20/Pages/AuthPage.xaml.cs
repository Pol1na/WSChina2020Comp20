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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            var loginpass = AppData.Context.LogPass.ToList();

            if (LoginTBox.Text != "" && PasswordPB.Password != "")
            {
                var currentUser = loginpass.FirstOrDefault(i => i.login == LoginTBox.Text && i.password == PasswordPB.Password);
                if (currentUser != null)
                {
                    switch (currentUser.role)
                    {
                        case "Administrator":
                            NavigationService.Navigate(new AdminMenuPage(currentUser));
                            break;
                        case "Competitor":
                            NavigationService.Navigate(new CompetitorMenuPage(currentUser));
                            break;
                        case "Judger":
                            NavigationService.Navigate(new JudgerMenuPage(currentUser));
                            break;
                        case "Coordinator":
                            NavigationService.Navigate(new CoordinatorMenuPage(currentUser));
                            break;
                        default:
                            MessageBox.Show("Функционал для данной роли не представлен");
                            break;
                    }

                }

                else
                {
                    MessageBox.Show("Пользователь не найден. Перепроверьте вводимые данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Все поля обязательны для заполнения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
    }
}
