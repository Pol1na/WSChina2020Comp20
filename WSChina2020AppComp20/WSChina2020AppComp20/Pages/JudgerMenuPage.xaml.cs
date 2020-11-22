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
    /// Логика взаимодействия для JudgerMenuPage.xaml
    /// </summary>
    public partial class JudgerMenuPage : Page
    {
        public JudgerMenuPage(LogPass log)
        {
            InitializeComponent();
            InitializeComponent();
            if (log.gender == "Male")
            {
                HelloTB.Text = $"Hello, Mr. {log.name}";

            }
            else if (log.gender == "Female")
            {
                HelloTB.Text = $"Hello, Mrs. {log.name}";

            }
            else if (log.gender == "Attack Helicopter")
            {
                HelloTB.Text = $"Hello, PLEASE DONT ATTACK. {log.name}";

            }
            else
            {
                HelloTB.Text = $"Hello, {log.name}";

            }
        }
    }
}
