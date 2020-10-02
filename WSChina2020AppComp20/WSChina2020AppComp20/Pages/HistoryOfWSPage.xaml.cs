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
    /// Логика взаимодействия для HistoryOfWSPage.xaml
    /// </summary>
    public partial class HistoryOfWSPage : Page
    {
        public HistoryOfWSPage()
        {
            InitializeComponent();
        }

        private void AlbertImage_Click(object sender, RoutedEventArgs e)
        {
            {
                HistoryWSTextBox.Text = "The Albert Vidal Award \n "
                  + "The Albert Vidal Award is a prestigious award, named after the founder of WorldSkills "
                  + "International(formerly known as the International Vocational Training Organisation)."
                  + "During the first thirty - one WorldSkills Competitions(formerly known as the Vocational"
                  + " Training Competitions), Francisco Albert Vidal, from Spain, was responsible for the"
                  + " achievement of the original goals in a changing world: 33 years as an untiring promoter"
                  + " in his position as Secretary General and seven years as President of the International"
                  + " Organisation constantly presenting new ideas.The Vocational Training Competitions "
                  + "became his life's work and the International Organisation was shaped into what it is"
                  + " today. In memory of Albert Vidal, the Award recognises the Competitor that achieves the "
                  + "overall highest score out of all Competitors in all Skill categories. The Albert Vidal "
                  + "Award is connected with the implementation of the 500 mark system, developed by former"
                  + " WorldSkills President Cees Beuk, after the WorldSkills Competition 1985 held in Osaka, "
                  + "Japan.The new system was developed upon the request from the Technical Committee Chairman"
                  + " René Gonthier and his vision of making the Competition scores more comparable and "
                  + "universal.With the new system, it became possible to compare the scores from skill to"
                  + " skill and from Expert to Expert within each skill, making their scoring behaviour more"
                  + " transparent.The new system became effective in 1988(when the WorldSkills Competition "
                  + "was held in Sydney, Australia) at which the 'Best of the Competition Award' was "
                  + "introduced for the first time. After Albert Vidal’s death in October 1993 the Award was"
                  + " renamed(proposed by Tjerk Dusseldorp, past President, WSI) from the 'Best of the "
                  + "Competition Award' to the 'Albert Vidal Award' in order to honour the contributions of"
                  + " Albert Vidal for his decades of devotion to the WorldSkills movement.The new name of "
                  + "the award, first became effective in 1995 when the WorldSkills Competition took place "
                  + "in Lyon, France.";
            }
        }

        private void NoImage_Click(object sender, RoutedEventArgs e)
        {
            HistoryWSTextBox.Text = "DESCRIPTION";
        }

        private void DirectorsImage_Click(object sender, RoutedEventArgs e)
        {
            {
                HistoryWSTextBox.Text = "On 15 September 2014, the new WorldSkills International Board of " +
                  "Directors for 2015-2019 was selected during the WorldSkills General Assembly in beautiful " +
                  "Lucerne, Switzerland. The election process began after Chair Simon Bartley and CEO David " +
                  "Hoey welcomed everyone to the WorldSkills General Assembly 2014.The new Board will include" +
                  " members that represent countries from around the world, with a variety of experience and " +
                  "backgrounds.They will take office after the WorldSkills Competition in São Paulo in August" +
                  "2015. The Board of Directors for 2015 – 2019 will be: \n Simon Bartley(United Kingdom) – " +
                  "President of WorldSkills and Chair of the Board of Directors \n Stefan Praschl(Austria) -" +
                  "Vice President Technical Affairs and Chair of Technical Committee \n Jos de " +
                  "Goey(Netherlands) – Vice President Strategic Affairs and Chair of Strategy Committee \n " +
                  "San - Quei Lin(Chinese Taipei) – Vice President Special Affairs \n Michael Fung(Hong Kong," +
                  "China) – Vice Chair Technical Committee \n Laurence Gates(France) – Vice Chair Strategy" +
                  "Committee \n Terry Cooke(Canada) – Treasurer \n Ali Al Marzouqi(United Arab Emirates) – " +
                  "Ex officio for WorldSkills Abu Dhabi 2017";
            }
        }
    }
}
