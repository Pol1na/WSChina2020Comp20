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
    /// Логика взаимодействия для PreviousCompPage.xaml
    /// </summary>
    public partial class PreviousCompPage : Page
    {
        public PreviousCompPage()
        {
            InitializeComponent();
            MembersDGrid.ItemsSource = AppData.Context.Competitions.ToList();
            
        }

        private void SearchWSBtn_Click(object sender, RoutedEventArgs e)
        {
                if (OrdinalNumTBox.Text != "" && CityCountryTBox.Text == "")
                {
                    MembersDGrid.ItemsSource = AppData.Context.Competitions.ToList().Where(i => i.id == Convert.ToInt32(OrdinalNumTBox.Text));
                }
                else if(OrdinalNumTBox.Text == "" && CityCountryTBox.Text != "")
                {
                    MembersDGrid.ItemsSource = AppData.Context.Competitions.ToList().Where(i => i.CityCountry == CityCountryTBox.Text);
                }
                else
                {
                    MessageBox.Show("error");
                }
        }

        //private void SearchWSBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    if (OrdinalNumCBox.SelectedItem != null)
        //    {
        //        if (OrdinalNumCBox.SelectedIndex>0)
        //        {
        //            MembersDGrid.ItemsSource = AppData.Context.PrevCompetitions.ToList().Where(p => p.ordinalNum == (OrdinalNumCBox.SelectedItem as ))
        //        }
        //    }
        //    else
        //        MessageBox.Show("Вы не вписали данные для поиска!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        //}
    }
}
