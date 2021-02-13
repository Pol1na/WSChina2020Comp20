using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WSChina2020AppComp20.Pages
{
    /// <summary>
    /// Interaction logic for SponsorshipChart.xaml
    /// </summary>
    public partial class SponsorshipChartPage : Page
    {
        public SponsorshipChartPage()
        {
            InitializeComponent();
            List<string> years = new List<string>();
            AppData.Context.Events.ToList().ForEach(i => years.Add(i.year.ToString()));
            ChartListView.ItemsSource = years;
            SponsorChart.ChartAreas.Add(new ChartArea("Main"));
            var currentSeries = new Series("Donate")
            {
                IsValueShownAsLabel = true
            };
            SponsorChart.Series.Add(currentSeries);
        }

        private void YearCheckBox_Checked(object sender, RoutedEventArgs e)
        {

            List<string> selected = new List<string>();
            selected.Add((sender as CheckBox).Content.ToString());
            UpdateChart(selected);
        }

        private void YearCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Series currentSeries = SponsorChart.Series.FirstOrDefault();
            currentSeries.Points.Clear();
        }
        private void UpdateChart(List<string> selected)
        {
            // короче я запуталась
            Series currentSeries = SponsorChart.Series.FirstOrDefault();
            var categoriesList = AppData.Context.Sponsorship.ToList();
            currentSeries.ChartType = SeriesChartType.Column;
            currentSeries.Points.Clear();
            foreach (var year in selected)
            {
                foreach (var category in categoriesList)
                {
                    currentSeries.Points.AddXY(year, category.amount);
                }
            }
        }
    }
}
