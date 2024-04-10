using Microsoft.VisualBasic;
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
    /// Логика взаимодействия для PageClient.xaml
    /// </summary>
    public partial class PageClient : Page
    {
        private BdPractica5Entities context = new BdPractica5Entities();
        public PageClient()
        {
            InitializeComponent();
            tablic.ItemsSource = context.Client.ToList();
        }

        private void BtDob_Cl(object sender, RoutedEventArgs e)
        {
            Client o = new Client();
            if (text1.Text == "")
            {
                Eror.Text = "Невозможно добавить клиента: \nОтсутствует имя";
                return;
            }
            else
            {
                o.ClientName = Convert.ToString(text1.Text);
            }

            if (Information.IsNumeric(text2.Text) & Convert.ToString(text2.Text).Length == 11)
            {
                o.NumberPhone = Convert.ToString(text2.Text);
            }
            else
            {
                Eror.Text = "Некорректный номер телефона";
            }

            context.Client.Add(o);
            context.SaveChanges();
            tablic.ItemsSource = context.Client.ToList();
        }
        private void BtIzm_Cl(object sender, RoutedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as Client;

                if (text1.Text == "")
                {
                    Eror.Text = "Невозможно изменить клиента: \nОтсутствует имя";
                    return;
                }
                else
                {
                    selected.ClientName = Convert.ToString(text1.Text);
                }

                if (Information.IsNumeric(text2.Text) & Convert.ToString(text2.Text).Length == 11)
                {
                    selected.NumberPhone = Convert.ToString(text2.Text);
                }
                else
                {
                    Eror.Text = "Некорректный номер телефона";
                }

                context.SaveChanges();
                tablic.ItemsSource = context.Client.ToList();
            }
        }
        private void BtDel_Cl(object sender, RoutedEventArgs e)
        {
            var selected = tablic.SelectedItem as Client;
            if (selected != null)
            {
                try
                {
                    context.Client.Remove(selected);
                    context.SaveChanges();
                    tablic.ItemsSource = context.Client.ToList();
                }
                catch
                {
                    Eror.Text = "Невозможно удалить клиента\nтак как он привязан к чеку";
                }
            }
        }
        private void tablic_Dob(object sender, SelectionChangedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as Client;

                text1.Text = selected.ClientName.ToString();
                if (selected.NumberPhone != null)
                {
                    text2.Text = selected.NumberPhone.ToString();
                }
                else
                {
                    text2.Text = "";
                }
            }
        }
    }
}
