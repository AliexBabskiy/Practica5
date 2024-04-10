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
    /// Логика взаимодействия для AdminPageDanVxod.xaml
    /// </summary>
    public partial class AdminPageDanVxod : Page
    {
        private BdPractica5Entities context = new BdPractica5Entities();
        public AdminPageDanVxod()
        {
            InitializeComponent();
            tablic.ItemsSource = context.DanVxod.ToList();
            Cb1.ItemsSource = context.Rol.ToList(); // запись в комбобокс данных из таблицы
        }
        private void BtDob_Cl(object sender, RoutedEventArgs e)
        {
            DanVxod o = new DanVxod();
            if (text1.Text == "")
            {
                Eror.Text = "Невозможно добавить сотрудника: \nОтсутствует логин";
                return;
            }
            else
            {
                o.Loggin = Convert.ToString(text1.Text);
            }
            if (text2.Password == "")
            {
                Eror.Text = "Невозможно добавить данные: \nОтсутствует пароль";
                return;
            }
            else
            {
                o.Passwd = Convert.ToString(text2.Password);
            }

            if (Cb1.SelectedItem != null)
            {
                var selected = Cb1.SelectedItem as Rol;
                o.Rol_ID = Convert.ToInt32(selected.ID_Rol);
            }
            try
            {
                context.DanVxod.Add(o);
                context.SaveChanges();
                tablic.ItemsSource = context.DanVxod.ToList();
            }
            catch
            {
                Eror.Text = "Невозможно добавить данные:\nОтсутствует роль";
            }
        }
        private void BtIzm_Cl(object sender, RoutedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as DanVxod;

                if (text1.Text == "")
                {
                    Eror.Text = "Невозможно изменить сотрудника: \nОтсутствует логин";
                    return;
                }
                else
                {
                    selected.Loggin = Convert.ToString(text1.Text);
                }
                if (text2.Password == "")
                {
                    Eror.Text = "Невозможно изменить данные: \nОтсутствует пароль";
                    return;
                }
                else
                {
                    selected.Passwd = Convert.ToString(text2.Password);
                }

                if (Cb1.SelectedItem != null)
                {
                    var selected1 = Cb1.SelectedItem as Rol;
                    selected.Rol_ID = Convert.ToInt32(selected1.ID_Rol);
                }
                try
                {
                    context.SaveChanges();
                    tablic.ItemsSource = context.DanVxod.ToList();
                }
                catch
                {
                    Eror.Text = "Невозможно изменить данные:\nОтсутствует роль";
                }
            }
        }
        private void BtDel_Cl(object sender, RoutedEventArgs e)
        {
            var selected = tablic.SelectedItem as DanVxod;
            if (selected != null)
            {
                try
                {
                    context.DanVxod.Remove(selected);
                    context.SaveChanges();
                    tablic.ItemsSource = context.DanVxod.ToList();
                }
                catch
                {
                    Eror.Text = "Невозможно удалить данные\nтак как они привязан к сотруднику";
                }
            }
        }
        private void tablic_Dob(object sender, SelectionChangedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as DanVxod;

                text1.Text = selected.Loggin.ToString();
                text2.Password = selected.Passwd.ToString();
                if (selected.Rol != null)
                {
                    Cb1.Text = selected.Rol.Roll.ToString();
                }
                else
                {
                    Cb1.Text = "";
                }
            }
        }
    }
}
