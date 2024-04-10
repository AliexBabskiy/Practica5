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
    /// Логика взаимодействия для AdminPageEMP.xaml
    /// </summary>
    public partial class AdminPageEMP : Page
    {
        private BdPractica5Entities context = new BdPractica5Entities();
        public AdminPageEMP()
        {
            InitializeComponent();
            tablic.ItemsSource = context.EMP.ToList();
            Cb1.ItemsSource = context.DanVxod.ToList();
            Cb2.ItemsSource = context.Smena.ToList();
        }
        private void BtDob_Cl(object sender, RoutedEventArgs e)
        {
            EMP o = new EMP();
            if (text1.Text == "")
            {
                Eror.Text = "Невозможно добавить сотрудника: \nОтсутствует фамилия";
                return;
            }
            else
            {
                o.SURNAME = Convert.ToString(text1.Text);
            }
            if (text2.Text == "")
            {
                Eror.Text = "Невозможно добавить сотрудника: \nОтсутствует имя";
                return;
            }
            else
            {
                o.FIRST_NAME = Convert.ToString(text2.Text);
            }
            
            o.MIDDLENAME = Convert.ToString(text3.Text);

            if (Cb1.SelectedItem != null)
            {
                var selected = Cb1.SelectedItem as DanVxod;
                o.DanVxod_ID = Convert.ToInt32(selected.ID_DanVxod);
            }

            if (Cb2.SelectedItem != null)
            {
                var selected = Cb2.SelectedItem as Smena;
                o.Smena_ID = Convert.ToInt32(selected.ID_Smena);
            }

            context.EMP.Add(o);
            try
            {
                context.SaveChanges();
                tablic.ItemsSource = context.EMP.ToList();
            }
            catch
            {
                Eror.Text = "Невозможно добавить сотрудника:\nВозможно логин или смена уже заняты\nили отсутствуют";
            }
        }
        private void BtIzm_Cl(object sender, RoutedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as EMP;

                if (text1.Text == "")
                {
                    Eror.Text = "Невозможно изменить сотрудника: \nОтсутствует фамилия";
                    return;
                }
                else
                {
                    selected.SURNAME = Convert.ToString(text1.Text);
                }
                if (text2.Text == "")
                {
                    Eror.Text = "Невозможно изменить сотрудника: \nОтсутствует имя";
                    return;
                }
                else
                {
                    selected.FIRST_NAME = Convert.ToString(text2.Text);
                }

                selected.MIDDLENAME = Convert.ToString(text3.Text);

                if (Cb1.SelectedItem != null)
                {
                    var selected1 = Cb1.SelectedItem as DanVxod;
                    selected.DanVxod_ID = Convert.ToInt32(selected1.ID_DanVxod);
                }

                if (Cb2.SelectedItem != null)
                {
                    var selected1 = Cb2.SelectedItem as Smena;
                    selected.Smena_ID = Convert.ToInt32(selected1.ID_Smena);
                }

                try
                {
                    context.SaveChanges();
                    tablic.ItemsSource = context.EMP.ToList();
                }
                catch
                {
                    Eror.Text = "Невозможно изменить сотрудника:\nВозможно логин или смена уже заняты\nили отсутствуют";
                }
            }
        }
        private void BtDel_Cl(object sender, RoutedEventArgs e)
        {
            var selected = tablic.SelectedItem as EMP;
            if (selected != null)
            {
                try
                {
                    context.EMP.Remove(selected);
                    context.SaveChanges();
                    tablic.ItemsSource = context.EMP.ToList();
                }
                catch
                {
                    Eror.Text = "Невозможно удалить сотрудника\nтак как он привязан к чеку";
                }
            }
        }
        private void tablic_Dob(object sender, SelectionChangedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as EMP;

                text1.Text = selected.SURNAME.ToString();
                text2.Text = selected.FIRST_NAME.ToString();
                text3.Text = selected.MIDDLENAME.ToString();
                if (selected.DanVxod != null)
                {
                    Cb1.Text = selected.DanVxod.Loggin.ToString();
                }
                else
                {
                    Cb1.Text = "";
                }
                if (selected.Smena != null)
                {
                    Cb2.Text = selected.Smena.Smens.ToString();
                }
                else
                {
                    Cb2.Text = "";
                }
            }
        }
    }
}
