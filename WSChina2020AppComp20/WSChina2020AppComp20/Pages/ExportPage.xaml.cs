using Microsoft.Win32;
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
    /// Логика взаимодействия для ExportPage.xaml
    /// </summary>
    public partial class ExportPage : Page
    {
        public ExportPage()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SponsorShipViewPage());
        }

        private void ExportBtn_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void BrowseBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (XMLCheckBox.IsChecked == true)
            {
                dlg.DefaultExt = ".xml";
                dlg.Filter = "XML documents (.xml)|*.xml";
            }
            else if (XLSCheckBox.IsChecked == true)
            {
                dlg.DefaultExt = ".xlsx";
                dlg.Filter = "Excel documents (.xlsx)|*.xlsx";
            }
            else
            {
                MessageBox.Show("Выберите что-то одно", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
            }
            LocationTB.Text = System.IO.Path.GetFileNameWithoutExtension(dlg.FileName);

        }
    }
}
