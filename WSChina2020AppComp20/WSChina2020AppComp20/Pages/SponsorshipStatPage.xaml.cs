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
    /// Логика взаимодействия для SponsorshipStatPage.xaml
    /// </summary>
    public partial class SponsorshipStatPage : Page
    {
        public SponsorshipStatPage()
        {
            InitializeComponent();
            EventCBox.ItemsSource = AppData.Context.Events.ToList();
            EventCBox.DisplayMemberPath = "name";
            StatDataGrid.ItemsSource = AppData.Context.Sponsorship.ToList();            
        }

        private void FindBtn_Click(object sender, RoutedEventArgs e)
        {
            if(EventCBox.Text != "" && ClassByCBox.Text != "")
            {             
                    if (ClassByCBox.Text == "Sponsor's name")
                    {
                    StatDataGrid.ItemsSource = AppData.Context.Sponsorship.ToList().OrderBy(i => i.name).ToList().Where(i => i.Events.name == EventCBox.Text); 
                    }
                    else if (ClassByCBox.Text == "Amount")
                    {
                    StatDataGrid.ItemsSource = AppData.Context.Sponsorship.ToList().OrderBy(i => i.amount).ToList().Where(i => i.Events.name == EventCBox.Text);
                    }
                    else if (ClassByCBox.Text == "Items")
                    {
                    StatDataGrid.ItemsSource = AppData.Context.Sponsorship.ToList().OrderBy(i => i.item).ToList().Where(i => i.Events.name == EventCBox.Text);
                    }
            }
            else
            {
                MessageBox.Show("емае ну выбери что-нибудь", "дибильная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
