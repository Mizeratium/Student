using StudentAPK.Database;
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
                var _sel = ClassDB.connection.Student.Where(z => z.login == txbLogin.Text && z.password == txbPassword.Password).FirstOrDefault();
                if (_sel != null)
                {
                    if (_sel.role_id == 1 || _sel.role_id == 2)
                    {
                        NavigationService.Navigate(new Pages.PageTeacher()); //Зав и препод
                    }
                    //else if (_sel.role_id == 3)
                    //{
                    //    NavigationService.Navigate(new Pages.PageStudent()); //Студент
                    //}
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
