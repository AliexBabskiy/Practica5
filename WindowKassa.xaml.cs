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
    /// Логика взаимодействия для WindowKassa.xaml
    /// </summary>
    public partial class WindowKassa : Window
    {
        public WindowKassa()
        {
            InitializeComponent();
            FrameP.Content = new PageCheckk();
        }

        private void Checkk_Cl(object sender, RoutedEventArgs e)
        {
            FrameP.Content = new PageCheckk();
        }

        private void Checkk_Histori_Cl(object sender, RoutedEventArgs e)
        {
            FrameP.Content = new PageCheckkHistori();
        }
    }
}
