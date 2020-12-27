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
using System.IO;


namespace WSChina2020AppComp20.Pages
{
    /// <summary>
    /// Логика взаимодействия для ImportPage.xaml
    /// </summary>
    public partial class ImportPage : Page
    {
        public ImportPage()
        {
            InitializeComponent();
        }

        private void BrowseBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".xlsx";
            dlg.Filter = "Excel documents (.xlsx)|*.xlsx";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
            }
            ExcelTB.Text = System.IO.Path.GetFileNameWithoutExtension(dlg.FileName);
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Импорт файла отменен", "на самом деле просто текстбокс пустой теперь))", MessageBoxButton.OK, MessageBoxImage.Information);
            ExcelTB.Text = "";

        }

        private void ImportBtn_Click(object sender, RoutedEventArgs e)
        {                        
        }
    }
}
