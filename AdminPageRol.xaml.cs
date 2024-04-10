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

namespace PePract5
{
    /// <summary>
    /// Логика взаимодействия для AdminPageRol.xaml
    /// </summary>
    public partial class AdminPageRol : Page
    {
        private BdPractica5Entities context = new BdPractica5Entities();
        public AdminPageRol()
        {
            InitializeComponent();
            tablic.ItemsSource = context.Rol.ToList();
        }
        private void BtDob_Cl(object sender, RoutedEventArgs e)
        {
            Rol o = new Rol();
            if (text1.Text == "")
            {
                Eror.Text = "Невозможно добавить роль: \nРоль отсутствует";
                return;
            }
            else
            {
                o.Roll = Convert.ToString(text1.Text);
            }
            try
            {
                context.Rol.Add(o);
                context.SaveChanges();
                tablic.ItemsSource = context.Rol.ToList();
            }
            catch
            {
                Eror.Text = "Невозможно добавить роль\nтак как она уже существует";
            }
        }
        private void BtIzm_Cl(object sender, RoutedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as Rol;
                if (text1.Text == "")
                {
                    Eror.Text = "Невозможно изменить роль: \nРоль отсутствует";
                    return;
                }
                else
                {
                    selected.Roll = Convert.ToString(text1.Text);
                }

                try
                {
                    context.SaveChanges();
                    tablic.ItemsSource = context.Rol.ToList();
                }
                catch
                {
                    Eror.Text = "Невозможно изменить роль\nтак как она уже существует";
                }
            }
        }
        private void BtDel_Cl(object sender, RoutedEventArgs e)
        {
            var selected = tablic.SelectedItem as Rol;
            if (selected != null)
            {
                try
                { 
                    context.Rol.Remove(selected);
                    context.SaveChanges();
                    tablic.ItemsSource = context.Rol.ToList();
                }
                catch
                {
                    Eror.Text = "Невозможно удалить роль\nтак как она привязан к данным для входа";
                }
            }
        }
        private void tablic_Dob(object sender, SelectionChangedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as Rol;

                text1.Text = selected.Roll.ToString();
            }
        }
    }
}
