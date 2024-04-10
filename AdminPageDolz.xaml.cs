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
    /// Логика взаимодействия для AdminPageDolz.xaml
    /// </summary>
    public partial class AdminPageDolz : Page
    {
        private BdPractica5Entities context = new BdPractica5Entities();
        public AdminPageDolz()
        {
            InitializeComponent();
            tablic.ItemsSource = context.Dolz.ToList();
        }
        private void BtDob_Cl(object sender, RoutedEventArgs e)
        {
            Dolz o = new Dolz();
            if (text1.Text == "")
            {
                Eror.Text = "Невозможно добавить должность: \nДолжность отсутствует";
                return;
            }
            else
            {
                o.Dolzn = Convert.ToString(text1.Text);
            }
            try
            {
                context.Dolz.Add(o);
                context.SaveChanges();
                tablic.ItemsSource = context.Dolz.ToList();
            }
            catch
            {
                Eror.Text = "Невозможно добавить должность\nтак как она уже существует";
            }
        }
        private void BtIzm_Cl(object sender, RoutedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as Dolz;

                if (text1.Text == "")
                {
                    Eror.Text = "Невозможно изменить должность: \nДолжность отсутствует";
                    return;
                }
                else
                {
                    selected.Dolzn = Convert.ToString(text1.Text);
                }

                try
                {
                    context.SaveChanges();
                    tablic.ItemsSource = context.Dolz.ToList();
                }
                catch
                {
                    Eror.Text = "Невозможно изменить должность\nтак как она уже существует";
                }
            }
        }
        private void BtDel_Cl(object sender, RoutedEventArgs e)
        {
            var selected = tablic.SelectedItem as Dolz;
            if (selected != null)
            {
                try
                {
                    context.Dolz.Remove(selected);
                    context.SaveChanges();
                    tablic.ItemsSource = context.Dolz.ToList();
                }
                catch
                {
                    Eror.Text = "Невозможно удалить должность\nтак как она привязана к сотруднику";
                }
            }
        }
        private void tablic_Dob(object sender, SelectionChangedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as Dolz;

                text1.Text = selected.Dolzn.ToString();
            }
        }
    }
}
