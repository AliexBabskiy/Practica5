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
    /// Логика взаимодействия для PageTovar.xaml
    /// </summary>
    public partial class PageTovar : Page
    {
        private BdPractica5Entities context = new BdPractica5Entities();
        public PageTovar()
        {
            InitializeComponent();
            tablic.ItemsSource = context.Tovar.ToList();
        }
        private void BtDob_Cl(object sender, RoutedEventArgs e)
        {
            Tovar o = new Tovar();
            if (text1.Text == "")
            {
                Eror.Text = "Невозможно добавить товар: \nОтсутствует название";
                return;
            }
            else
            {
                o.NameTovar = Convert.ToString(text1.Text);
            }

            if (text2.Text != "" && Convert.ToInt32(text2.Text) > 0)
            {
                o.Price = Convert.ToInt32(text2.Text);
            }
            else
            {
                Eror.Text = "Невозможно добавить товар: \nОтсутствует цена или она отрицательная";
                return;
            }
            if (text3.Text == "")
            {
                o.Kolichestvo = null;
            }
            else if (Convert.ToInt32(text3.Text) < 0)
            {
                Eror.Text = "Невозможно добавить товар: \nОтрицательное количество";
                return;
            }
            else
            {
                o.Kolichestvo = Convert.ToInt32(text3.Text);
            }

            try
            {
                context.Tovar.Add(o);
                context.SaveChanges();
                tablic.ItemsSource = context.Tovar.ToList();
            }
            catch
            {
                Eror.Text = "Невозможно добавить товар\nтак как он уже существует";
            }
        }
        private void BtIzm_Cl(object sender, RoutedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as Tovar;

                if (text1.Text == "")
                {
                    Eror.Text = "Невозможно изменить товар: \nОтсутствует название";
                    return;
                }
                else
                {
                    selected.NameTovar = Convert.ToString(text1.Text);
                }
                if (text2.Text != "" && Convert.ToInt32(text2.Text) > 0)
                {
                    selected.Price = Convert.ToInt32(text2.Text);
                }
                else
                {
                    Eror.Text = "Невозможно изменить товар: \nОтсутствует цена или она отрицательная";
                    return;
                }
                if (text3.Text == "")
                {
                    selected.Kolichestvo = null;
                }
                else if (Convert.ToInt32(text3.Text) < 0)
                {
                    Eror.Text = "Невозможно изменить товар: \nОтрицательное количество";
                    return;
                }
                else
                {
                    selected.Kolichestvo = Convert.ToInt32(text3.Text);
                }

                try
                {
                    context.SaveChanges();
                    tablic.ItemsSource = context.Tovar.ToList();
                }
                catch
                {
                    Eror.Text = "Невозможно изменить товар\nтак как такой товар уже существует";
                }
            }
        }
        private void BtDel_Cl(object sender, RoutedEventArgs e)
        {
            var selected = tablic.SelectedItem as Tovar;
            if (selected != null)
            {
                try
                {
                    context.Tovar.Remove(selected);
                    context.SaveChanges();
                    tablic.ItemsSource = context.Tovar.ToList();
                }
                catch
                {
                    Eror.Text = "Невозможно удалить товар\nтак как он связан с корзиной";
                }
            }
        }
        private void tablic_Dob(object sender, SelectionChangedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as Tovar;

                text1.Text = selected.NameTovar.ToString();
                text2.Text = selected.Price.ToString();
                text3.Text = selected.Kolichestvo.ToString();
            }
        }
    }
}
