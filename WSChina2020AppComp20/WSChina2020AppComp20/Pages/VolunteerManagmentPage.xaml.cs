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
            const int Num = 10;
            ServiceSkillsComboBox.ItemsSource = AppData.Context.Skills.ToList();
            ServiceSkillsComboBox.DisplayMemberPath = "Name";
            VolunteersDGrid.ItemsSource = AppData.Context.Volunteers.ToList();
            Binding(Num, 1);

        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            //int pagination = VolunteersDGrid.Items.Count;
            
            if(ServiceSkillsComboBox.Text != "" && SortComboBox.Text != "") 
            {
                VolunteersDGrid.ItemsSource = AppData.Context.Volunteers.ToList().Where(i => i.Skills.Name == ServiceSkillsComboBox.Text).ToList();

                if (SortComboBox.Text == "id")
                {
                    VolunteersDGrid.ItemsSource = AppData.Context.Volunteers.ToList().OrderBy(i => i.id).Where(i => i.Skills.Name == ServiceSkillsComboBox.Text);
                }
                
                else if (SortComboBox.Text == "name")
                {
                    VolunteersDGrid.ItemsSource = AppData.Context.Volunteers.ToList().OrderBy(i => i.fullname).Where(i => i.Skills.Name == ServiceSkillsComboBox.Text);

                }
                else if (SortComboBox.Text == "gender")
                {
                    VolunteersDGrid.ItemsSource = AppData.Context.Volunteers.ToList().OrderBy(i => i.Genders.name).Where(i => i.Skills.Name == ServiceSkillsComboBox.Text);

                }
                else if (SortComboBox.Text == "occupation")
                {
                    VolunteersDGrid.ItemsSource = AppData.Context.Volunteers.ToList().OrderBy(i => i.City.name).Where(i => i.Skills.Name == ServiceSkillsComboBox.Text);

                }
                else if (SortComboBox.Text == "province")
                {
                    VolunteersDGrid.ItemsSource = AppData.Context.Volunteers.ToList().OrderBy(i => i.City.name).Where(i => i.Skills.Name == ServiceSkillsComboBox.Text);

                }
                else if (SortComboBox.Text == "skills of service")
                {
                    VolunteersDGrid.ItemsSource = AppData.Context.Volunteers.ToList().OrderBy(i => i.Skills.Name).Where(i => i.Skills.Name == ServiceSkillsComboBox.Text);

                }


            }
            else
            {
                MessageBox.Show("Выберите что-то, пожалуйста", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Binding(int number, int currentPage)
        {
            int count = VolunteersDGrid.Items.Count;
            int pageSize = 0;
            if (count % number == 0)
            {
                pageSize = count / number;
            }
            else
            {
                pageSize = count / number + 1;
            }
            TotalTB.Text = $"{pageSize.ToString()}";
            CurrentTB.Text = $"{currentPage.ToString()}";
            VolunteersDGrid.ItemsSource = AppData.Context.Volunteers.Take(number * currentPage).OrderBy(p=>p.id).Skip(number * (currentPage - 1)).ToList();

        }
        private void ImportBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ImportPage());
        }

        private void AdjustBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdjustVolunteers());
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            int total = Convert.ToInt32(TotalTB.Text);
            int currentPage = Convert.ToInt32(CurrentTB.Text);
            if (currentPage < total)
            {
                Binding(10, currentPage + 1);
            }
        }

        private void GoBtn_Click(object sender, RoutedEventArgs e)
        {
            if (PaginationTB.Text != null)
            {
                int pageNum = int.Parse(PaginationTB.Text);
                int total = int.Parse(TotalTB.Text);
                if (pageNum >= 1 && pageNum <= total)
                {
                    Binding(10, pageNum);
                }
            }
        }

        private void PreviousBtn_Click(object sender, RoutedEventArgs e)
        {
            int total = Convert.ToInt32(TotalTB.Text);
            int currentPage = Convert.ToInt32(CurrentTB.Text);
            if (currentPage < total)
            {
                Binding(10, currentPage - 1);
            }
        }

        private void FirstBtn_Click(object sender, RoutedEventArgs e)
        {
            Binding(10, 1);
        
        }

        private void LastBtn_Click(object sender, RoutedEventArgs e)
        {
            int total = Convert.ToInt32(TotalTB.Text);
            Binding(10, total);

        }
    }
}
