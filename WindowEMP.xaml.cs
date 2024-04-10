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
    /// Логика взаимодействия для WindowEMP.xaml
    /// </summary>
    public partial class WindowEMP : Window
    {
        public WindowEMP()
        {
            InitializeComponent();
        }

        private void Korzina_Cl(object sender, RoutedEventArgs e)
        {
            FrameP.Content = new PageKorzina();
        }

        private void Tovar_Cl(object sender, RoutedEventArgs e)
        {
            FrameP.Content = new PageTovar();
        }

        private void Client_Click(object sender, RoutedEventArgs e)
        {
            FrameP.Content = new PageClient();
        }
    }
}
