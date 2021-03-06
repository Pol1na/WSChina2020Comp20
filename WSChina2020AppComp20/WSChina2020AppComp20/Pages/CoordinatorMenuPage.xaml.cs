﻿using System;
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
    /// Логика взаимодействия для CoordinatorMenuPage.xaml
    /// </summary>
    public partial class CoordinatorMenuPage : Page
    {
        public CoordinatorMenuPage(Users user)
        {
            InitializeComponent();
            if (user.genderId == 1)
            {
                HelloTB.Text = $"Hello, Mr. {user.name}";

            }
            else if (user.genderId == 2)
            {
                HelloTB.Text = $"Hello, Mrs. {user.name}";

            }
            else if (user.genderId == 3)
            {
                HelloTB.Text = $"Hello, PLEASE DONT ATTACK. {user.name}";

            }
            else
            {
                HelloTB.Text = $"Hello, {user.name}";

            }
        }

        private void VolunteerBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VolunteerManagmentPage());
        }

        private void SponsorBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SponsorShipMngPage());
        }

        private void CompServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CompetitionServicePage());
        }
    }
}
