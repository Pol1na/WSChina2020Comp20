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
    /// Interaction logic for CompetitionEventPage.xaml
    /// </summary>
    public partial class CompetitionEventPage : Page
    {
        public CompetitionEventPage()
        {
            InitializeComponent();
            CompetitionDataGrid.ItemsSource = AppData.Context.Events.ToList();
            //if (DateTime.Now.DayOfYear == )
            //{

            //}
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            if(SearchTB.Text != "")
            {
                CompetitionDataGrid.ItemsSource = AppData.Context.Events.ToList().Where(i => i.province == SearchTB.Text || i.name == SearchTB.Text);
            }
            else
            {
                MessageBox.Show("нет ну ты издеваешься надо мной?", "бесполезное расходование ресурсов компьютера", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddEventBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The feature would be a future add-on to the current system", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The feature would be a future add-on to the current system", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
