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
    /// Логика взаимодействия для SponsorShipViewPage.xaml
    /// </summary>
    public partial class SponsorShipViewPage : Page
    {
        public SponsorShipViewPage()
        {
            InitializeComponent();
            ChooseEventCB.ItemsSource = AppData.Context.Events.ToList();
            ChooseEventCB.DisplayMemberPath = "name";
            ChooseSkillsCB.ItemsSource = AppData.Context.Skills.ToList();
            ChooseSkillsCB.DisplayMemberPath = "Name";
            SponsorDG.ItemsSource = AppData.Context.Sponsorship.ToList();
            SponsorNameCB.ItemsSource = AppData.Context.Sponsorship.ToList();
            SponsorNameCB.DisplayMemberPath = "name";

        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ChooseEventCB.Text != "" && ChooseSkillsCB.Text != "" && SponsorNameCB.Text != "")
            {
                SponsorDG.ItemsSource = AppData.Context.Sponsorship.ToList().Where(i => i.Events.name == ChooseEventCB.Text && i.name == SponsorNameCB.Text && i.Skills.Name == ChooseSkillsCB.Text).ToList();
            }
            else
            {
                MessageBox.Show("емае ну выбери что-нибудь", "дибильная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ExportBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ExportPage());
        }
    }
}
