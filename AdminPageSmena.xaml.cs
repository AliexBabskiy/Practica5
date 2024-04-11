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
    /// Логика взаимодействия для AdminPageSmena.xaml
    /// </summary>
    public partial class AdminPageSmena : Page
    {
        private BdPractica5Entities context = new BdPractica5Entities();
        public AdminPageSmena()
        {
            InitializeComponent();
            tablic.ItemsSource = context.Smena.ToList();
        }
        private void BtDob_Cl(object sender, RoutedEventArgs e)
        {
            Smena o = new Smena();
            if (text1.Text == "" || Convert.ToInt32(text1.Text) < 0)
            {
                Eror.Text = "Невозможно добавить: \nОтсутствует количество смен\nили количество некорректно";
                return;
            }
            else if (Information.IsNumeric(text1.Text))
            {
                o.Smens = Convert.ToInt32(text1.Text);
            }
            if (text2.Text == "" || Convert.ToInt32(text2.Text) < 0)
            {
                Eror.Text = "Невозможно добавить: \nОтсутствуют часы смен\nили они некорректны";
                return;
            }
            else if (Information.IsNumeric(text2.Text))
            {
                o.Hourr = Convert.ToInt32(text2.Text);
            }

            context.Smena.Add(o);
            context.SaveChanges();
            tablic.ItemsSource = context.Smena.ToList();
        }
        private void BtIzm_Cl(object sender, RoutedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as Smena;

                if (text1.Text == "" || Convert.ToInt32(text1.Text) < 0)
                {
                    Eror.Text = "Невозможно изменить: \nОтсутствует количество смен\nили их количество некорректно";
                    return;
                }
                else if (Information.IsNumeric(text1.Text))
                {
                    selected.Smens = Convert.ToInt32(text1.Text);
                }
                if (text2.Text == "" || Convert.ToInt32(text2.Text) < 0)
                {
                    Eror.Text = "Невозможно изменить: \nОтсутствуют часы смен\nили они некорректны";
                    return;
                }
                else if (Information.IsNumeric(text2.Text))
                {
                    selected.Hourr = Convert.ToInt32(text2.Text);
                }

                context.SaveChanges();
                tablic.ItemsSource = context.Smena.ToList();
            }
        }
        private void BtDel_Cl(object sender, RoutedEventArgs e)
        {
            var selected = tablic.SelectedItem as Smena;
            if (selected != null)
            {
                try
                {
                    context.Smena.Remove(selected);
                    context.SaveChanges();
                    tablic.ItemsSource = context.Smena.ToList();
                }
                catch
                {
                    Eror.Text = "Невозможно удалить смену\nтак как она привязана к сотруднику";
                }
            }
        }
        private void tablic_Dob(object sender, SelectionChangedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as Smena;

                text1.Text = selected.Smens.ToString();
                text2.Text = selected.Hourr.ToString();
            }
        }
    }
}
