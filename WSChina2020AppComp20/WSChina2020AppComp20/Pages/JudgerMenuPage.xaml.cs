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
        public JudgerMenuPage(Users user)
        {
            InitializeComponent();
            InitializeComponent();
            if (user.genderId == 1)
            {
                HelloTB.Text = $"Hello, Mr. {user.name}";

            }
            else if (user.genderId == 2)
            {
                HelloTB.Text = $"Hello, Mrs. {user.name}";

            }
            else if (user.genderId == 3)
            {
                HelloTB.Text = $"Hello, Helicopter {user.name}";

            }
            else
            {
                HelloTB.Text = $"Hello, {user.name}";

            }
        }
    }
}
