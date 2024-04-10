using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace PePract5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BdPractica5Entities context = new BdPractica5Entities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Avtor(object sender, RoutedEventArgs e)
        {
            foreach (var ithem in context.DanVxod)
            {
                if (ithem.Loggin == Login.Text)
                {
                    Oschibka.Text = "";
                    if (ithem.Passwd == Paswd.Password)
                    {
                        if (ithem.Rol_ID == 1)
                        {
                            WindowAdmin window = new WindowAdmin();
                            window.Show();
                            Close();
                        }
                        if (ithem.Rol_ID == 2)
                        {
                            WindowEMP window = new WindowEMP();
                            window.Show();
                            Close();
                        }
                        if (ithem.Rol_ID == 3)
                        {
                            WindowKassa window = new WindowKassa();
                            window.Show();
                            Close();
                        }
                    }
                }
                else
                {
                    Oschibka.Text = "Неверный логин или пароль";
                }
            }
        }
    }
}
