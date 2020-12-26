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
    /// Логика взаимодействия для VolunteerManagmentPage.xaml
    /// </summary>
    public partial class VolunteerManagmentPage : Page
    {
        public VolunteerManagmentPage()
        {
            InitializeComponent();
            ServiceSkillsComboBox.ItemsSource = AppData.Context.Skills.ToList();
            ServiceSkillsComboBox.DisplayMemberPath = "Name";
            VolunteersDGrid.ItemsSource = AppData.Context.Volunteers.ToList();

        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            if(SortComboBox.Text !="" || ServiceSkillsComboBox.Text != "")
            {

                VolunteersDGrid.ItemsSource = AppData.Context.Volunteers.ToList().Where(i => i.Skills.Name == Convert.ToString(ServiceSkillsComboBox.SelectedItem)).ToList();
                
            }
            else
            {
                MessageBox.Show("Выберите что-то, пожалуйста", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ImportBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ImportPage());
        }

        private void AdjustBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdjustVolunteers());
        }
    }
}
