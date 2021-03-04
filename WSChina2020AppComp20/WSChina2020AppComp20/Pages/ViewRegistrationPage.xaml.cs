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
    /// Interaction logic for ViewRegistrationPage.xaml
    /// </summary>
    public partial class ViewRegistrationPage : Page
    {
        public ViewRegistrationPage()
        {
            InitializeComponent();
            ViewSkillsDataGrid.ItemsSource = AppData.Context.UserSkills.ToList();
            var competitorsProvinces = AppData.Context.UserSkills.ToList().Where(i => i.Users.role == "Competitor").Select(p => p.Users.Coutry).ToList();
            var countCompetitors = AppData.Context.UserSkills.ToList().Select(i => i.Users.role == "Competitor").Count();
        }
    }
}
