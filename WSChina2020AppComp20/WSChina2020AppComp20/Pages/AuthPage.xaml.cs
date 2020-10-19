using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
            CaptchaImage.Source = CreateImage(1500, 500);

        }

        private void CaptchaImage_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            CaptchaImage.Source = CreateImage(1500, 500);
        }
        string _CaptchaText = "";
        private DrawingImage CreateImage(int x, int y)
        {
            _CaptchaText = "";
            Random _rnd = new Random();
            string LowerCaseTxt = "qwertyuiopasdfghjklzxcvbnm";
            string UpperCaseText = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string Number = "123456789";

            for (int i = 0; i < 2; i++)
            {
                _CaptchaText += LowerCaseTxt[_rnd.Next(LowerCaseTxt.Length)];
            }
            for (int i = 0; i < 1; i++)
            {
                _CaptchaText += UpperCaseText[_rnd.Next(UpperCaseText.Length)];
            }
            for (int i = 0; i < 1; i++)
            {
                _CaptchaText += Number[_rnd.Next(Number.Length)];
            }

            string rndCapcha = new string(_CaptchaText.ToList().OrderBy(p => (_rnd.Next(2) % 2) == 0).ToArray());

            byte[] bytes = new byte[x * y * 100];
            _rnd.NextBytes(bytes);

            DrawingVisual DrVisual = new DrawingVisual();

            using (DrawingContext DrContext = DrVisual.RenderOpen())
            {
                DrContext.DrawImage(BitmapSource.Create(x, y, 300, 300, PixelFormats.BlackWhite, null, bytes, x * 30), new Rect(0, 0, x, y));
                DrContext.DrawText(new FormattedText(rndCapcha, CultureInfo.CurrentCulture, FlowDirection.LeftToRight, new Typeface("Arial"), 300, Brushes.Black), new Point(100, 100));
            }
            _CaptchaText = rndCapcha;
            return new DrawingImage(DrVisual.Drawing);
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            var loginpass = AppData.Context.LogPass.ToList();

            if (LoginTB.Text != "" && PasswordTB.Password != "")
            {
                var currentUser = loginpass.FirstOrDefault(i => i.login == LoginTB.Text && i.password == PasswordTB.Password && i.role == RoleComboBox.SelectedItem); //вот тут ошибка из-за ролей скорее всего дебильная
                if (currentUser != null)
                {
                    if (CaptchaTB.Text != _CaptchaText)
                        {
                            MessageBox.Show("Капча введена неверно.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

                        //switch (currentUser.role)
                        //{
                        //    case "Administrator":
                        //        NavigationService.Navigate(new AdminMenuPage());
                        //        break;


                        //}
                        if (currentUser.role == "Administrator")
                        {
                            NavigationService.Navigate(new AdminMenuPage());
                        }
                        else if(currentUser.role == "Competitor")
                        {
                            NavigationService.Navigate(new CompetitorMenuPage());

                        }
                        else if(currentUser.role == "Judger")
                        {
                            NavigationService.Navigate(new JudgerMenuPage());

                        }
                        else if(currentUser.role == "Coordinator")
                        {
                            NavigationService.Navigate(new CoordinatorMenuPage());

                        }
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
