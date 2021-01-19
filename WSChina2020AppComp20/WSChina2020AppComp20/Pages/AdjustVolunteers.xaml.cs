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
    /// Логика взаимодействия для AdjustVolunteers.xaml
    /// </summary>
    public partial class AdjustVolunteers : Page
    {
        List<int> volchecked = new List<int>();
        public AdjustVolunteers()
        {
            InitializeComponent();
            SkillsNoLess.ItemsSource = AppData.Context.Skills.ToList();
            SkillsNoLess.DisplayMemberPath = "Name";
            SkillsLess.ItemsSource = AppData.Context.Skills.ToList();
            SkillsLess.DisplayMemberPath = "Name";

        }

        private void ShowBtn_Click(object sender, RoutedEventArgs e)
        {
            LeftDGrid.ItemsSource = AppData.Context.Volunteers.ToList().Where(i => i.Skills.Name == SkillsNoLess.Text);
            TotalLeftTB.Text = Convert.ToString(LeftDGrid.Items.Count);

        }

        private void ShowRightBtn_Click(object sender, RoutedEventArgs e)
        {
            RightDGrid.ItemsSource = AppData.Context.Volunteers.ToList().Where(i => i.Skills.Name == SkillsLess.Text);
            TotalRightTB.Text = Convert.ToString(RightDGrid.Items.Count);

        }

        private void MoveToRightBtn_Click(object sender, RoutedEventArgs e)
        {
        }

        private void LeftCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
