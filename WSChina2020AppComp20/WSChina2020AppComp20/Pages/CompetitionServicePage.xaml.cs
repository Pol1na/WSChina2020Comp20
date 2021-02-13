using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WSChina2020AppComp20.Pages
{
    /// <summary>
    /// Логика взаимодействия для CompetitionServicePage.xaml
    /// </summary>
    public partial class CompetitionServicePage : Page
    {
        List<byte[]> serviceImages = new List<byte[]>();
        List<byte[]> droppedImages = new List<byte[]>();
        public CompetitionServicePage()
        {
            InitializeComponent();
            var icons = Directory.GetFiles(@"..\CompetitionService");
            foreach (var item in icons.Take(5).ToList())
            {
                serviceImages.Add(File.ReadAllBytes(item));
            }
            ToDragLV.ItemsSource = serviceImages;
        }
        private void ToDragImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(sender as Image, (sender as Image).DataContext, DragDropEffects.Copy);
            var img = (sender as Image).Source;
        }

        private void DropCanvas_Drop(object sender, DragEventArgs e)
        {
            var MouseLocation = e.GetPosition(DropCanvas);
            var point = new Point(MouseLocation.X, MouseLocation.Y);
            DropCanvas.Children.Add(*source картинки*, point);
        }

        //private void DropLV_Drop(object sender, DragEventArgs e)
        //{
        //    var currentImage = e.Data.GetData(e.Data.GetFormats()[0]) as byte[];
        //    droppedImages.Add(currentImage);
        //    DropLV.ItemsSource = droppedImages;
        //    DropLV.Items.Refresh();

        //}
    }
}
