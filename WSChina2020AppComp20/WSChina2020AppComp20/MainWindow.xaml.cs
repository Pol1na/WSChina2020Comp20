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
using System.Timers;
using System.Windows.Threading;
using System.Threading;
using WSChina2020AppComp20.Entities;
using System.IO;

namespace WSChina2020AppComp20
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime WorldSkills2021 = new DateTime(2021, 09, 22, 0, 0, 0);
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Pages.MenuPage());

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += timer_tick;
            timer.Start();
        }

        void timer_tick(object sender, EventArgs e)
        {
            if ((MainFrame.Content as Page).Title is null)
            {
                Title = "Skills Competition Managment System: " + (MainFrame.Content as Page).Title;

            }
            else
            {
                Title = "Skills Competition Managment System";
            }
            TimeSpan TimeRemaining = WorldSkills2021 - DateTime.Now;
            if (TimeRemaining.Seconds > 0 || TimeRemaining.Minutes > 0 || TimeRemaining.Hours > 0 || TimeRemaining.Days > 0)
            {
                TimerWS.Text = $"{TimeRemaining.Days} days, {TimeRemaining.Hours} hours, {TimeRemaining.Minutes} minutes and {TimeRemaining.Seconds} seconds until the WorldSkills Shanghai 2021 starts";

            }
            else
            {
                TimerWS.Text = "The WorldSkills Shanghai 2021 has started.";
            }

            //var img = AppData.Context.Tourism.ToList()[2];
            //img.travel = File.ReadAllBytes(@"C:\Users\Pol1na\Desktop\sh_travel3.jpg");
            //AppData.Context.SaveChanges();

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
