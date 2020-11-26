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
    /// Логика взаимодействия для AboutSHPage.xaml
    /// </summary>
    public partial class AboutSHPage : Page
    {
        public AboutSHPage()
        {
            InitializeComponent();
            HistorySHTextBlock.Text = Properties.Resources.historySHString;
            EventNameTB.Text = Properties.Resources.eventsSHString;

        }

        private void Travel1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowImage.Source = Travel1.Source;
            ShowImage.Visibility = Visibility.Visible;

        }

        private void Travel3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowImage.Source = Travel3.Source;
            ShowImage.Visibility = Visibility.Visible;

        }

        private void Travel2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowImage.Source = Travel2.Source;
            ShowImage.Visibility = Visibility.Visible;

        }

        private void Hotel1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowImage.Source = Hotel1.Source;
            ShowImage.Visibility = Visibility.Visible;

        }

        private void Hotel2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowImage.Source = Hotel2.Source;
            ShowImage.Visibility = Visibility.Visible;

        }

        private void Hotel3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowImage.Source = Hotel3.Source;
            ShowImage.Visibility = Visibility.Visible;

        }

        private void Food1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowImage.Source = Food1.Source;
            ShowImage.Visibility = Visibility.Visible;

        }

        private void Food2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowImage.Source = Food2.Source;
            ShowImage.Visibility = Visibility.Visible;

        }

        private void Food3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowImage.Visibility = Visibility.Visible;
            ShowImage.Source = Food3.Source;
        }

        private void ShowImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowImage.Visibility = Visibility.Hidden;
        }
    }
}
