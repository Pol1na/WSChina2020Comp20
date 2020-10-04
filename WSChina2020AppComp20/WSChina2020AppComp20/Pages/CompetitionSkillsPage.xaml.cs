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
    /// Логика взаимодействия для CompetitionSkillsPage.xaml
    /// </summary>
    public partial class CompetitionSkillsPage : Page
    {
        public CompetitionSkillsPage()
        {
            InitializeComponent();
            var blocks = AppData.Context.Blocks.ToList();
            foreach(var block in blocks)
            {
                TreeViewItem item = new TreeViewItem()
                {
                    Name = "Block_" + block.BlockID.ToString(),
                    Header = block.Name
                };
                SkillsTW.Items.Add(item);

                var skills = block.Skills.ToList();
                foreach (var skill in skills)
                {
                    TreeViewItem child = new TreeViewItem()
                    {
                        Name = "Skill_" + skill.SkillID.ToString(),
                        Header = skill.Name
                    };
                    child.Selected += Skill_Selected;
                    item.Items.Add(child);

                    void Skill_Selected(object sender, RoutedEventArgs e)
                    {
                        TreeViewItem element = (TreeViewItem)sender;
                        CompetitionSkillsTextBox.Text = skill.Description;
                    }

                } 
            }
        }
    }


 
}
