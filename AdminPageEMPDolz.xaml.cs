using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Логика взаимодействия для AdminPageEMPDolz.xaml
    /// </summary>
    public partial class AdminPageEMPDolz : Page
    {
        private BdPractica5Entities context = new BdPractica5Entities();
        public AdminPageEMPDolz()
        {
            InitializeComponent();
            tablic.ItemsSource = context.EMPDolz.ToList();
            Cb1.ItemsSource = context.EMP.ToList();
            Cb2.ItemsSource = context.Dolz.ToList();
        }

        private void BtDob_Cl(object sender, RoutedEventArgs e)
        {
            EMPDolz o = new EMPDolz();

            if (Cb1.SelectedItem != null)
            {
                var selected = Cb1.SelectedItem as EMP;
                o.EMP_ID = Convert.ToInt32(selected.ID_EMP);
            }

            if (Cb2.SelectedItem != null)
            {
                var selected2 = Cb2.SelectedItem as Dolz;
                o.Dolz_ID = Convert.ToInt32(selected2.ID_Dolz);
            }
            try
            {
                context.EMPDolz.Add(o);
                context.SaveChanges();
                tablic.ItemsSource = context.EMPDolz.ToList();
            }
            catch
            {
                Eror.Text = "Невозможно добавить данные:\nСотрудник или должность невыбраны";
            }
        }

        private void BtDel_Cl(object sender, RoutedEventArgs e)
        {
            var selected = tablic.SelectedItem as EMPDolz;
            if (selected != null)
            {
                context.EMPDolz.Remove(selected);
                context.SaveChanges();
                tablic.ItemsSource = context.EMPDolz.ToList();
            }
        }

        private void BtIzm_Cl(object sender, RoutedEventArgs e)
        {
            var selected = tablic.SelectedItem as EMPDolz;

            if (Cb1.SelectedItem != null)
            {
                var selected1 = Cb1.SelectedItem as EMP;
                selected.EMP_ID = Convert.ToInt32(selected1.ID_EMP);
            }

            if (Cb2.SelectedItem != null)
            {
                var selected1 = Cb2.SelectedItem as Dolz;
                selected.Dolz_ID = Convert.ToInt32(selected1.ID_Dolz);
            }

            try
            {
                context.SaveChanges();
                tablic.ItemsSource = context.EMPDolz.ToList();
            }
            catch
            {
                Eror.Text = "Невозможно изменить данные:\nСотрудник или должность невыбраны";
            }
        }
        private void tablic_Dob(object sender, SelectionChangedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as EMPDolz;

                if (selected.EMP != null)
                {
                    Cb1.Text = selected.EMP.SURNAME.ToString();
                }
                else
                {
                    Cb1.Text = "";
                }
                if (selected.Dolz != null)
                {
                    Cb2.Text = selected.Dolz.Dolzn.ToString();
                }
                else
                {
                    Cb2.Text = "";
                }
            }
        }
    }
}
