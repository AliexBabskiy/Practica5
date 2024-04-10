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
using System.Windows.Shapes;

namespace PePract5
{
    /// <summary>
    /// Логика взаимодействия для WindowAdmin.xaml
    /// </summary>
    public partial class WindowAdmin : Window
    {
        public WindowAdmin()
        {
            InitializeComponent();
        }

        private void EMPPage(object sender, RoutedEventArgs e)
        {
            FrameP.Content = new AdminPageEMP();
        }

        private void DanVxod(object sender, RoutedEventArgs e)
        {
            FrameP.Content = new AdminPageDanVxod();
        }

        private void Rol(object sender, RoutedEventArgs e)
        {
            FrameP.Content = new AdminPageRol();
        }

        private void Dolz(object sender, RoutedEventArgs e)
        {
            FrameP.Content = new AdminPageDolz();
        }

        private void EMPDolz(object sender, RoutedEventArgs e)
        {
            FrameP.Content = new AdminPageEMPDolz();
        }

        private void Smena(object sender, RoutedEventArgs e)
        {
            FrameP.Content = new AdminPageSmena();
        }
    }
}
