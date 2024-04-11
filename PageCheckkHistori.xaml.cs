using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
    /// Логика взаимодействия для PageCheckkHistori.xaml
    /// </summary>
    public partial class PageCheckkHistori : Page
    {
        private BdPractica5Entities context = new BdPractica5Entities();
        public string orderDetails;
        public PageCheckkHistori()
        {
            InitializeComponent();
            tablic.ItemsSource = context.Checkk.ToList();
        }

        private void Bt_Cl(object sender, RoutedEventArgs e)
        {
            foreach (var ithem in context.Checkk)
            {
                int id = ithem.ID_Checkk;
                string dat = ithem.Date_of_purchase;
                string SURNAME = ithem.EMP.SURNAME;
                string FIRST_NAME = ithem.EMP.FIRST_NAME;
                string Tovar = ithem.Korzina.Tovar.NameTovar;
                int KolVo = ithem.Korzina.KolichestvoVKorzine;
                int Prices = ithem.Korzina.Tovar.Price;
                string ClientName = ithem.Client.ClientName;
                int Summn = ithem.Summ_Check;
                int Vneseno = ithem.Vneseno;
                int Sdacha = 0;
                if (ithem.Sdacha != null)
                    Sdacha = (int)ithem.Sdacha;

                orderDetails = orderDetails + "\n\t\t\tКассовый чек №" + id + "\n\n\n\t\t\tДата покупки: " + dat + "\n\t\t\tОбслуживающий сотрудник: " + SURNAME + " " + FIRST_NAME + "\n\t\t\t" + Tovar + " " + KolVo + " " + Prices + "\n\t\t\tКлиент: " + ClientName + "\n\t\t\tИтого к оплате: " + Summn + "\n\t\t\tВнесено: " + Vneseno + "\n\t\t\tСдача: " + Sdacha;
            }
            string fileName = "C:\\Users\\Александр\\Desktop\\Чеки.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(orderDetails);
            }
        }
    }
}
