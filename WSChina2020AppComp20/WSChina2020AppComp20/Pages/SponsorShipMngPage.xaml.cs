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

namespace WSChina2020AppComp20.Pages
{
    /// <summary>
    /// Логика взаимодействия для SponsorShipMngPage.xaml
    /// </summary>
    public partial class SponsorShipMngPage : Page
    {
        public SponsorShipMngPage()
        {
            InitializeComponent();
        }

        private void StatisticsBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SponsorshipStatPage());
        }

        private void ViewBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SponsorShipViewPage());
        }

        private void ChartBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SponsorshipChartPage());
        }
    }
}
