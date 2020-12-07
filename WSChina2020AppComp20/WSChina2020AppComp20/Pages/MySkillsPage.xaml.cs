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
    /// Логика взаимодействия для MySkillsPage.xaml
    /// </summary>
    public partial class MySkillsPage : Page
    {
        public MySkillsPage()
        {
            InitializeComponent();

            // Здесь была попытка сделать добавление картинок и текста автоматом, но я не осилила, и меня картинки послали далеко и надолго((
            // поэтому тут датагрид
            //this.DataContext = AppData.Context.Users.ToList();
            //var competitors = AppData.Context.Users.ToList().Where(i => i.role == "Competitor").ToList();
            //for(var i = 0; competitors.Count>i; i++)
            //{
            //    Image image = new Image();
            //    TextBlock TB = new TextBlock();
            //    TB.Text = competitors[i].name + competitors[i].surname;
            //    CompetitorsWrapPanel.Children.Add(TB);

            //    image.Source = competitors[i].image;

            //    CompetitorsWrapPanel.Children.Add(image);

            CompetitorsDataGrid.ItemsSource = AppData.Context.Users.ToList().Where(i => i.role == "Competitor");
            
            JudgersDataGrid.ItemsSource = AppData.Context.Users.ToList().Where(i => i.role == "Judger");
            WorkshopTab.DataContext = AppData.Context.UserSkills.ToList();
            InfrastructureTab.DataContext = AppData.Context.UserSkills.ToList();


        }
    }
}
