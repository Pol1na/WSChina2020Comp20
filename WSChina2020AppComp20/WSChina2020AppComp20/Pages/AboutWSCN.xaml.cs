using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AboutWSCN.xaml
    /// </summary>
    public partial class AboutWSCN : Page
    {
        public AboutWSCN()
        {
            InitializeComponent();
        }

        private void SaveFileBtn_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            File.Move(saveFileDialog.FileName, "..\\Files\\China.txt");
        }

        private void AccessionButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
