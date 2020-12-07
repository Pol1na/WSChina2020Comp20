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
using System.Text.RegularExpressions;


namespace WSChina2020AppComp20.Pages
{
    /// <summary>
    /// Логика взаимодействия для MyProfilePage.xaml
    /// </summary>
    public partial class MyProfilePage : Page
    {
        public MyProfilePage()
        {
            InitializeComponent();
            this.DataContext = AppData.currentUser;

        }

        private void SavePasswordBtn_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{6,16}$");
            try
            {
                if (PasswordPB.Password == RePasswordPB.Password)
                {
                    if (regex.IsMatch(PasswordPB.Password) == true)
                    {
                        AppData.currentUser.password = RePasswordPB.Password;
                        AppData.Context.SaveChanges();
                        MessageBox.Show("Пароль успешно изменен", "OK", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Пароль должен содержать: \n Как минимум 1 заглавную букву.\n Как минимум 1 строчную букву. \n" +
                        "Как минимум одну цифру.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    // можно же просто так вывести скажи(те) дадада, я не хочу на каждый регекс прописывать условия и выводить конкретно ;_;
                    // лучше похвали(те) какая я дофига умная знаю что такое регекс))0)
                    }
                }
                else
                {
                    MessageBox.Show("Введенные пароли не совпадают", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Полина II не нашла никаких ошибок для try, но обязательно найдет, а пока пусть будет так","панкова дебилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
