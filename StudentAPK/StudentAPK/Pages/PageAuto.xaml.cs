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

namespace StudentAPK.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAuto.xaml
    /// </summary>
    public partial class PageAuto : Page
    {
        public PageAuto()
        {
            InitializeComponent();
        }

        private void ClEventAuto(object sender, RoutedEventArgs e)
        {
            try
            {
                //var _sel = BD_Class.connection.Employee.Where(z => z.login == txbLogin.Text && z.password == txbPassword.Password).FirstOrDefault();
                //if (_sel != null)
                //{
                //    if (_sel.id_role == 1)
                //    {
                //        NavigationService.Navigate(new PageApp.AdminMenuPage()); //Администратор
                //    }
                //    else if (_sel.id_role == 2)
                //    {
                //        NavigationService.Navigate(new PageApp.CashierPage()); //Кассир
                //    }
                //    else
                //    {
                //        NavigationService.Navigate(new PageApp.EmployeePage()); //Сотрудник зала
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
