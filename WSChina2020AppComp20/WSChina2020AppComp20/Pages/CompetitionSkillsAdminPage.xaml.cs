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
    /// Interaction logic for CompetitionSkillsAdminPage.xaml
    /// </summary>
    public partial class CompetitionSkillsAdminPage : Page
    {
        public CompetitionSkillsAdminPage()
        {
            InitializeComponent();
        }

        private void AddSkillsBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddSkillsPage());
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}