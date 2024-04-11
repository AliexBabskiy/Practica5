using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace PePract5
{
    /// <summary>
    /// Логика взаимодействия для PageCheckk.xaml
    /// </summary>
    public partial class PageCheckk : Page
    {
        private BdPractica5Entities context = new BdPractica5Entities();
        public DateTime today = DateTime.Now;
        public PageCheckk()
        {
            InitializeComponent();
            tablic.ItemsSource = context.Korzina.ToList();
            Cb1.ItemsSource = context.EMP.ToList();
            Cb2.ItemsSource = context.Client.ToList();
        }

        private void Dob_Cl(object sender, RoutedEventArgs e)
        {
            var selected = tablic.SelectedItem as Korzina;

            nameTovar.Text = selected.Tovar.NameTovar.ToString();
            KolVo.Text = selected.KolichestvoVKorzine.ToString();
            Prices.Text = selected.Tovar.Price.ToString();

            nameSummN.Text = Convert.ToString(Convert.ToInt32(Prices.Text) * Convert.ToInt32(KolVo.Text));
        }
        private void Del_Cl(object sender, RoutedEventArgs e)
        {
            nameTovar.Text = "";
            KolVo.Text = "";
            Prices.Text = "";

            nameSummN.Text = "";
        }

        private void DobCheckk_Cl(object sender, RoutedEventArgs e)
        {

            if (nameTovar.Text == "")
            {
                Er.Text = "Выберите товар из корзины";
                return;
            }
            else if (Cb1.SelectedItem == null)
            {
                Er.Text = "Выберите сотрудника";
                return;
            }
            else if (Cb2.SelectedItem == null)
            {
                Er.Text = "Выберите клиента";
                return;
            }
            else if (Convert.ToInt32(text1.Text) < Convert.ToInt32(nameSummN.Text))
            {
                Er.Text = "Недостаточно средств";
                return;
            }
            else if (Information.IsNumeric(text1.Text) & Convert.ToInt32(text1.Text) >= Convert.ToInt32(nameSummN.Text))
            {
                var selected = tablic.SelectedItem as Korzina;
                var selected1 = Cb1.SelectedItem as EMP;
                string SURNAME = Convert.ToString(selected1.SURNAME);
                string MIDDLENAME = Convert.ToString(selected1.MIDDLENAME);

                var selected2 = Cb2.SelectedItem as Client;
                string ClientName = Convert.ToString(selected2.ClientName);

                string dat = today.ToShortDateString();
                //dat = dat + "." + Convert.ToString(today.Month);
                //dat = dat + "." + Convert.ToString(today.Year);

                Checkk o = new Checkk();
                o.Summ_Check = Convert.ToInt32(nameSummN.Text);
                o.Date_of_purchase = dat;
                o.Vneseno = Convert.ToInt32(text1.Text);
                o.Sdacha = Convert.ToInt32(text1.Text) - Convert.ToInt32(nameSummN.Text);
                o.EMP_ID = Convert.ToInt32(selected1.ID_EMP);
                o.Client_ID = Convert.ToInt32(selected2.ID_Client);
                o.Korzina_ID = Convert.ToInt32(selected.ID_Korzina);

                context.Checkk.Add(o);
                context.SaveChanges();

                int id = o.ID_Checkk;

                string fileName = "C:\\Users\\Александр\\Desktop\\Чек №"+id+".txt";
                string orderDetails = "\t\t\tИнформационна Система (ИС) Кофейни" + "\n\t\t\tКассовый чек №" + id + "\n\n\n\t\t\tДата покупки: " + dat + "\n\t\t\tОбслуживающий сотрудник: " + SURNAME + MIDDLENAME + "\n\t\t\t" + nameTovar.Text + KolVo.Text + Prices.Text + "\n\t\t\tКлиент: " + ClientName + "\n\t\t\tИтого к оплате: " + nameSummN.Text + "\n\t\t\tВнесено: " + text1.Text + "\n\t\t\tСдача: " + (Convert.ToInt32(text1.Text) - Convert.ToInt32(nameSummN.Text));

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(orderDetails);
                }
            }
        }
    }
}
