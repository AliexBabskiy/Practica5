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
    /// Логика взаимодействия для PageKorzina.xaml
    /// </summary>
    public partial class PageKorzina : Page
    {
        private BdPractica5Entities context = new BdPractica5Entities();
        public PageKorzina()
        {
            InitializeComponent();
            tablic.ItemsSource = context.Korzina.ToList();
            Cb1.ItemsSource = context.Tovar.ToList();
        }
        private void BtDob_Cl(object sender, RoutedEventArgs e)
        {
            Korzina o = new Korzina();

            if (text1.Text == "" || Convert.ToInt32(text1.Text) <= 0)
            {
                Eror.Text = "Невозможно добавить корзину: \nНеверное количество";
                return;
            }
            else
            {
                o.KolichestvoVKorzine = Convert.ToInt32(text1.Text);
            }

            if (Cb1.SelectedItem != null)
            {
                var selected = Cb1.SelectedItem as Tovar;
                o.Tovar_ID = Convert.ToInt32(selected.ID_Tovar);
            }

            try
            {
                context.Korzina.Add(o);
                context.SaveChanges();
                tablic.ItemsSource = context.Korzina.ToList();
            }
            catch
            {
                Eror.Text = "Невозможно добавить корзину:\nТовар отсутствует";
            }
        }
        private void BtIzm_Cl(object sender, RoutedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as Korzina;

                if (text1.Text == "" || Convert.ToInt32(text1.Text) <= 0)
                {
                    Eror.Text = "Невозможно изменить корзину: \nНеверное количество";
                    return;
                }
                else
                {
                    selected.KolichestvoVKorzine = Convert.ToInt32(text1.Text);
                }

                if (Cb1.SelectedItem != null)
                {
                    var selected1 = Cb1.SelectedItem as Tovar;
                    selected.Tovar_ID = Convert.ToInt32(selected1.ID_Tovar);
                }
                try
                {
                    context.SaveChanges();
                    tablic.ItemsSource = context.Korzina.ToList();
                }
                catch
                {
                    Eror.Text = "Невозможно изменить корзину:\nТовар отсутствует";
                }
            }
        }
        private void BtDel_Cl(object sender, RoutedEventArgs e)
        {
            var selected = tablic.SelectedItem as Korzina;
            if (selected != null)
            {
                try
                {
                    context.Korzina.Remove(selected);
                    context.SaveChanges();
                    tablic.ItemsSource = context.Korzina.ToList();
                }
                catch
                {
                    Eror.Text = "Невозможно удалить корзину\nтак как она привязана к чеку";
                }
            }
        }
        private void tablic_Dob(object sender, SelectionChangedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as Korzina;

                text1.Text = selected.KolichestvoVKorzine.ToString();

                if (selected.Tovar != null)
                {
                    Cb1.Text = selected.Tovar.NameTovar.ToString();
                }
                else
                {
                    Cb1.Text = "";
                }
            }
        }
    }
}
